using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;




namespace Products.Web_App.Senders
{
    public class SendEmail
    {
        public static void Send(string to, string subject, string body)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("khabardarshowfast3@gmail.com");          
            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = body;
            msg.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            var nc = new NetworkCredential("khabardarshowfast3@gmail.com", "12300101010");
            client.Credentials = nc;     
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            client.UseDefaultCredentials = true;
            client.Send(msg);
            client.Send("khabardarshowfast3@gmail.com", "naderi.ms@gmail.com","test","this is a test email.");

        }
    }
}