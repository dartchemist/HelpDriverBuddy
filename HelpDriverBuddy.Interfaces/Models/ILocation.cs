namespace HelpDriverBuddy.Interfaces.Models
{
    public interface ILocation
    {
        int Id { get; set; }
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
}
