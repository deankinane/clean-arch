using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Application.Exceptions;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Stars.Commands.CreateStar
{
    public class CreateStarCommandHandler : ApplicationRequestHandler<CreateStarCommand, Guid>
    {
        private readonly IAsyncRepository<Star> starRepository;

        public CreateStarCommandHandler(
            IMapper mapper,
            IAsyncRepository<Star> starRepository) : base(mapper)
        {
            this.starRepository = starRepository;
        }

        public override async Task<Guid> Handle(CreateStarCommand request, CancellationToken cancellationToken)
        {
            var result = new CreateStarCommandValidator().Validate(request);
            if (!result.IsValid) throw new ValidationException(result);
            
            var newStar = await starRepository.AddAsync(_mapper.Map<Star>(request));
            return newStar.Id;
        }
    }
}
