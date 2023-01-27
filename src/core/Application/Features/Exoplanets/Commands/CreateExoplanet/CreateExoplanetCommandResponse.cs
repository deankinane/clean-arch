using CleanArch.Application.Responses;
using FluentValidation.Results;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet
{
    public class CreateExoplanetCommandResponse : BaseResponse
    {
        public CreateExoplanetCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }
        
        public Guid Id { get; set; } = default!;
    }
}
