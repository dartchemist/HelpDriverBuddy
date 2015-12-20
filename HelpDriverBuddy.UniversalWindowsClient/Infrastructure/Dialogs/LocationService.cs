namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs
{
    using System;
    using System.Threading.Tasks;
    using Windows.Devices.Geolocation;
    using HelpDriverBuddy.UniversalWindowsClient.Models.DTO;
    using Interfaces.Models;

    public class LocationService : ILocationService
    {
        private Geolocator locator;

        public LocationService()
        {
            Init();
        }

        public Task<ILocation> GetLocation()
        {
            return this.locator.GetGeopositionAsync().AsTask().ContinueWith<ILocation>(x =>
                new Location(x.Result.Coordinate.Point.Position.Latitude, x.Result.Coordinate.Point.Position.Longitude));
        }

        private async void Init()
        {
            await Geolocator.RequestAccessAsync();
            this.locator = new Geolocator();
        }
    }
}
