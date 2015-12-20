namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    using Interfaces.Models;

    public class Location : ILocation
    {
        public Location()
        {
        }

        public Location(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
      }
}
