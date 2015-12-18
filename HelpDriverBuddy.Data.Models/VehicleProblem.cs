namespace HelpDriverBuddy.Data.Models
{
    public class VehicleProblem
    {
        public string Description { get; set; }

        public Vehicle Vehicle { get; set; }

        public VehicleOwner VehicleOwner { get; set; }
    }
}
