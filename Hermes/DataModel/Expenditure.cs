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
    public class Expenditure
    {
        public int NumExpenditure;
        public string Description;
        public decimal Amount;
        public DateTime DateExpenditure;
        public string Comment;
        public int CodeEvent;
        public int CodeParticipant;

        public static DataTable toDataTable(List<Expenditure> expenditures)
        {
            DataTable table = new DataTable();
            table.Columns.Add("NumExpenditure", typeof(int));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("DateExpenditure", typeof(DateTime));
            table.Columns.Add("Comment", typeof(string));
            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("CodeParticipant", typeof(int));

            for (int i = 0; i < expenditures.Count; i++)
            {
                int numExpenditure = expenditures[i].NumExpenditure;
                string description = expenditures[i].Description;
                decimal amount = expenditures[i].Amount;
                DateTime dateExpenditure = expenditures[i].DateExpenditure;
                string comment = expenditures[i].Comment;
                int codeEvent = expenditures[i].CodeEvent;
                int codeParticipant = expenditures[i].CodeParticipant;

                table.Rows.Add(numExpenditure, description, amount, dateExpenditure, comment, codeEvent, codeParticipant);
            }
            return table;
        }

        public PartyEvent GetEvent()
        {
            PartyEvent ev = new PartyEvent();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql = "select * from Evenements where codeEvent = '" + this.CodeEvent.ToString() + "'";
            OleDbCommand command = new OleDbCommand(sql, db);
            OleDbDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            ev.Code = dataReader.GetInt32(0);
            ev.Title = dataReader.GetString(1);
            ev.BeginDate = dataReader.GetDateTime(2);
            ev.EndDate = dataReader.GetDateTime(3);
            ev.Description = dataReader.GetString(4);
            ev.BalanceYN = dataReader.GetBoolean(5);
            ev.CodeCreator = dataReader.GetInt32(6);

            return ev;
        }

        public Participant GetParticipant()
        {
            Participant participant = new Participant();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql = "select * from Evenements where codeParticipant = '" + this.CodeParticipant.ToString() + "'";
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

        public static Expenditure GetExpenditure(int numExpenditure)
        {
            Expenditure expenditure = new Expenditure();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            OleDbCommand command = new OleDbCommand("select * from Expenditure where numDepense='" + numExpenditure + "'", db);
            OleDbDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            expenditure.NumExpenditure = dataReader.GetInt32(0);
            expenditure.Description = dataReader.GetString(1);
            expenditure.Amount = dataReader.GetInt32(2);
            expenditure.DateExpenditure = dataReader.GetDateTime(3);
            expenditure.Comment = dataReader.GetString(4);
            expenditure.CodeEvent = dataReader.GetInt32(5);
            expenditure.CodeParticipant = dataReader.GetInt32(6);

            return expenditure;
        }
    }

}
