namespace HelpDriverBuddy.Data.Models
{
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;

    [DataContract]
    public class VehicleOwner : IVehicleOwner
    {
        public Location location;

        [DataMember]
        public ILocation Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value as Location;
            }
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
