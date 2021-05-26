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

                // FIXME: use a ctor that takes a DataReader
                Participant guest = new Participant();
                guest.CodeParticipant = dataReaderGuest.GetInt32(0);
                guest.FirstName = dataReaderGuest.GetString(1);
                guest.LastName = dataReaderGuest.GetString(2);
                guest.PhoneNumber = dataReaderGuest.GetString(3);
                guest.NbParts = dataReaderGuest.GetInt32(4);

                //Si le solde est null
                if (!dataReaderGuest.IsDBNull(5))
                {
                    guest.Balance = dataReaderGuest.GetDouble(5);
                }
                guest.Mail = dataReaderGuest.GetString(6);

                guests.Add(guest);
            }

            return guests;
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

    }
}
