﻿using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.DummyServiceClient.ModelsImplementation
{
    public class VehicleProblemModel : IVehicleProblem
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public IVehicle Vehicle { get; set; }

        public IVehicleOwner VehicleOwner { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
