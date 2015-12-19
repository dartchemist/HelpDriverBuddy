namespace HelpDriverBuddy.Data.Models
{
    using System;

    public class VehicleProblem
    {
        public string Description { get; set; }

        public Vehicle Vehicle { get; set; }

        public VehicleOwner VehicleOwner { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
