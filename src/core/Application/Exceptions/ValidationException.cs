using FluentValidation.Results;

namespace CleanArch.Application.Exceptions
{
    public class ValidationException : Exception
    {      
        public List<string> ValidationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
           ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
        }
        
    }
}
