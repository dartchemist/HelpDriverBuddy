using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class Location : ModelWrapper<ILocation>
    {
        public Location(ILocation businessModel) : base(businessModel)
        {

        }

        public double Longitude
        {
            get { return GetPropertyValue<double>(nameof(Longitude)); }
            set { SetPropertyValue(value, nameof(Longitude)); }
        }

        public double Latitude
        {
            get { return GetPropertyValue<double>(nameof(Latitude)); }
            set { SetPropertyValue(value, nameof(Latitude)); }
        }
    }
}
