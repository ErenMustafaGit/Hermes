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
    //Dépense
    class Expenditure
    {
        static string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../../bdEvents.mdb'";
        OleDbConnection connection = new OleDbConnection();

        public int NumExpenditure;
        public string Description;
        public Decimal Amount;
        public DateTime DateExpenditure;
        public string Comment;
        public int CodeEvent;
        public int CodeParticipant;

        public static DataTable toDataTable(List<Expenditure> expenditures)
        {
            DataTable table = new DataTable();
            table.Columns.Add("NumExpenditure", typeof(int));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Amount", typeof(Decimal));
            table.Columns.Add("DateExpenditure", typeof(DateTime));
            table.Columns.Add("Comment", typeof(string));
            table.Columns.Add("CodeEvent", typeof(int));
            table.Columns.Add("CodeParticipant", typeof(int));

            for (int i = 0; i < expenditures.Count; i++)
            {
                int numExpenditure = expenditures[i].NumExpenditure;
                string description = expenditures[i].Description;
                Decimal amount = expenditures[i].Amount;
                DateTime dateExpenditure = expenditures[i].DateExpenditure;
                string comment = expenditures[i].Comment;
                int codeEvent = expenditures[i].CodeEvent;
                int codeParticipant = expenditures[i].CodeParticipant;

                table.Rows.Add(numExpenditure, description, amount, dateExpenditure, comment, codeEvent, codeParticipant);
            }
            return table;
        }
        /*
        public static Decimal getAmount()
        {
            string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='X:\\a21 sterne pie\\Base de données\\bdEvents.mdb'";
            OleDbConnection connection = new OleDbConnection();
            Decimal res = 0;
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sql = "select montant from Depenses where numDepense = '1'";
                OleDbCommand command = new OleDbCommand(sql, connection);
                res = command.ExecuteScalar();
                
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
            return res;
        }*/

        public PartyEvent GetEvent()
        {
            PartyEvent theEvent = new PartyEvent();
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sql = "select * from Evenements where codeEvent = '" + this.CodeEvent.ToString() + "'";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                theEvent.CodeEvent = dataReader.GetInt32(0);
                theEvent.TitleEvent = dataReader.GetString(1);
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
        public Participant GetParticipant()
        {
            Participant theParticipant = new Participant();
            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sql = "select * from Evenements where codeParticipant = '" + this.CodeParticipant.ToString() + "'";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                theParticipant.CodeParticipant = dataReader.GetInt32(0);
                theParticipant.LastName = dataReader.GetString(1);
                theParticipant.FirstName = dataReader.GetString(2);
                theParticipant.PhoneNumber = dataReader.GetString(3);
                theParticipant.NbParts = dataReader.GetInt32(4);
                if (!dataReader.IsDBNull(5))
                {
                    theParticipant.Balance = dataReader.GetDouble(5);
                }
                theParticipant.Mail = dataReader.GetString(6);

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
            return theParticipant;
        }
        public static Expenditure GetExpenditure(int numExpenditure)
        {
            Expenditure theExpenditure = new Expenditure();
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = chcon;
                OleDbCommand command = new OleDbCommand("select * from Expenditure where numDepense='" + numExpenditure + "'");
                command.Connection = connection;
                OleDbDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                theExpenditure.NumExpenditure = dataReader.GetInt32(0);
                theExpenditure.Description = dataReader.GetString(1);
                theExpenditure.Amount = dataReader.GetInt32(2);
                theExpenditure.DateExpenditure = dataReader.GetDateTime(3);
                theExpenditure.Comment = dataReader.GetString(4);
                theExpenditure.CodeEvent = dataReader.GetInt32(5);
                theExpenditure.CodeParticipant = dataReader.GetInt32(6);

            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }
            return theExpenditure;
        }
    }

}
