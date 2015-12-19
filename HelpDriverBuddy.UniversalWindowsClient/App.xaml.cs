using HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Unity;
using HelpDriverBuddy.UniversalWindowsClient.ViewModels;
using HelpDriverBuddy.UniversalWindowsClient.Views;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HelpDriverBuddy.UniversalWindowsClient
{
    sealed partial class App : Application
    {
        public App()
        {
            Microsoft.ApplicationInsights.WindowsAppInitializer.InitializeAsync(
                Microsoft.ApplicationInsights.WindowsCollectors.Metadata |
                Microsoft.ApplicationInsights.WindowsCollectors.Session);
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var unityContainer = new UnityContainer();
            ContainerBootstrapper.RegisterTypes(unityContainer);

            var registeredVehicleProblemsViewModel = unityContainer.Resolve<RegisteredVehicleProblemsViewModel>();
            var problemInfoViewModel = unityContainer.Resolve<ProblemInfoViewModel>();
            var postNewProblemViewModel = unityContainer.Resolve<PostNewProblemViewModel>();

            Resources["RegisteredVehicleProblemsViewModel"] = registeredVehicleProblemsViewModel;
            Resources["ProblemInfoViewModel"] = problemInfoViewModel;
            Resources["PostNewProblemViewModel"] = postNewProblemViewModel;

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    
                }

                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                rootFrame.Navigate(typeof(RegisteredVehicleProblems), e.Arguments);
            }
            Window.Current.Activate();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
