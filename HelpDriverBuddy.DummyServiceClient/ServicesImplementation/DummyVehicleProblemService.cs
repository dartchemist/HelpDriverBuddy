using HelpDriverBuddy.Interfaces.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.DummyServiceClient.ModelsImplementation;

namespace HelpDriverBuddy.DummyServiceClient.ServicesImplementation
{
    public class DummyVehicleProblemService : IVehicleProblemService
    {
        private static readonly Random _getRandom = new Random();
        private static readonly object _syncLock = new object();

        public static int GetRandomNumber()
        {
            lock(_syncLock)
            {
                return _getRandom.Next(1, 10);
            }
        }

        private static readonly List<IVehicleProblem> _vehicleProblems = new List<IVehicleProblem>()
        {
            new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE",
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Mustang",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "MondeoX3456",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "BMW",
                        Model = "X3",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                },
                new VehicleProblemModel
                {
                    Description = "Dummy Description",
                    Vehicle = new VehicleModel
                    {
                        Brand = "Ford",
                        Model = "Fusion",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                }
        };

        public async Task AddVecleProblem(IVehicleProblem problem)
        {
            await Task.Run(() =>
            {
                _vehicleProblems.Add(problem);
            });
            
        }

        public async Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            var random = GetRandomNumber();
            if (random == 5)
            {
                throw new Exception();
            }

            await Task.Delay(random * 1000);
            return _vehicleProblems;
        }
    }
}
