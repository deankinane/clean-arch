using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Application.Exceptions;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet
{
    public class CreateExoplanetCommandHandler : ApplicationRequestHandler<CreateExoplanetCommand, Guid>
    {
        private readonly IExoplanetRepository exoplanetRepository;

        public CreateExoplanetCommandHandler(
                IMapper mapper,
                IExoplanetRepository exoplanetRepository) : base(mapper)
        {
            this.exoplanetRepository = exoplanetRepository;
        }

        public override async Task<Guid> Handle(
                CreateExoplanetCommand request,
                CancellationToken cancellationToken)
        {
            var result = new CreateExoplanetCommandValidator().Validate(request);
            if(!result.IsValid)
            {
                throw new ValidationException(result);
            }
            var newExoplanet = await exoplanetRepository.AddAsync(_mapper.Map<Exoplanet>(request));
            return newExoplanet.Id;
        }
    }
}
