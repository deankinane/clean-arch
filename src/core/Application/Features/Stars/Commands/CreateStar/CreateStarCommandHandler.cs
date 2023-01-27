using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Stars.Commands.CreateStar
{
    public class CreateStarCommandHandler : ApplicationRequestHandler<CreateStarCommand, CreateStarCommandResponse>
    {
        private readonly IAsyncRepository<Star> starRepository;

        public CreateStarCommandHandler(
                IMapper mapper,
                IAsyncRepository<Star> starRepository) : base(mapper)
        {
            this.starRepository = starRepository;
        }

        public override async Task<CreateStarCommandResponse> Handle(CreateStarCommand request, CancellationToken cancellationToken)
        {
            var result = new CreateStarCommandValidator().Validate(request);
            var response = new CreateStarCommandResponse(result);

            if (response.Success)
            {
                var newStar = await starRepository.AddAsync(_mapper.Map<Star>(request));
                response.StarId = newStar.Id;

            }

            return response; 
        }
    }
}
