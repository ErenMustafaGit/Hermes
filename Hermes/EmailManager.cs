using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using Hermes.DataModel;

namespace Hermes
{
    public static class EmailManager
    {
        private static SmtpClient m_Client = null;

        private static SmtpClient Client
        {
            get
            {
                if (m_Client == null)
                {
                    m_Client = new SmtpClient()
                    {
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,

                        Host = Properties.Resources.SmtpHost,
                        Port = int.Parse(Properties.Resources.SmtpPort),
                        EnableSsl = true, // force SSL
                        Credentials = new NetworkCredential()
                        {
                            UserName = Properties.Resources.SmtpUser,
                            Password = Properties.Resources.SmtpPassword
                        }
                    };
                }

                return m_Client;
            }
        }

        public static bool IsEmailValid(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        public static Task Invite(PartyEvent e, Participant p, SendCompletedEventHandler handler = null)
        {
            if (!IsEmailValid(p.Mail))
                return Task.FromException(new SmtpFailedRecipientException());

            MailAddress from = new MailAddress(Properties.Resources.Email, "Hermès");
            MailAddress to = new MailAddress(p.Mail);

            // Replace template contents by actual values.
            string body = Properties.Resources.EmailTemplate;
            body = body.Replace("%FULL_NAME%", p.FirstName + " " + p.LastName);
            body = body.Replace("%EVENT_NAME%", e.Name);

            // Prepare the message to be sent.
            MailMessage message = new MailMessage()
            {
                From = from,
                Body = body,
                Subject = "Vous avez été invité·e à un évènement !",
                IsBodyHtml = true,
            };
            message.To.Add(to);

            if (handler != null)
                Client.SendCompleted += handler;

            // Send it asynchronously. Return the created task.
            return Client.SendMailAsync(message);
        }

        public static async Task<Task> InviteList(PartyEvent e, List<Participant> participants)
        {
            foreach (Participant participant in participants)
                await EmailManager.Invite(e, participant);

            return Task.CompletedTask;
        }

    }
}
