using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.DummyServiceClient.ModelsImplementation
{
    public class LocationModel : ILocation
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
