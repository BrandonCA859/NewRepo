using System.Net;
using System.Net.Mail;

namespace Services
{
    public class EmailService
    {
        public void SendEmail(string toAddress, string subject, string body)
        {
            string fromAddress = "tu_correo@ejemplo.com";
            string password = "tu_contraseña";

            SmtpClient smtpClient = new SmtpClient("smtp.servidorcorreo.com", 587);
            smtpClient.Credentials = new NetworkCredential(fromAddress, password);
            smtpClient.EnableSsl = true;

            MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);
        }
    }
}
