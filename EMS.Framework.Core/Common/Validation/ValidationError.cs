namespace EMS.Framework.Core.Common.Validation
{
    public class ValidationError
    { 
        public string Message { get; set; }
        public ValidationError(string message)
        {
            Message = message;
        }
    }
}
