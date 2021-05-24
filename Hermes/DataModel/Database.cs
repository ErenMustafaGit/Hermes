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

        public static void InsertExpenditure(Expenditure expenditure, List<Participant> beneficiaire)
        {
            bool added = false;

            OleDbConnection db = Database.Connect();

            string sqlInsert = String.Format("INSERT INTO Depenses VALUES ({0},{1},{2},{3},{4},{5})", expenditure.NumExpenditure, expenditure.Description, expenditure.DateExpenditure, expenditure.Comment, expenditure.CodeEvent, expenditure.CodeParticipant);
            OleDbCommand command = new OleDbCommand(sqlInsert, connection );
            int nb = command.ExecuteNonQuery();
            if (nb > 0)
                added = true;

            for(int i = 0; i<beneficiaire.Count; i++)
            {
                string sqlBeneficiaire = String.Format("INSERT INTO Depenses Beneficiaires ({0},{1})", expenditure.NumExpenditure, beneficiaire[i].CodeParticipant);
                command.CommandText = sqlBeneficiaire;
                nb = command.ExecuteNonQuery();
                if (nb == 0)
                {
                    added = false;
                    //throw new OleDbException("Erreur dans l'insert");
                }
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

        public static List<Expenditure> FetchExpenditure()
        {
            List<Expenditure> expenditures = new List<Expenditure>();

            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Depenses", db);
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Expenditure expenditure = new Expenditure();
                expenditure.NumExpenditure = dataReader.GetInt32(0);
                expenditure.Description = dataReader.GetString(1);
                expenditure.Amount = dataReader.GetDecimal(2);
                expenditure.DateExpenditure = dataReader.GetDateTime(3);
                if (!dataReader.IsDBNull(4))
                {
                    expenditure.Comment = dataReader.GetString(4);
                }
                expenditure.CodeEvent = dataReader.GetInt32(5);
                expenditure.CodeParticipant = dataReader.GetInt32(6);

                expenditures.Add(expenditure);
            }
            
            return expenditures;
        }
    }
}
