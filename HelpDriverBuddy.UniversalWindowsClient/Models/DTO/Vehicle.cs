namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    using System;
    using Interfaces.Models;

    public class Vehicle : IVehicle
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public IImage Image { get; set; }
    }
}
