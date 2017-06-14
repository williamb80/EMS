using EMS.Framework.Core.Common.Enum;

namespace EMS.Framework.Core.Common.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid(OperationMode operation);
    }
}
