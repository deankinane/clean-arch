using CleanArch.Application.Contracts.Infrastructure;
using CleanArch.Application.Models.Email;
using Microsoft.Extensions.Options;

namespace CleanArch.Infrastructure.Email;

public class EmailService : IEmailService
{
    private readonly EmailSettings emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        this.emailSettings = emailSettings.Value;
    }
    
    public async Task<bool> SendEmail(Application.Models.Email.Email email)
    {
        //TODO add actual email servie integraton using something like
        // SendGrid or Gmail APIs
        
        await Task.Run(() => {Thread.Sleep(1);});  
        return true;
    }
}
