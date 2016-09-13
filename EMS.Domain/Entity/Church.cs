using EMS.Domain.Validation.Registration;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;

namespace EMS.Domain.Entity
{
    public class Church : BaseEntity, ISelfValidation
    {
        public override long Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstPhoneNumber { get; set; }
        public string SecondPhoneNumber { get; set; }
        public string CNPJ { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Branch> Branches { get; set; }
        public virtual IEnumerable<Representative> Representatives { get; set; }


        public ValidationResult ValidationResult
        {
            get; private set;
        }

        public bool IsValid()
        {
            var result = new ChurchValidation();
            ValidationResult = result.Valid(this);

            return ValidationResult.IsValid;
        }
    }
}
