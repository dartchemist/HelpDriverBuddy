using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure
{
    public abstract class NotifyDataErrorInfoBase : ChangeNotificationBase, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errors;
        protected Dictionary<string, List<string>> Errors
        {
            get { return _errors; }
        }

        protected NotifyDataErrorInfoBase()
        {
            _errors = new Dictionary<string, List<string>>();
        }

        public bool HasErrors => _errors.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return propertyName != null && _errors.ContainsKey(propertyName)
                ? _errors[propertyName]
                : Enumerable.Empty<string>();
        }

        protected virtual void OnErrorsChanged(string propertyName)
        {
            var handler = ErrorsChanged;
            handler?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected void ClearErrors()
        {
            foreach (var propertyName in Errors.Keys.ToList())
            {
                Errors.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }
    }
}
