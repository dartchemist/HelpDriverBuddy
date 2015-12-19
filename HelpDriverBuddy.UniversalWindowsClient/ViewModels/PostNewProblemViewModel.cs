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

namespace HelpDriverBuddy.UniversalWindowsClient.ViewModels
{
    public class PostNewProblemViewModel : ChangeNotificationBase
    {
        private readonly IVehicleProblemService _vehicleProblemService;
        private readonly IDialogService _dialogService;

        public VehicleProblem VehicleProblem { get; private set; }

        private ICommand _postVehicleProblemCommand;
        public ICommand PostVehicleProblemCommand
        {
            get
            {
                if (_postVehicleProblemCommand == null)
                {
                    _postVehicleProblemCommand = new DelegateCommand(PostVehicleProblem);
                }

                return _postVehicleProblemCommand;
            }
        }


        private async void PostVehicleProblem(object parameter)
        {
            try
            {
                await _vehicleProblemService.AddVecleProblem(VehicleProblem.BusinessModel);
            }
            catch (Exception)
            {
                await _dialogService.ShowMessage("Could not upload problem information");
            }
        }

        

        public PostNewProblemViewModel(IVehicleProblemService vehicleProblemService, IDialogService dialogService)
        {
            _vehicleProblemService = vehicleProblemService;
            _dialogService = dialogService;
        }
    }
}
