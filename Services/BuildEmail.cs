using MimeKit;

namespace Diy_Project.Services
{
    public class EmailMessageFluentApi
    {
        private MimeMessage _message;

        public EmailMessageFluentApi()
        {
            _message = new MimeMessage();
        }

        public EmailMessageFluentApi From(string name, string mailbox)
        {
            _message.From.Add(new MailboxAddress(name, mailbox));
            return this;
        }

        public EmailMessageFluentApi To(string address)
        {
            _message.To.Add(MailboxAddress.Parse(address));
            return this;
        }

        public EmailMessageFluentApi MailContents(EmailType emailType)
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
