using CleanArch.Application.Contracts.Infrastructure;
using CleanArch.Application.Models.Email;
using CleanArch.Infrastructure.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        
        services.AddTransient<IEmailService, EmailService>();

        return services;
    } 
}
