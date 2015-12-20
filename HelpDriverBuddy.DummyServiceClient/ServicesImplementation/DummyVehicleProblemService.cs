using HelpDriverBuddy.Interfaces.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.DummyServiceClient.ModelsImplementation;
using SQLite.Net.Async;
using Windows.Storage;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System.Threading;

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
                        Model = "Fusion0",
                        RegistrationNumber = "CB 0000 CD",
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
                        RegistrationNumber = "CB 0000 CC"
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
                        Model = "Fusion1",
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
                        Model = "Fusion2",
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
                        Model = "Fusion3",
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
                        Model = "Fusion4",
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
                        Model = "Fusion5",
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
                        Model = "Fusion7",
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
                        Model = "Fusion6",
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
                        Model = "Fusion12",
                        RegistrationNumber = "CB 0000 CE"
                    },
                    VehicleOwner = new VehicleOwnerModel
                    {
                        Name = "Slav Petkov",
                        PhoneNumber = "0800123456"
                    }
                }
        };

        private SQLiteAsyncConnection GetDBConnectionAsync()
        {
            var dbFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "VehicleProblems.sqlite");
            var connectionFactory = new Func<SQLiteConnectionWithLock>(
                () =>
                new SQLiteConnectionWithLock(
                        new SQLitePlatformWinRT(),
                        new SQLiteConnectionString(dbFilePath, storeDateTimeAsTicks: false)));

            var asyncConnection = new SQLiteAsyncConnection(connectionFactory);
            return asyncConnection;
        }

        private async void InitAsync()
        {
            var connection = GetDBConnectionAsync();
            await connection.CreateTablesAsync<VehicleModel, VehicleOwnerModel, VehicleProblemModel, LocationModel>();
        }

        private async Task<int> InsertVehicleProblemAsync(VehicleProblemModel vehicleProblem)
        {
            var connection = GetDBConnectionAsync();
            return await connection.InsertAsync(vehicleProblem);
        }

        private async Task<IEnumerable<IVehicleProblem>> GetVehicleProblemsInternal()
        {
            var connection = GetDBConnectionAsync();
            return await connection.Table<VehicleProblemModel>().ToListAsync();
        }


        public async Task AddVecleProblem(IVehicleProblem problem)
        {
            var connection = GetDBConnectionAsync();
            await connection.InsertAsync(problem);
        }

        public async Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            return await GetVehicleProblemsInternal();
        }
    }
}
