using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class VehicleOwner : ModelWrapper<IVehicleOwner>
    {
        public VehicleOwner(IVehicleOwner businessModel) : base(businessModel)
        { 

        }

        public Location Location { get; private set; }

        public string Name
        {
            get { return GetPropertyValue<string>(nameof(Name)); }
            set { SetPropertyValue(value, nameof(Name)); }
        }

        public string PhoneNumber
        {
            get { return GetPropertyValue<string>(nameof(PhoneNumber)); }
            set { SetPropertyValue(value, nameof(PhoneNumber)); }
        }
    }
}
