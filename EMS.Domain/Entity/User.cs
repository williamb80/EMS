using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Enum;
using EMS.Framework.Core.Common.Validation;

namespace EMS.Domain.Entity
{
    public class User : IEntity, ISelfValidation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ValidationResult ValidationResult
        {
            get; private set;
        }

        public bool IsValid(OperationMode operation)
        {
            //if (operation == OperationMode.Save)
            //{
            //    var result = new ChurchSaveValidationService();
            //    ValidationResult = result.Valid(this);
            //}
            //else
            //{
            //    var result = new ChurchDeleteValidationService();
            //    ValidationResult = result.Valid(this);
            //}

            return ValidationResult.IsValid;
        }
    }
}
