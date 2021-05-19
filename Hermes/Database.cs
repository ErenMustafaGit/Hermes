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

namespace Hermes
{
    public static class Database
    {
        const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../bdEvents.mdb'";
        static OleDbConnection connection = null;

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
                    CodeEvent = dataReader.GetInt32(0),
                    TitleEvent = dataReader.GetString(1),
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

                //Si le solde est null
                if (!dataReader.IsDBNull(5))
                {
                    participant.Balance = dataReader.GetDouble(5);
                }
                participant.Mail = dataReader.GetString(6);
                /*
                {
                    CodeParticipant = dataReader.GetInt32(0),
                    FirstName = dataReader.GetString(1),
                    LastName = dataReader.GetString(2),
                    PhoneNumber = dataReader.GetInt32(3),
                    NbParts = dataReader.GetInt32(4),
                    Balance = dataReader.GetInt32(5),
                    Mail = dataReader.GetString(6)
                };*/
                participants.Add(participant);
            }
            
            return participants;
        }

        public static List<Expenditure> FetchExpenditure()
        {
            List<Expenditure> expenditures = new List<Expenditure>();

            OleDbConnection db = Database.Connect();
            OleDbCommand command = new OleDbCommand("select * from Depenses", db);
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Expenditure theExpenditure = new Expenditure();
                theExpenditure.NumExpenditure = dataReader.GetInt32(0);
                theExpenditure.Description = dataReader.GetString(1);

                theExpenditure.Amount = dataReader.GetDecimal(2);
                theExpenditure.DateExpenditure = dataReader.GetDateTime(3);
                if (!dataReader.IsDBNull(4))
                {
                    theExpenditure.Comment = dataReader.GetString(4);
                }
                theExpenditure.CodeEvent = dataReader.GetInt32(5);
                theExpenditure.CodeParticipant = dataReader.GetInt32(6);
                /*
                {
                    NumExpenditure = dataReader.GetInt32(0),
                    Description = dataReader.GetString(1),
                    Amount = dataReader.GetInt32(2),
                    DateExpenditure = dataReader.GetDateTime(3),
                    Comment = dataReader.GetString(4),
                    CodeEvent = dataReader.GetInt32(5),
                    CodeParticipant = dataReader.GetInt32(6)
                };*/
                expenditures.Add(theExpenditure);
            }
            
            return expenditures;
        }
    }
}
