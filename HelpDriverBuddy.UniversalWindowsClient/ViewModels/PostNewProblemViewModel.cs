using HelpDriverBuddy.Interfaces.Services;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs;
using HelpDriverBuddy.UniversalWindowsClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Geolocation;

namespace HelpDriverBuddy.UniversalWindowsClient.ViewModels
{
    public class PostNewProblemViewModel : ChangeNotificationBase
    {
        private readonly IVehicleProblemService vehicleProblemService;
        private readonly IDialogService dialogService;
        private readonly ILocationService locationService;

        public VehicleProblem VehicleProblem { get; private set; }

        private ICommand postVehicleProblemCommand;
        public ICommand PostVehicleProblemCommand
        {
            get
            {
                if (postVehicleProblemCommand == null)
                {
                    postVehicleProblemCommand = new DelegateCommand(PostVehicleProblem);
                }

                return postVehicleProblemCommand;
            }
        }


        private async void PostVehicleProblem(object parameter)
        {
            try
            {
                var location = await locationService.GetLocation();
                this.VehicleProblem.BusinessModel.VehicleOwner.Location = location;
                await vehicleProblemService.AddVecleProblem(this.VehicleProblem.BusinessModel);
            }
            catch (Exception)
            {
                await dialogService.ShowMessage("Could not upload problem information");
            }
        }

        

        public PostNewProblemViewModel(IVehicleProblemService vehicleProblemService, IDialogService dialogService, ILocationService locationService)
        {
            this.vehicleProblemService = vehicleProblemService;
            this.dialogService = dialogService;
            this.locationService = locationService;
        }
    }
}
