using EMS.Domain.Validation.Model;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entity
{
    public class Church : BaseEntity, ISelfValidation
    {
        public override long Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        

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
