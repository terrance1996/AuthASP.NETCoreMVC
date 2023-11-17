namespace AuthTest.Models
{
    public class MailContent
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public MailContent(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }
    }
}
