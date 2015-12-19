namespace HelpDriverBuddy.Service.Models
{
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;


    [DataContract]
    public class Vehicle : IVehicle
    {
        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public string ImageExt { get; set; }
    }
}
