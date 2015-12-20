using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    public class VehicleOwner : IVehicleOwner
    {
        public ILocation Location { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
    }
}
