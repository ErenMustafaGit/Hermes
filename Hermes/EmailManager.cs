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
        public static void Invite(Participant participant, PartyEvent evenement)
        {
            //Setup SMTP Client
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "HermesRobertSchuman@gmail.com",
                    Password = "dpawedelwcvbahsg",
                }
            };

            //Initialisation des address
            MailAddress from = new MailAddress("HermesRobertSchuman@gmail.com");
            //MailAddress to = new MailAddress(participant.Mail);
            MailAddress to = new MailAddress("mustafa68eren@gmail.com");


            string subject = "Tu es invité à mon évenement sur Hermès !";
            string body = " <!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<style>" +
                "span { font-weight: bold; }" +
                " h1   { color: dark; }" +
                " p    { color: blue; }" +
                "</style>" +
                //"<link rel=\"stylesheet\" href=\"../../../style.css\">" +
                "</head>" +
                "<body>" +
                "<h1>Hermès</h1>" +
                "<p>Tu es invité à un nouvelle évenement qui se nomme : <span>" + evenement.Description + "</span></p> " +
                "</body>" +
                "</html>";



            //Setup du message à envoyer 
            MailMessage Message = new MailMessage()
            {
                From = from,
                Body = body,
                Subject = subject,
                IsBodyHtml = true,
            };
            Message.To.Add(to);

            Client.SendCompleted += EmailSended;
            Client.SendMailAsync(Message);

        }

        public static void InviteList(List<Participant> participants, PartyEvent partyEvent)
        {
            foreach (Participant participant in participants)
                EmailManager.Invite(participant, partyEvent);
        }

        
        public static void EmailSended(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                Console.WriteLine("ERROR" + e.Error.ToString());
            }
        }
    }
}
