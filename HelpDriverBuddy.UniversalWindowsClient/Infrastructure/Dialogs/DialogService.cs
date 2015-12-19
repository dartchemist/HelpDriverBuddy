using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs
{
    public class DialogService : IDialogService
    {
        public async Task ShowMessage(string message)
        {
            var messageBox = new MessageDialog(message);
            messageBox.Commands.Add(new UICommand
            {
                Id = 0,
                Label = "Ok"
            });

            await messageBox.ShowAsync();
        }
    }
}
