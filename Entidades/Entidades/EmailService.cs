using System.Net;
using System.Net.Mail;

namespace Services
{
    public class EmailService
    {
        public bool SendEmail(string recipientEmail, string subject, string body)
        {
            string senderEmail = " geraldelcraxk3@gmail.com";
            string senderPassword = " jbwidxjpnmtjiszh ";

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body);

                try
                {
                    client.Send(mailMessage);
                    return true; // El correo se envió correctamente
                }
                catch (SmtpException ex)
                {
                    // Manejar cualquier error de envío de correo
                    // Puedes imprimir o registrar el mensaje de error para su posterior análisis
                    Console.WriteLine($"Error al enviar el correo electrónico: {ex.Message}");
                    return false; // El correo no se pudo enviar
                }
            }
        }
    }
}