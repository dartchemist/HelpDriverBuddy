﻿namespace HelpDriverBuddy.Service.Models
{
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;

    [DataContract]
    public class Location : ILocation
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public double Latitude { get; set; }
    }
}
