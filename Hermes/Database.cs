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
    class Database
    {
        string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../../bdEvents.mdb'";
        OleDbConnection connection = new OleDbConnection();

        public List<PartyEvent> FetchEvents()
        {
            List<PartyEvent> partyEvents = new List<PartyEvent>();

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from Evenements", connection);
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    PartyEvent oneEvent = new PartyEvent()
                    {
                        CodeEvent = dataReader.GetInt32(0),
                        TitleEvent = dataReader.GetString(1),
                        BeginDate = dataReader.GetDateTime(2),
                        EndDate = dataReader.GetDateTime(3),
                        Description = dataReader.GetString(4),
                        BalanceYN = dataReader.GetBoolean(5),
                        CodeCreator = dataReader.GetInt32(6)
                    };
                    partyEvents.Add(oneEvent);
                }
            }
            catch (OleDbException er)
            {
                MessageBox.Show("Erreur de requête SQL \n\n\n\n" + er);
            }
            catch (InvalidOperationException er)
            {
                MessageBox.Show("Problème d'accès à la base \n\n\n\n" + er);
            }

            finally
            {
                connection.Close();
            }
            return partyEvents;
        }

        public List<Participant> FetchParticipant()
        {
            List<Participant> participants = new List<Participant>();

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from Participants", connection);
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Participant theParticipant = new Participant();
                    theParticipant.CodeParticipant = dataReader.GetInt32(0);
                    theParticipant.FirstName = dataReader.GetString(1);
                    theParticipant.LastName = dataReader.GetString(2);
                    theParticipant.PhoneNumber = dataReader.GetString(3);
                    theParticipant.NbParts = dataReader.GetInt32(4);

                    //Si le solde est null
                    if (!dataReader.IsDBNull(5))
                    {
                        theParticipant.Balance = dataReader.GetDouble(5);
                    }
                    theParticipant.Mail = dataReader.GetString(6);
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
                    participants.Add(theParticipant);
                }
            }
            catch (OleDbException er)
            {
                MessageBox.Show("Erreur de requête SQL \n\n\n\n" + er);
            }
            catch (InvalidOperationException er)
            {
                MessageBox.Show("Problème d'accès à la base \n\n\n\n" + er);
            }

            finally
            {
                connection.Close();
            }
            return participants;
        }

        public List<Expenditure> FetchExpenditure()
        {
            List<Expenditure> expenditures = new List<Expenditure>();

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from Depenses", connection);
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
            }
            catch (OleDbException er)
            {
                MessageBox.Show("Erreur de requête SQL \n\n\n\n" + er);
            }
            catch (InvalidOperationException er)
            {
                MessageBox.Show("Problème d'accès à la base \n\n\n\n" + er);
            }

            finally
            {
                connection.Close();
            }
            return expenditures;
        }
    }
}
