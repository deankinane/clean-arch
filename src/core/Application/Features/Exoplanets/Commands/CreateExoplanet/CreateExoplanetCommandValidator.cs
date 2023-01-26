using FluentValidation;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet
{
    internal class CreateExoplanetCommandValidator : AbstractValidator<CreateExoplanetCommand>
    {
        public CreateExoplanetCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters.");
                
            RuleFor(x => x.Discovered)
                .NotNull().WithMessage("{PropertyName} is required.");
            
            RuleFor(x => x.StarId)
                .NotNull().WithMessage("{PropertyName} is required.");
            
            RuleFor(x => x.InHabitableZone)
                .NotNull().WithMessage("{PropertyName} is required.");
        }
    }
}
