using FluentValidation;

namespace CleanArch.Application.Features.Stars.Commands.CreateStar
{
    public class CreateStarCommandValidator : AbstractValidator<CreateStarCommand>
    {
        public CreateStarCommandValidator()
        {
           RuleFor(x => x.Name)
              .NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull()
              .MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters.");
         
           RuleFor(x => x.Class)
              .NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull()
              .MaximumLength(2).WithMessage("{PropertyName} must not exceed 2 characters.");
              
        }
    }
}
