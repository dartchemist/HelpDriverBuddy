namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IVehicleOwner
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }

        ILocation Location { get; set; }
    }
}