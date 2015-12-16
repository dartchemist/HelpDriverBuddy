using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class VehicleProblem : ChangeNotificationBase
    {
        public VehicleOwner Owner { get; set; }
        public Vehicle Vehicle { get; set; }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetField(ref _description, value, nameof(Description)); }
        }

        private bool _isResolved;
        public bool IsResolved
        {
            get { return _isResolved; }
            set { SetField(ref _isResolved, value, nameof(IsResolved)); }
        }
    }
}
