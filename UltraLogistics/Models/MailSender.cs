using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace UltraLogistics.Models
{
    public class MailSender
    {
        public string email { get; set; }
        public bool Send(string email, string Subject, string message)
        {
            string sender = "akhandpratapsingh840@gmail.com";
            string pass = "zpow lbje bemu doys";
            var senderEmail = new MailAddress(sender);
            var receiverEmail = new MailAddress(email, "Receiver");
            var password = pass;
            var sub = Subject;
            var body = message;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = Subject,
                Body = body,
            })
            {
                smtp.Send(mess);
                return true;
            }
            return false;
        }

    }
}