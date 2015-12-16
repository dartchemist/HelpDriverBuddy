using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using HelpDriverBuddy.UniversalWindowsClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.ViewModels
{
    public class RegisteredVehicleProblemsViewModel : ChangeNotificationBase
    {
        private readonly ObservableCollection<VehicleProblem> _vehicleProblems = new ObservableCollection<VehicleProblem>
        {
            new VehicleProblem
            {
                Vehicle = new Vehicle
                {
                    Make = "Ford",
                    Model = "Fusion",
                    RegisrationNumber = "CB 0000 CD"
                },
                Owner = new VehicleOwner
                {
                    Name = "Slav Petkov",
                    PhoneNumber = "0800000000"
                },
                Description = "Flat tire",
                IsResolved = false
            }
        };

        public ObservableCollection<VehicleProblem> VehicleProblems
        {
            get { return _vehicleProblems; }
        }
    }
}
