
using CleanArch.Application.Models.Email;

namespace CleanArch.Application.Contracts.Infrastructure;

public interface IEmailService
{
    Task<bool> SendEmail(Email email);
}
