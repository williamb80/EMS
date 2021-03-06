﻿using EMS.Domain.ValidationService.Registration;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Validation;

namespace EMS.Domain.Entity
{
    public class User : BaseEntity, ISelfValidation
    {
        public override long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ValidationResult ValidationResult
        {
            get; private set;
        }

        public bool IsValid()
        {
            var result = new UserValidationService();
            ValidationResult = result.Valid(this);

            return ValidationResult.IsValid;
        }
    }
}
