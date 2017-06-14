using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;

namespace EMS.Framework.Core.Common.Validation
{
    public class BaseValidationService<TEntity> : IBaseValidation<TEntity>
        where TEntity : class
    {
        private readonly Dictionary<string, IValidationRule<TEntity>> _validationsRules;

        public BaseValidationService()
        {
            _validationsRules = new Dictionary<string, IValidationRule<TEntity>>();
        }

        protected virtual void AddRule(IValidationRule<TEntity> validationRule)
        {
            var ruleName = validationRule.GetType() + Guid.NewGuid().ToString("D");
            _validationsRules.Add(ruleName, validationRule);
        }

        //protected virtual void RemoveRule(string ruleName)
        //{
        //    _validationsRules.Remove(ruleName);
        //}

        /// <summary>
        /// This method verify the dictionary initialized in base constructor 
        /// this dictionary contains the rules in child constructor that call the method 'AddRule'
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual ValidationResult Valid(TEntity entity)
        {
            var result = new ValidationResult();
            foreach (var key in _validationsRules.Keys)
            {
                var rule = _validationsRules[key];
                if (!rule.Valid(entity))
                    result.Add(rule.ErrorMessage);
            }
            return result;
        }
    }
}
