﻿using System;
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
        public int CodeParticipant;
        public string LastName;
        public string FirstName;
        public string PhoneNumber;
        public int NbParts;
        public double Balance;
        public string Mail;

        public static Participant GetParticipant(int codeParticipant)
        {
            Participant participant = new Participant();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql = "select * from Participants where codeParticipant = " + codeParticipant;
            OleDbCommand command = new OleDbCommand(sql, db);
            OleDbDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            participant.CodeParticipant = dataReader.GetInt32(0);
            participant.LastName = dataReader.GetString(1);
            participant.FirstName = dataReader.GetString(2);
            participant.PhoneNumber = dataReader.GetString(3);
            participant.NbParts = dataReader.GetInt32(4);
            if (!dataReader.IsDBNull(5))
            {
                participant.Balance = dataReader.GetDouble(5);
            }
            participant.Mail = dataReader.GetString(6);

            return participant;
        }

        public static DataTable toDataTable(List<Participant> participants)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodeParticipant", typeof(int));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("NbParts", typeof(int));
            table.Columns.Add("Balance", typeof(double));
            table.Columns.Add("Mail", typeof(string));

            for (int i = 0; i < participants.Count; i++)
            {
                int codeParticipant = participants[i].CodeParticipant;
                string lastName = participants[i].LastName;
                string firstName = participants[i].FirstName;
                string phoneNumber = participants[i].PhoneNumber;
                int nbParts = participants[i].NbParts;
                double balance = participants[i].Balance;
                string mail = participants[i].Mail;
                table.Rows.Add(codeParticipant, lastName, firstName, phoneNumber, nbParts, balance, mail);
            }
            return table;
        }

        /*Permet d'avoir une DataTable des participants que vous donnez en paramètre
         * 
         * Cette Datatable contient une colonne avec le nom et le prénom concatener
         * Cela permet de le donner en DisplayMember
         * 
         * Nom de la colonne concatener = "Name"
         */
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

        // FIXME: cache this stuff, remove function call, only use properties
        public List<Expenditure> GetAllExpenditure()
        {
            List<Expenditure> allExpenditure = new List<Expenditure>();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql1 = "select numDepense from Beneficiaires where codePart = '" + this.CodeParticipant + "'";
            OleDbCommand command = new OleDbCommand(sql1, db);

            //Contient toutes les numDepense de notre Participant
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //Ajoute à notre liste : Les dépenses(Expenditure) de notre Participant
                allExpenditure.Add(Expenditure.GetExpenditure(dataReader.GetInt32(0)));
            }

            return allExpenditure;
        }
    }
}
