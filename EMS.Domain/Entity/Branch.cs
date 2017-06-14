using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Validation;
using System;

namespace EMS.Domain.Entity
{
    public class Branch : BaseEntity, ISelfValidation
    {
        public override long Id { get; set; }
        public Church Church { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstPhoneNumber { get; set; }
        public string SecondPhoneNumber { get; set; }
        public string CNPJ { get; set; }

        public ValidationResult ValidationResult
        {
            get; private set;
        }

        public bool IsValid()
        {
            //var result = new ();
            //ValidationResult = result.Valid(this);

            return ValidationResult.IsValid;
        }
    }
}
