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
    public class Database
    {
        static string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../../bdEvents.mdb'";
        static OleDbConnection connection = new OleDbConnection();
        DataSet dataset = new DataSet();

        public static List<PartyEvent> FetchEvents()
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
                        Code = dataReader.GetInt32(0),
                        Title = dataReader.GetString(1),
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

        public static List<Participant> FetchParticipant()
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

        public void FillDataSet()
        {
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
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
        }

        public BindingSource GetBindingSource(string tableName)
        {
            BindingSource bindingSource = new BindingSource();
            try
            {
                this.FillDataSet();
                DataTable table = dataset.Tables[tableName];
                bindingSource.DataSource = table;

            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }
            finally
            {
                connection.Close();
            }
            return bindingSource;
        }

        public static void InsertExpenditure(Expenditure expenditure, List<Participant> beneficiaire)
        {
            bool added = false;
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sqlInsert = String.Format("INSERT INTO Depenses VALUES ({0},{1},{2},{3},{4},{5})", expenditure.NumExpenditure, expenditure.Description, expenditure.DateExpenditure, expenditure.Comment, expenditure.CodeEvent, expenditure.CodeParticipant);
                OleDbCommand command = new OleDbCommand(sqlInsert, connection );
                int nb = command.ExecuteNonQuery();
                MessageBox.Show(nb.ToString());
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
        }

        public static bool InsertEvent(PartyEvent partyEvent, List<Participant> guests)
        {
            bool added = false;
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();


                DateTime beginDateTime = partyEvent.BeginDate;
                DateTime endDateTime = partyEvent.EndDate;
                string beginDate = "#" + beginDateTime.Month + "/" + beginDateTime.Day + "/" + beginDateTime.Year + "#";
                string endDate = "#" + endDateTime.Month + "/" + endDateTime.Day + "/" + endDateTime.Year + "#";

                string sqlInsert = String.Format("INSERT INTO Evenements " +
                    "VALUES ({0},'{1}',{2},{3},'{4}',{5},{6})", partyEvent.Code, partyEvent.Title, beginDate, endDate, partyEvent.Description, partyEvent.BalanceYN, partyEvent.CodeCreator);

                OleDbCommand command = new OleDbCommand(sqlInsert, connection);
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

                    MessageBox.Show(guests[i].FirstName + "  " + guests[i].LastName + "  " + login + "  " + mdp);

                    string sqlGuest = String.Format("INSERT INTO Invites VALUES ({0},{1},'{2}','{3}')",partyEvent.Code,guests[i].CodeParticipant, login,mdp );
                    command.CommandText = sqlGuest;
                    MessageBox.Show(sqlGuest);

                    nb = command.ExecuteNonQuery();
                    
                    if (nb == 0)
                    {
                        added = false;
                        //throw new OleDbException("Erreur dans l'insert");
                    }
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
            return added;
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
