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

namespace Hermes
{
    public class PartyEvent
    {
        static string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../../bdEvents.mdb'";
        static OleDbConnection connection = new OleDbConnection();
        
        public int Code;
        public string Title;
        public DateTime BeginDate;
        public DateTime EndDate;
        public string Description;
        public bool BalanceYN;
        public int CodeCreator;

        public static DataTable toDataTable(List<PartyEvent> partyEvents)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("BeginDate", typeof(DateTime));
            table.Columns.Add("EndDate", typeof(DateTime));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("BalanceYN", typeof(bool));
            table.Columns.Add("CodeCreator", typeof(int));

            for (int i = 0; i < partyEvents.Count; i++)
            {
                int codeEvent = partyEvents[i].Code;
                string titleEvent = partyEvents[i].Title;
                DateTime beginDate = partyEvents[i].BeginDate;
                DateTime endDate = partyEvents[i].EndDate;
                string description = partyEvents[i].Description;
                bool balanceYN = partyEvents[i].BalanceYN;
                int codeCreator = partyEvents[i].CodeCreator;
                table.Rows.Add(codeEvent, titleEvent, beginDate, endDate, description, balanceYN, codeCreator);
            }
            return table;
        }
        public static PartyEvent GetPartyEvent(int codeEvent)
        {
            PartyEvent theEvent = new PartyEvent();
            OleDbConnection connection = new OleDbConnection();

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sql = "select * from Evenements where codeEvent = " + codeEvent;
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                theEvent.Code = dataReader.GetInt32(0);
                theEvent.Title = dataReader.GetString(1);
                theEvent.BeginDate = dataReader.GetDateTime(2);
                theEvent.EndDate = dataReader.GetDateTime(3);
                theEvent.Description = dataReader.GetString(4);
                theEvent.BalanceYN = dataReader.GetBoolean(5);
                theEvent.CodeCreator = dataReader.GetInt32(6);

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
            return theEvent;
        }

        public List<Participant> GetGuests()
        {
            List<Participant> guests = new List<Participant>();
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sqlCodePart = "select codePart from Invites where codeEvent = " + this.Code;
                OleDbCommand command = new OleDbCommand(sqlCodePart, connection);
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string sqlGuest = "select * from Participants where codeParticipant = " + dataReader.GetInt32(0);
                    OleDbCommand commandGuest = new OleDbCommand(sqlGuest, connection);
                    OleDbDataReader dataReaderGuest = commandGuest.ExecuteReader();

                    dataReaderGuest.Read();
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
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                connection.Close();
            }
            return guests;
        }
        public List<Expenditure> GetExpenditures()
        {
            List<Expenditure> expenditures = new List<Expenditure>();
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sqlCodePart = "select * from Depenses where codeEvent = " + this.Code;
                OleDbCommand command = new OleDbCommand(sqlCodePart, connection);
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                    Expenditure expenditure = new Expenditure();
                    expenditure.NumExpenditure = dataReader.GetInt32(0);
                    expenditure.Description = dataReader.GetString(1);
                    //Si le montant est null
                    if (!dataReader.IsDBNull(2))
                    {
                        expenditure.Amount = dataReader.GetDecimal(2);
                    }
                    expenditure.DateExpenditure = dataReader.GetDateTime(3);

                    //Si le commentaire est null
                    if (!dataReader.IsDBNull(4))
                    {
                        expenditure.Comment = dataReader.GetString(4);
                    }
                    expenditure.CodeEvent = dataReader.GetInt32(5);
                    expenditure.CodeParticipant = dataReader.GetInt32(6);

                    
                    expenditures.Add(expenditure);
                }
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                connection.Close();
            }
            return expenditures;
        }
        public int GetNbPart()
        {
            int nbPart = -1;

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();

                string sql = "SELECT count(*) FROM Invites WHERE codeEvent = " + this.Code;
                OleDbCommand command = new OleDbCommand(sql, connection);

                nbPart = (int)command.ExecuteScalar();
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                connection.Close();
            }
            return nbPart;
        }

        public static int GetMaxCode()
        {
            int codeMax = -1;

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();

                string sql = "SELECT MAX(codeEvent) FROM Evenements";
                OleDbCommand command = new OleDbCommand(sql, connection);

                codeMax = (int)command.ExecuteScalar();
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                connection.Close();
            }
            return codeMax;
        }

    }
}
