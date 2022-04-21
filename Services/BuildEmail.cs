using MimeKit;

namespace Diy_Project.Services
{
    public class BuildEmail
    {
        private MimeMessage _message;

        public BuildEmail()
        {
            _message = new MimeMessage();
        }

        public BuildEmail From(string name = "DIY Project", string mailbox = "diyprojectcsharp@gmail.com")
        {
            _message.From.Add(new MailboxAddress(name, mailbox));
            return this;
        }

        public BuildEmail To(string address)
        {
            _message.To.Add(MailboxAddress.Parse(address));
            return this;
        }

        public BuildEmail MailContents(EmailType emailType)
        {
            _message.Subject = EmailMessages.EmailSubject(emailType);
            _message.Body = EmailMessages.EmailBody(emailType);
            return this;
        }

        public MimeMessage Build()
        {
            return _message;
        }
    }
}
