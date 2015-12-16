using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class Vehicle : ChangeNotificationBase
    {
        private string _make;
        public string Make
        {
            get { return _make; }
            set { SetField(ref _make, value, nameof(Make)); }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set { SetField(ref _model, value, nameof(Model)); }
        }

        public string MakeAndModel
        {
            get { return _make + " " + _model; }
        }

        private string _registrationNumber;
        public string RegisrationNumber
        {
            get { return _registrationNumber; }
            set { SetField(ref _registrationNumber, value, nameof(RegisrationNumber)); }
        }

    }
}
