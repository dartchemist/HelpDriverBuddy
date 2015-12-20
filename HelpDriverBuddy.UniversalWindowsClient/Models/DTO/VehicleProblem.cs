namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    using System;
    using Interfaces.Models;

    public class VehicleProblem : IVehicleProblem
    {
        public DateTime CreateOn { get; set; }

        public string Description { get; set; }

        public IVehicle Vehicle { get; set; }

        public IVehicleOwner VehicleOwner { get; set; }

        public VehicleProblem()
        {
            Vehicle = new Vehicle();
            VehicleOwner = new VehicleOwner();
        }
    }
}
