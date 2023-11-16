using AuthTest.Models;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace AuthTest.Services
{
    public class MailService : IMailService
    {
        const string MAIL_HOST = "smtp.gmail.com";
        const int MAIL_PORT = 587;

        public MailService() { }


        // Send mail
        public async Task SendMail(MailContent mailContent)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(config["EMAIL"]);
            email.To.Add(MailboxAddress.Parse(mailContent.To));
            email.Subject = mailContent.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = mailContent.Body;
            email.Body = builder.ToMessageBody();

            // Use SmtpClient of MailKit
            using var smtp = new MailKit.Net.Smtp.SmtpClient();

            try
            {
                smtp.Connect(MAIL_HOST, MAIL_PORT, SecureSocketOptions.StartTls);
                smtp.Authenticate(config["EMAIL"], config["EMAIL_PASSWORD"]);
                await smtp.SendAsync(email);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            smtp.Disconnect(true);
        }
    }
}
