using Diy_Project.Services;
using MimeKit;

namespace Diy_Project.Services
{

    public class EmailMessages
    {
        public static string EmailSubject(EmailType emailType) 
        {
            switch (emailType) 
            {
                case EmailType.ProfileUpdated:
                    return "Your profile has been updated";
                case EmailType.ContractAccepted:
                    return "Contract Accepted";
                case EmailType.NewUser:
                    return "Welcome to DIY Project";
                default:
                    return "DIY Project";

            }
        }

        public static TextPart EmailBody(EmailType emailType) 
        {
            switch (emailType)
            {
                case EmailType.ProfileUpdated:
                    return new TextPart("plain") 
                    {
                        Text = @"Good day

Please note that your profile has been updated.

Regards
DIY_Project"
                    };
                case EmailType.ContractAccepted:
                    return new TextPart("plain")
                    {
                        Text = @"Good day

Please note that your contract has been accepted.

Regards
DIY_Project"
                    };
                case EmailType.NewUser:
                    return new TextPart("plain")
                    {
                        Text = @"Good day

Welcome to DIY project, go ahead and browse on our portal.

Regards
DIY_Project"
                    };
                default:
                    return new TextPart("plain")
                    {
                        Text = @"Good day

This is the DIY project.

Regards
DIY_Project"
                    };
            }
        }
    }
}
