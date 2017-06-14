using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Enum;
using EMS.Framework.Core.Common.Validation;

namespace EMS.Domain.Entity
{
    public class Address : IEntity, ISelfValidation
    {
        public long Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public ValidationResult ValidationResult
        {
            get; private set;
        }

        public bool IsValid(OperationMode operation)
        {
            //if (operation == OperationMode.Save)
            //{
            //    var result = new ();
            //    ValidationResult = result.Valid(this);
            //}
            //else
            //{
            //    var result = new ();
            //    ValidationResult = result.Valid(this);
            //}

            return ValidationResult.IsValid;
        }
    }
}
