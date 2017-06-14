using System.Collections.Generic;
using System.Linq;

namespace EMS.Framework.Core.Common.Validation
{
    public class ValidationResult
    {
        private readonly List<string> _erros;
        public bool IsValid { get { return !_erros.Any(); } }
        public IEnumerable<string> Errors { get { return _erros; } }

        public ValidationResult()
        {
            _erros = new List<string>();
        }

        public ValidationResult Add(string errorMessage)
        {
            _erros.Add(errorMessage);
            return this;
        }

        public ValidationResult Add(params ValidationResult[] validationResults)
        {
            if (validationResults == null)
                return this;

            foreach (var result in validationResults.Where(validationResult => validationResult != null))
                _erros.AddRange(result.Errors);

            return this;
        }

        public ValidationResult Remove(string error)
        {
            if (_erros.Contains(error))
                _erros.Remove(error);
            return this;
        }
    }
}
