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

namespace Hermes.DataModel
{
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
            List<PartyEvent> partyEvents = new List<PartyEvent>();

            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Evenements", db); // FIXME: request specific fields to not mess the order up
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                PartyEvent ev = new PartyEvent()
                {
                    Code = dataReader.GetInt32(0),
                    Title = dataReader.GetString(1),
                    BeginDate = dataReader.GetDateTime(2),
                    EndDate = dataReader.GetDateTime(3),
                    Description = dataReader.GetString(4),
                    BalanceYN = dataReader.GetBoolean(5),
                    CodeCreator = dataReader.GetInt32(6)
                };
                partyEvents.Add(ev);
            }

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
                "insert into Depenses values (@Id,@Description,@Date,@Comment,@EventId,@AuthorId)",
                db);
            command.Parameters.AddWithValue("@Id", expense.Id);
            command.Parameters.AddWithValue("@Description", expense.Description);
            command.Parameters.AddWithValue("@Date", expense.Date);
            command.Parameters.AddWithValue("@Comment", expense.Comment);
            command.Parameters.AddWithValue("@EventId", expense.EventId);
            command.Parameters.AddWithValue("@AuthorId", expense.AuthorId);

            int nb = command.ExecuteNonQuery();
            if (nb <= 0)
                throw new DatabaseInsertException("Failed to insert expense");


            // FIXME: Isn't there a better way to do this..?
            // Forgive me, for I have sinned...

            List<string> pairs = new List<string>();
            foreach (Participant recipient in recipients)
                pairs.Add(String.Format("({0},{1})", expense.Id, recipient.CodeParticipant));
            
            if (pairs.Count > 0)
            {
                command = new OleDbCommand(
                    "insert into Beneficiaires (numDepense, codePart) values "
                        + String.Join(",", pairs),
                    db);

                nb = command.ExecuteNonQuery();
                if (nb <= 0)
                    throw new DatabaseInsertException("Failed to insert recipients for new expense");
            }
        }

        public static bool InsertEvent(PartyEvent partyEvent, List<Participant> guests)
        {
            bool added = false;

            OleDbConnection db = Database.Connect();

            DateTime beginDateTime = partyEvent.BeginDate;
            DateTime endDateTime = partyEvent.EndDate;
            string beginDate = "#" + beginDateTime.Month + "/" + beginDateTime.Day + "/" + beginDateTime.Year + "#";
            string endDate = "#" + endDateTime.Month + "/" + endDateTime.Day + "/" + endDateTime.Year + "#";

            // FIXME: no comment
            string sqlInsert = String.Format("INSERT INTO Evenements " +
                "VALUES ({0},'{1}',{2},{3},'{4}',{5},{6})", partyEvent.Code, partyEvent.Title, beginDate, endDate, partyEvent.Description, partyEvent.BalanceYN, partyEvent.CodeCreator);

            OleDbCommand command = new OleDbCommand(sqlInsert, db);
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                added = true;
            for (int i = 0; i < guests.Count; i++)
            {
                string login = guests[i].FirstName[0].ToString();
                string mdp = "*" + guests[i].FirstName[0];
                if(guests[i].LastName.Length < 5)
                {
                    login += guests[i].LastName.Substring(0, guests[i].LastName.Length);
                    mdp += guests[i].LastName.Substring(0, guests[i].LastName.Length) + "!";
                }
                else
                {
                    login += guests[i].LastName.Substring(0, 5);
                    mdp += guests[i].LastName.Substring(0,5) + "!";
                }

                string sqlGuest = String.Format("INSERT INTO Invites VALUES ({0},{1},'{2}','{3}')",partyEvent.Code,guests[i].CodeParticipant, login,mdp );
                command.CommandText = sqlGuest;

                nb = command.ExecuteNonQuery();
                    
                if (nb == 0)
                {
                    added = false;
                    //throw new OleDbException("Erreur dans l'insert");
                }
            }

            return added;
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
