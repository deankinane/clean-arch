using AutoMapper;
using CleanArch.Application.Contracts.Infrastructure;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Application.Models.Email;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet;

public class CreateExoplanetCommandHandler : ApplicationRequestHandler<CreateExoplanetCommand, CreateExoplanetCommandResponse>
{
    private readonly IExoplanetRepository exoplanetRepository;
    private readonly IEmailService emailService;

    public CreateExoplanetCommandHandler(
            IMapper mapper,
            IExoplanetRepository exoplanetRepository,
            IEmailService emailService) : base(mapper)
    {
        this.exoplanetRepository = exoplanetRepository;
        this.emailService = emailService;
    }

    public override async Task<CreateExoplanetCommandResponse> Handle(
            CreateExoplanetCommand request,
            CancellationToken cancellationToken)
    {
        var result = new CreateExoplanetCommandValidator().Validate(request);
        var response = new CreateExoplanetCommandResponse(result);

        if (!response.Success) return response;

        var newExoplanet = await exoplanetRepository.AddAsync(_mapper.Map<Exoplanet>(request));
        response.Id = newExoplanet.Id;

        if (newExoplanet.Discovered.Date == DateTime.Today)
        {
            try
            {
                var email = new Email()
                {
                    Subject = "New Exoplanet Discovery!!!",
                    To = "professor@uni.com",
                    Body = $"A new exoplanet called {newExoplanet.Name} has been discovered today!"
                };

                await emailService.SendEmail(email);
            }
            catch (System.Exception)
            {
                // Failure to send the email should not prevent the application from returning a valid result
                // We will add some logging here later
            }
        }
        
        return response;
    }
}
