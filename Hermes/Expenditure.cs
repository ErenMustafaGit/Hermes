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
        string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='X:\\a21 sterne pie\\Base de données\\bdEvents.mdb'";
        OleDbConnection connection = new OleDbConnection();

        public int NumExpenditure;
        public string Description;
        public int Amount;
        public DateTime DateExpenditure;
        public string Comment;
        public int CodeEvent;
        public int CodeParticipant;


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
                theParticipant.PhoneNumber = dataReader.GetInt32(3);
                theParticipant.NbParts = dataReader.GetInt32(4);
                theParticipant.Balance = dataReader.GetInt32(5);
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
    }

}
