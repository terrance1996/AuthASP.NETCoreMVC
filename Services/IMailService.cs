using AuthTest.Models;

namespace AuthTest.Services
{
    public interface IMailService
    {
        Task SendMail(MailContent mailContent);
    }
}
