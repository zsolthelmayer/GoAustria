using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace GoAustria.utils
{
	public class MessageHelper
	{
		public void SendMessage(String from, String to, String subject, String body) {

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = "smtp.forpsi.com";
			smtpClient.Port = 25;

			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new System.Net.NetworkCredential(from, "F83v6u7-xa");

			
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.EnableSsl = true;
			MailMessage mail = new MailMessage();

			//Setting From , To and CC
			mail.From = new MailAddress(from, "ausztriamunka.hu");
			mail.Subject = subject;
			mail.To.Add(new MailAddress(to));		
			mail.Body = body;


			smtpClient.SendMailAsync(mail);
		}
	}
}