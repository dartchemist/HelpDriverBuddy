using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.Interfaces.Services;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs;
using HelpDriverBuddy.UniversalWindowsClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelpDriverBuddy.UniversalWindowsClient.ViewModels
{
    public class RegisteredVehicleProblemsViewModel : ChangeNotificationBase
    {
        private readonly IVehicleProblemService _vehicleProblemService;
        private readonly IDialogService _dialogService;

        private ObservableCollection<VehicleProblem> _vehicleProblems;
        public ObservableCollection<VehicleProblem> VehicleProblems
        {
            get
            {
                if (_vehicleProblems == null)
                {
                    _vehicleProblems = new ObservableCollection<VehicleProblem>();
                }

                return _vehicleProblems;
            }
        }

        private bool _isDataLoading;
        public bool IsDataLoading
        {
            get { return _isDataLoading; }
            set
            {
                if (value == _isDataLoading)
                    return;
                OnPropertyChanged(nameof(IsDataLoading));
            }
        }


        #region Commands

        private ICommand _loadVehicleProblemsCommand;
        public ICommand LoadVehicleProblemsCommand
        {
            get
            {
                if (_loadVehicleProblemsCommand == null)
                {
                    _loadVehicleProblemsCommand = new DelegateCommand(LoadVehicleData);
                }
                return _loadVehicleProblemsCommand;
            }
        }

        private async void LoadVehicleData(object parameter)
        {
            IsDataLoading = true;
            try
            {
                var vehicleProblems = ToObservableCollection(
                   await _vehicleProblemService.GetVehicleProblems());

                foreach (var vehicleProblem in vehicleProblems)
                {
                    if (_vehicleProblems.Contains(vehicleProblem))
                        continue;
                    _vehicleProblems.Add(vehicleProblem);
                }
            }
            catch (Exception)
            {
                await _dialogService.ShowMessage("Could not load current vehicle problems");
            }
            finally
            {
                IsDataLoading = false;
            }
           
        }

        #endregion Commands

        public RegisteredVehicleProblemsViewModel(IVehicleProblemService vehicleProblemService, IDialogService dialogService)
        {
            _vehicleProblemService = vehicleProblemService;
            _dialogService = dialogService;
        }

        private ObservableCollection<VehicleProblem> ToObservableCollection(IEnumerable<IVehicleProblem> vehicleProblems)
        {
            return new ObservableCollection<VehicleProblem>(
                vehicleProblems.Select(vp =>
                {
                    return new VehicleProblem(vp);
                }));
        } 
    }
}
