namespace HelpDriverBuddy.Service.Models
{
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;


    [DataContract]
    public class VehicleProblem : IVehicleProblem
    {
        public Vehicle vehicle;
        public VehicleOwner vehicleOwner;

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public IVehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
            set
            {
                this.vehicle = value as Vehicle;
            }
        }

        [DataMember]
        public IVehicleOwner VehicleOwner
        {
            get
            {
                return this.vehicleOwner;
            }
            set
            {
                this.vehicleOwner = value as VehicleOwner;
            }
        }

        public static VehicleProblem From(IVehicleProblem problem)
        {
            var description = problem.Description;
            var vehicle = problem.Vehicle;

            var newVehicle = new Vehicle()
            {
                Brand = vehicle.Brand,
                Image = vehicle.Image,
                Model = vehicle.Model,
                RegistrationNumber = vehicle.RegistrationNumber
            };

            var vehicleOwner = problem.VehicleOwner;
            var location = vehicleOwner.Location;

            var newLocation = new Location()
            {
                Longitude = location.Longitude,
                Latitude = location.Latitude
            };

            var newVehicleOwner = new VehicleOwner()
            {
                Location = newLocation,
                Name = vehicleOwner.Name,
                PhoneNumber = vehicleOwner.PhoneNumber
            };

            return new VehicleProblem()
            {
                Description = description,
                VehicleOwner = newVehicleOwner,
                Vehicle = newVehicle
            };
        }
    }
}
