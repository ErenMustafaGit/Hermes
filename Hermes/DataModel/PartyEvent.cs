using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hermes.DataModel
{
    public static class PartyEventExtensions
    {
        /// <summary>
        /// Converts the list of expenses to a DataTable, with columns for each field.
        /// </summary>
        /// <param name="expenses">The list of expenses to convert.</param>
        /// <returns>The converted list as a DataTable.</returns>
        public static DataTable ToDataTable(this List<PartyEvent> events)
        {
            DataTable table = new DataTable();

            // TODO: reflection or something to automatically generate this ?
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("StartDate", typeof(DateTime));
            table.Columns.Add("EndDate", typeof(DateTime));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Completed", typeof(bool));
            table.Columns.Add("AuthorId", typeof(int));

            foreach (PartyEvent ev in events)
            {
                int id = ev.Id;
                string name = ev.Name;
                DateTime start = ev.StartDate;
                DateTime end = ev.EndDate;
                string description = ev.Description;
                bool completed = ev.Completed;
                int authorId = ev.AuthorId;

                table.Rows.Add(id, name, start, end, description, completed, authorId);
            }

            return table;
        }
    }

    public class PartyEvent
    {
        public int Id;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Description;
        public bool Completed;
        public int AuthorId;

        public PartyEvent() : base() { }

        public PartyEvent(OleDbDataReader reader)
            : base()
        {
            this.Id = reader.GetInt32(0);
            this.Name = reader.GetString(1);
            this.StartDate = reader.GetDateTime(2);
            this.EndDate = reader.GetDateTime(3);
            this.Description = reader.GetString(4);
            this.Completed = reader.GetBoolean(5);
            this.AuthorId = reader.GetInt32(6);
        }

        public static PartyEvent GetFromId(int id)
        {
            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select * from Evenements where codeEvent = @Id",
                db);
            command.Parameters.AddWithValue("@Id", id);

            OleDbDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            return new PartyEvent(dataReader);
        }

        public List<Participant> GetGuests()
        {
            List<Participant> guests = new List<Participant>();

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select codePart from Invites where codeEvent = @Id",
                db);
            command.Parameters.AddWithValue("@Id", this.Id);

            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                // FIXME: Couldn't an imbricated request be used instead..?
                OleDbCommand commandGuest = new OleDbCommand(
                    "select * from Participants where codeParticipant = @GuestId",
                    db);
                commandGuest.Parameters.AddWithValue("@GuestId", dataReader.GetInt32(0) /* eww */);

                OleDbDataReader dataReaderGuest = commandGuest.ExecuteReader();

                dataReaderGuest.Read();
                guests.Add(new Participant(dataReaderGuest));
            }

            return guests;
        }

        public List<Participant> GetUninvitedPeople()
        {
            List<Participant> uninvited = Database.FetchParticipant();

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select codePart from Invites where codeEvent = @Id",
                db);
            command.Parameters.AddWithValue("@Id", this.Id);

            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                uninvited.RemoveAt(uninvited.FindIndex(x => x.CodeParticipant == id));
            }

            return uninvited;
        }

        public List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select * from Depenses where codeEvent = @Id",
                db);
            command.Parameters.AddWithValue("@Id", this.Id);

            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
                expenses.Add(new Expense(dataReader));

            return expenses;
        }

        public int GetNbPart()
        {
            int nbPart = -1;

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "SELECT count(*) FROM Invites WHERE codeEvent = @Id",
                db);
            command.Parameters.AddWithValue("@Id", this.Id);

            nbPart = (int)command.ExecuteScalar();

            return nbPart;
        }

        public static int GetMaxCode()
        {
            int codeMax = -1;

            OleDbConnection db = Database.Connect();

            string sql = "SELECT MAX(codeEvent) FROM Evenements";
            OleDbCommand command = new OleDbCommand(sql, db);

            codeMax = (int)command.ExecuteScalar();

            return codeMax;
        }

        public class Due
        {
            private Participant m_From, m_To;
            private decimal m_Amount = 0.0m;

            public int FromId;
            public int ToId;

            public decimal Amount
            {
                set
                {
                    // no negative values allowed, we just reverse everything
                    if (value < 0)
                    {
                        m_Amount = -value;

                        (m_From, m_To) = (m_To, m_From);
                        (FromId, ToId) = (ToId, FromId);
                    }
                    else
                        m_Amount = value;
                }
                get => m_Amount;
            }

            public Participant From
            {
                get
                {
                    if (m_From == null)
                        m_From = Participant.GetParticipant(FromId);
                    return m_From;
                }
            }

            public Participant To
            {
                get
                {
                    if (m_To == null)
                        m_To = Participant.GetParticipant(ToId);
                    return m_To;
                }
            }
        }

        public List<Due> CalculateDues()
        {
            // FIXME: Very unoptimized, lacks caching, terrible complexity, etc.

            List<Due> dues = new List<Due>();

            List<Expense> expenses = this.GetExpenses();

            foreach (Expense expense in expenses)
            {
                List<Participant> beneficiairies = expense.GetBeneficiaires();
                int totalParts = beneficiairies.Sum(p => p.NbParts);

                int target = expense.AuthorId;
                decimal amount = expense.Amount;
                foreach (Participant beneficiary in beneficiairies)
                {
                    int source = beneficiary.CodeParticipant;

                    // People do not really owe themselves money.
                    if (target == source)
                        continue;

                    // Look for an existing link between two people.
                    Due due = dues.Find(
                        d => (d.FromId, d.ToId) == (target, source) || (d.FromId, d.ToId) == (source, target));

                    // Create one if none was found.
                    if (due == null)
                    {
                        due = new Due() { FromId = source, ToId = target };
                        dues.Add(due);
                    }

                    // Increase the amount due (or decrease it, if it's better this way).
                    decimal v = (amount / totalParts) * beneficiary.NbParts;
                    if (due.FromId == target)
                        v = -v;

                    due.Amount += v;
                }
            }

            return dues;
        }

        public void CloseEvent()
        {

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "UPDATE Evenements SET soldeON = true WHERE codeEvent = @Id ",
                db);

            command.Parameters.AddWithValue("@Id", this.Id);
            command.ExecuteNonQuery();
        }
    }
}
