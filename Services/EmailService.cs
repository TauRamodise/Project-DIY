using MailKit.Net.Smtp;
using MimeKit;

namespace Diy_Project.Services
{
    public class EmailService
    {
        public bool SendEmail(MimeMessage message)
        {
			bool messageSent = false;

			string emailAddress = "diyprojectcsharp@gmail.com";
			string password = "diyprojectc#1";

			SmtpClient smtpClient = new SmtpClient();

			try
			{
				smtpClient.Connect("smtp.gmail.com", 465, true);
				smtpClient.Authenticate(emailAddress, password);
				smtpClient.Send(message);

				Console.WriteLine("Email sent");
				messageSent = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				messageSent = false;
			}
			finally
			{
				smtpClient.Disconnect(true);
				smtpClient.Dispose();
			}

			return messageSent;
		}
    }
}
