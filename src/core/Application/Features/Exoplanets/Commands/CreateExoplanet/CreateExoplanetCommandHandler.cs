using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet
{
    public class CreateExoplanetCommandHandler : ApplicationRequestHandler<CreateExoplanetCommand, CreateExoplanetCommandResponse>
    {
        private readonly IExoplanetRepository exoplanetRepository;

        public CreateExoplanetCommandHandler(
                IMapper mapper,
                IExoplanetRepository exoplanetRepository) : base(mapper)
        {
            this.exoplanetRepository = exoplanetRepository;
        }

        public override async Task<CreateExoplanetCommandResponse> Handle(
                CreateExoplanetCommand request,
                CancellationToken cancellationToken)
        {
            var result = new CreateExoplanetCommandValidator().Validate(request);
            var response = new CreateExoplanetCommandResponse(result);

            if (response.Success)
            {
                var newExoplanet = await exoplanetRepository.AddAsync(_mapper.Map<Exoplanet>(request));
                response.Id = newExoplanet.Id;
            }

            return response;
        }
    }
}
