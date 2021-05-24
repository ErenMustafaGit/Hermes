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
        public static PartyEvent GetFromId(int codeEvent)
        {
            PartyEvent e = new PartyEvent();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql = "select * from Evenements where codeEvent = " + codeEvent;
            OleDbCommand command = new OleDbCommand(sql, db);
            OleDbDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            e.Code = dataReader.GetInt32(0);
            e.Title = dataReader.GetString(1);
            e.BeginDate = dataReader.GetDateTime(2);
            e.EndDate = dataReader.GetDateTime(3);
            e.Description = dataReader.GetString(4);
            e.BalanceYN = dataReader.GetBoolean(5);
            e.CodeCreator = dataReader.GetInt32(6);

            return e;
        }

        public List<Participant> GetGuests()
        {
            List<Participant> guests = new List<Participant>();

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sqlCodePart = "select codePart from Invites where codeEvent = " + this.Code;
            OleDbCommand command = new OleDbCommand(sqlCodePart, db);
            OleDbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string sqlGuest = "select * from Participants where codeParticipant = " + dataReader.GetInt32(0);
                OleDbCommand commandGuest = new OleDbCommand(sqlGuest, db);
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

            return guests;
        }
        public int GetNbPart()
        {
            int nbPart = -1;

            OleDbConnection db = Database.Connect();
            // FIXME: use command parameters
            string sql = "SELECT count(*) FROM Invites WHERE codeEvent = " + this.Code;
            OleDbCommand command = new OleDbCommand(sql, db);

            nbPart = (int)command.ExecuteScalar();

            return nbPart;
        }

        public static int GetMaxCode()
        {
            int codeMax = -1;

            OleDbConnection db = Database.Connect();

            string sql = "SELECT MAX(codeEvent) FROM Evenements";
            OleDbCommand command = new OleDbCommand(sql, db);

            codeMax = (int)command.ExecuteScalar();

            return codeMax;
        }

    }
}
