using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;

namespace Hermes.DataModel
{
    public static class ExpenseExtensions
    {
        /// <summary>
        /// Converts the list of expenses to a DataTable, with columns for each field.
        /// </summary>
        /// <param name="expenses">The list of expenses to convert.</param>
        /// <returns>The converted list as a DataTable.</returns>
        public static DataTable ToDataTable(this List<Expense> expenses)
        {
            DataTable table = new DataTable();

            // TODO: reflection or something to automatically generate this ?
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Comment", typeof(string));
            table.Columns.Add("EventId", typeof(int));
            table.Columns.Add("AuthorId", typeof(int));

            foreach (Expense expense in expenses)
            {
                int id = expense.Id;
                string description = expense.Description;
                decimal amount = expense.Amount;
                DateTime date = expense.Date;
                string comment = expense.Comment;
                int eventId = expense.EventId;
                int authorId = expense.AuthorId;

                table.Rows.Add(id, description, amount, date, comment, eventId, authorId);
            }

            return table;
        }
    }

    public class Expense
    {
        public int Id;
        public string Description;
        public decimal Amount;
        public DateTime Date;
        public string Comment;
        public int EventId;
        public int AuthorId;

        public Expense() 
            : base()
        {
        }

        public Expense(OleDbDataReader reader) 
            : base()
        {
            this.Id = reader.GetInt32(0);
            this.Description = reader.GetString(1);
            this.Amount = reader.GetInt32(2);
            this.Date = reader.GetDateTime(3);
            this.Comment = reader.GetString(4);
            this.EventId = reader.GetInt32(5);
            this.AuthorId = reader.GetInt32(6);
        }

        public PartyEvent GetEvent()
        {
            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select * from Evenements where codeEvent = @EventId",
                db);
            command.Parameters.AddWithValue("@EventId", this.EventId);

            OleDbDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            return new PartyEvent(dataReader);
        }

        public List<Participant> GetBeneficiaires()
        {
            List<Participant> beneficiaries = new List<Participant>();

            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "select codePart from Beneficiaires where numDepense = @Id",
                db);
            command.Parameters.AddWithValue("@Id", this.Id);

            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                int beneficiaryId = dataReader.GetInt32(0);

                Participant participant = Participant.GetParticipant(beneficiaryId);
                if (participant == null)
                    throw new DatabaseFetchException("Beneficiary for expense does not exist");

                beneficiaries.Add(participant);
            }

            return beneficiaries;
        }

        public static Expense GetFromId(int id)
        {
            OleDbConnection db = Database.Connect();
            
            OleDbCommand command = new OleDbCommand(
                "select * from Expenditure where numDepense = @Id",
                db);
            command.Parameters.AddWithValue("@Id", id);

            OleDbDataReader dataReader = command.ExecuteReader();
            dataReader.Read();

            return new Expense(dataReader);
        }
    }

}
