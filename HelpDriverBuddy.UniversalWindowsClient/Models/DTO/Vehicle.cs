namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    using System;
    using Interfaces.Models;

    public class Vehicle : IVehicle
    {
        public string Brand { get; set; }

        public byte[] Image { get; set; }

        public string ImageExt { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }
    }
}
