using HelpDriverBuddy.Interfaces.Services;
using System;
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
        public async Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            await Task.Delay(1 * 1000);
            var result = new List<VehicleProblemModel>
            {
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

            return result;
        }
    }
}
