using CleanArch.Application.Responses;
using FluentValidation.Results;

namespace CleanArch.Application.Features.Stars.Commands.CreateStar
{
   public class CreateStarCommandResponse : BaseResponse
   {
      public CreateStarCommandResponse(ValidationResult validationResult) : base(validationResult)
      {
      }
      public Guid StarId { get; set; }
   }
}
