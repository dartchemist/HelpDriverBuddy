namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IVehicleOwner
    {
        int Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }

        ILocation Location { get; set; }
    }
}