﻿namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IVehicle
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        string RegistrationNumber { get; set; }
        IImage Image { get; set; }
    }
}