namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        string RegistrationNumber { get; set; }
        byte[] Image { get; set; }
        string ImageExt { get; set; }
    }
}