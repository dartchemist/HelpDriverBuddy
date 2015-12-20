using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public abstract class ModelWrapper<TModel> : NotifyDataErrorInfoBase
    {
        protected ModelWrapper(TModel businessModel)
        {
            if (businessModel == null)
            {
                throw new ArgumentNullException("BusinessModel");
            }

            BusinessModel = businessModel;
        }

        public bool IsValid { get { return !HasErrors; } }

        public TModel BusinessModel { get; private set; }

        protected TValue GetPropertyValue<TValue>(string propertyName)
        {
            var propertyInfo = BusinessModel.GetType().GetProperty(propertyName);
            return (TValue)propertyInfo.GetValue(BusinessModel);
        }

        protected void SetPropertyValue<TValue>(TValue value, string propertyName)
        {
            var propertyInfo = BusinessModel.GetType().GetProperty(propertyName);
            var currentValue = propertyInfo.GetValue(BusinessModel);

            if (Equals(currentValue, value))
                return;

            propertyInfo.SetValue(BusinessModel, value);
            Validate();
            OnPropertyChanged(propertyName);
        }

        private void Validate()
        {
            ClearErrors();

            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(this);
            Validator.TryValidateObject(this, validationContext, results, true);
            if (results.Any())
            {
                var propertyNames = results.SelectMany(r => r.MemberNames).Distinct().ToList();
                foreach (var propertyName in propertyNames)
                {
                    Errors[propertyName] = results
                        .Where(r => r.MemberNames.Contains(propertyName))
                        .Select(r => r.ErrorMessage)
                        .Distinct()
                        .ToList();
                    OnErrorsChanged(propertyName);
                }
            }
            OnPropertyChanged(nameof(IsValid));
        }
    }
}
