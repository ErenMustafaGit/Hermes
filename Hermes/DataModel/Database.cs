using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Hermes.DataModel
{
    public class DatabaseFetchException : Exception
    {
        public DatabaseFetchException(string message) : base(message)
        {
        }
    }

    public class DatabaseInsertException : Exception
    {
        public DatabaseInsertException(string message) : base(message)
        {
        }
    }

    public static class Database
    {
        const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../bdEvents.mdb'";
        static OleDbConnection connection = null;
        static DataSet dataset;

        public static OleDbConnection Connect()
        {
            if (connection != null)
            {
                // If we already have a connection open, we just return it.
                if (connection.State == ConnectionState.Open)
                    return connection;

                // Otherwise, we disconnect it and recreate one.
                Disconnect();
            }

            connection = new OleDbConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void Disconnect()
        {
            connection?.Close();
            connection = null;
        }

        public static List<PartyEvent> FetchEvents()
        {
            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Evenements", db); // FIXME: request specific fields to not mess the order up

            OleDbDataReader dataReader = command.ExecuteReader();
            List<PartyEvent> partyEvents = new List<PartyEvent>();

            while (dataReader.Read())
                partyEvents.Add(new PartyEvent(dataReader));

            return partyEvents;
        }

        public static List<PartyEvent> FetchUncompletedEvents()
        {
            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Evenements where soldeON = false", db); // FIXME: request specific fields to not mess the order up

            OleDbDataReader dataReader = command.ExecuteReader();
            List<PartyEvent> partyEvents = new List<PartyEvent>();

            while (dataReader.Read())
                partyEvents.Add(new PartyEvent(dataReader));

            return partyEvents;
        }

        public static List<Participant> FetchParticipant()
        {
            List<Participant> participants = new List<Participant>();

            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Participants", db);
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Participant participant = new Participant();
                participant.CodeParticipant = dataReader.GetInt32(0);
                participant.FirstName = dataReader.GetString(1);
                participant.LastName = dataReader.GetString(2);
                participant.PhoneNumber = dataReader.GetString(3);
                participant.NbParts = dataReader.GetInt32(4);

                // Si le solde est null
                if (!dataReader.IsDBNull(5))
                {
                    participant.Balance = dataReader.GetDouble(5);
                }
                participant.Mail = dataReader.GetString(6);

                participants.Add(participant);
            }
            
            return participants;
        }

        // TODO: reimplement
        public static void FillDataSet()
        {
            dataset = new DataSet();

            OleDbConnection db = Database.Connect();
            DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                new object[] { null, null, null, "TABLE" });
            for(int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string tableName = schemaTable.Rows[i][2].ToString();
                OleDbCommand command = new OleDbCommand("select * from " + tableName, connection);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                dataAdapter.Fill(dataset, tableName);
            }
        }
        
        // TODO: reimplement
        public static BindingSource GetBindingSource(string tableName)
        {
            BindingSource bindingSource = new BindingSource();
            
            FillDataSet();
            DataTable table = dataset.Tables[tableName];
            bindingSource.DataSource = table;

            return bindingSource;
        }

        public static void InsertExpense(Expense expense, List<Participant> recipients)
        {
            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "insert into Depenses values (@Id,@Description,@Amount,@Date,@Comment,@EventId,@AuthorId)",
                db);
            command.Parameters.AddWithValue("@Id", expense.Id);
            command.Parameters.AddWithValue("@Description", expense.Description);
            command.Parameters.AddWithValue("@Amount", expense.Amount.ToString(CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@Date", expense.Date);
            command.Parameters.AddWithValue("@Comment", expense.Comment);
            command.Parameters.AddWithValue("@EventId", expense.EventId);
            command.Parameters.AddWithValue("@AuthorId", expense.AuthorId);

            int nb = command.ExecuteNonQuery();
            if (nb <= 0)
                throw new DatabaseInsertException("Failed to insert expense");


            // FIXME: Isn't there a better way to do this, in an atomic way..?

            List<string> pairs = new List<string>();
            foreach (Participant recipient in recipients)
            {
                command = new OleDbCommand(
                    "insert into Beneficiaires (numDepense,codePart) values (@Id,@RecipientId)",
                    db);
                command.Parameters.AddWithValue("@Id", expense.Id);
                command.Parameters.AddWithValue("@RecipientId", recipient.CodeParticipant);

                nb = command.ExecuteNonQuery();
                if (nb <= 0)
                    throw new DatabaseInsertException("Failed to insert recipient for new expense");
            }
        }

        public static void InsertGuestsForEvent(PartyEvent ev, List<Participant> guests)
        {
            OleDbConnection db = Database.Connect();

            // FIXME: Would be better as a single insert
            foreach (Participant guest in guests)
            {
                OleDbCommand command = new OleDbCommand(
                    "insert into Invites values (@EventId,@GuestId,'','')",
                    db);
                command.Parameters.AddWithValue("@EventId", ev.Id);
                command.Parameters.AddWithValue("@GuestId", guest.CodeParticipant);

                if (command.ExecuteNonQuery() <= 0)
                    throw new DatabaseInsertException("Could not insert guest for event");
            }
        }

        public static void InsertEvent(PartyEvent partyEvent, List<Participant> guests)
        {
            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "insert into Evenements values (@Id,@Name,@StartDate,@EndDate,@Description,@Completed,@AuthorId)",
                db);
            command.Parameters.AddWithValue("@Id", partyEvent.Id);
            command.Parameters.AddWithValue("@Name", partyEvent.Name);
            command.Parameters.AddWithValue("@StartDate", partyEvent.StartDate);
            command.Parameters.AddWithValue("@EndDate", partyEvent.EndDate);
            command.Parameters.AddWithValue("@Description", partyEvent.Description);
            command.Parameters.AddWithValue("@Completed", partyEvent.Completed);
            command.Parameters.AddWithValue("@AuthorId", partyEvent.AuthorId);

            if (command.ExecuteNonQuery() <= 0)
                throw new DatabaseInsertException("Could not insert event");

            InsertGuestsForEvent(partyEvent, guests);
        }

        public static void InsertParticipant(Participant participant)
        {
            OleDbConnection db = Database.Connect();

            OleDbCommand command = new OleDbCommand(
                "insert into Participants values (@Id,@LastName,@FirstName,@PhoneNumber,@Shares,@Balance,@Email)",
                db);
            command.Parameters.AddWithValue("@Id", participant.CodeParticipant);
            command.Parameters.AddWithValue("@LastName", participant.LastName);
            command.Parameters.AddWithValue("@FirstName", participant.FirstName);
            command.Parameters.AddWithValue("@PhoneNumber", participant.PhoneNumber);
            command.Parameters.AddWithValue("@Shares", participant.NbParts);
            command.Parameters.AddWithValue("@Balance", participant.Balance);
            command.Parameters.AddWithValue("@Email", participant.Mail);

            if (command.ExecuteNonQuery() <= 0)
                throw new DatabaseInsertException("Could not insert participant");
        }

        public static List<Expense> FetchExpenses()
        {
            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Depenses", db);

            List<Expense> expenses = new List<Expense>();

            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
                expenses.Add(new Expense(dataReader));
            
            return expenses;
        }
    }
}
