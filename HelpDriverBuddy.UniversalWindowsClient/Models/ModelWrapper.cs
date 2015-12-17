using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public abstract class ModelWrapper<TModel> : ChangeNotificationBase
    {
        protected ModelWrapper(TModel businessModel)
        {
            if (businessModel == null)
            {
                throw new ArgumentNullException("BusinessModel");
            }

            BusinessModel = businessModel;
        }

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
            OnPropertyChanged(propertyName);
        }
    }
}
