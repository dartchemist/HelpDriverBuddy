using HelpDriverBuddy.DummyServiceClient.ServicesImplementation;
using HelpDriverBuddy.Interfaces.Services;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Unity
{
    public static class ContainerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IVehicleProblemService, DummyVehicleProblemService>();
            container.RegisterType<IDialogService, DialogService>();
            container.RegisterType<ILocationService, LocationService>();
        }
    }
}
