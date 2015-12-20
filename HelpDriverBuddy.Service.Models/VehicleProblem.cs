namespace HelpDriverBuddy.Service.Models
{
    using System;
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;

    [DataContract]
    public class VehicleProblem : IVehicleProblem
    {
        public Vehicle vehicle;
        public VehicleOwner vehicleOwner;

        [DataMember]
        public int Id { get; set; }

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
                if (value == null)
                {
                    this.vehicle = null;

                    return;
                }

                var castVehicle = value as Vehicle;

                if (castVehicle == null)
                {
                    castVehicle = new Vehicle()
                    {
                        Brand = value.Brand,
                        Image = value.Image,
                        Model = value.Model,
                        RegistrationNumber = value.RegistrationNumber
                    };
                }

                this.vehicle = castVehicle;
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
                if (value == null)
                {
                    this.vehicleOwner = null;

                    return;
                }

                var castOwner = value as VehicleOwner;

                if(castOwner == null)
                {
                    castOwner = new VehicleOwner()
                    {
                        Location = value.Location,
                        Name = value.Name,
                        PhoneNumber = value.PhoneNumber
                    };
                }

                this.vehicleOwner = castOwner;
            }
        }

        [DataMember]
        public DateTime CreateOn { get; set; }

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
