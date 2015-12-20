namespace HelpDriverBuddy.Service.Models
{
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;

    [DataContract]
    public class VehicleOwner : IVehicleOwner
    {
        public Location location;

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public ILocation Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (value == null)
                {
                    this.location = null;

                    return;
                }

                var castValue = value as Location;

                if(castValue == null)
                {
                    castValue = new Location()
                    {
                        Latitude = value.Latitude,
                        Longitude = value.Longitude
                    };
                }

                this.location = castValue;
            }
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
