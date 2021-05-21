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
    public class Participant
    {
        static string chcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../../bdEvents.mdb'";
        OleDbConnection connection = new OleDbConnection();

        public int CodeParticipant;
        public string LastName;
        public string FirstName;
        public string PhoneNumber;
        public int NbParts;
        public Double Balance;
        public string Mail;

        


        public static Participant GetParticipant(int codeParticipant)
        {
            Participant theParticipant = new Participant();
            OleDbConnection connection = new OleDbConnection();

            try
            {
                connection.ConnectionString = chcon;
                connection.Open();
                string sql = "select * from Participants where codeParticipant = " + codeParticipant;
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

        public static DataTable toDataTable(List<Participant> participants)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeParticipant", typeof(int));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("NbParts", typeof(int));
            table.Columns.Add("Balance", typeof(Double));
            table.Columns.Add("Mail", typeof(string));

            for (int i = 0; i < participants.Count; i++)
            {
                int codeParticipant = participants[i].CodeParticipant;
                string lastName = participants[i].LastName;
                string firstName = participants[i].FirstName;
                string phoneNumber = participants[i].PhoneNumber;
                int nbParts = participants[i].NbParts;
                Double balance = participants[i].Balance;
                string mail = participants[i].Mail;
                table.Rows.Add(codeParticipant, lastName, firstName, phoneNumber, nbParts, balance, mail);
            }
            return table;
        }

        public static DataTable toConcatenateDataTable(List<Participant> participants)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeParticipant", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("NbParts", typeof(int));
            table.Columns.Add("Balance", typeof(Double));
            table.Columns.Add("Mail", typeof(string));

            for (int i = 0; i < participants.Count; i++)
            {
                int codeParticipant = participants[i].CodeParticipant;
                string name = participants[i].LastName + " " + participants[i].FirstName;
                string phoneNumber = participants[i].PhoneNumber;
                int nbParts = participants[i].NbParts;
                Double balance = participants[i].Balance;
                string mail = participants[i].Mail;
                table.Rows.Add(codeParticipant, name, phoneNumber, nbParts, balance, mail);
            }
            return table;
        }

        public List<Expenditure> GetAllExpenditure()
        {
            List<Expenditure> allExpenditure = new List<Expenditure>();
            try
            {
                connection.ConnectionString = chcon;
                string sql1 = "select numDepense from Beneficiaires where codePart = '" + this.CodeParticipant + "'";
                OleDbCommand command = new OleDbCommand(sql1, connection);

                //Contient toutes les numDepense de notre Participant
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //Ajoute à notre liste : Les dépenses(Expenditure) de notre Participant
                    allExpenditure.Add(Expenditure.GetExpenditure(dataReader.GetInt32(0)));
                }
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.ToString());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            return allExpenditure;
        }


    }
}
