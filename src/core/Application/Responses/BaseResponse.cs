using FluentValidation.Results;

namespace CleanArch.Application.Responses
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Success = true;
            Message = string.Empty;
            ValidationErrors = new List<string>();
        }

        public BaseResponse(string message)
        {
            Success = true;
            Message = message;
            ValidationErrors = new List<string>();
        }

        public BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
            ValidationErrors = new List<string>();
        }

        public BaseResponse(ValidationResult validationResult)
        {
            Success = validationResult.IsValid;
            Message = string.Empty;
            ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
        }

        public string Message { get; set; }
        public bool Success { get; set; }
        public List<string> ValidationErrors { get; private set; }
    } 
}
