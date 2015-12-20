using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.DummyServiceClient.ModelsImplementation
{
    public class VehicleModel : IVehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public IImage Image { get; set; }
    }
}
