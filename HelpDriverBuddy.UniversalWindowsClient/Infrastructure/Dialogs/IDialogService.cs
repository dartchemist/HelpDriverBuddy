using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs
{
    public interface IDialogService
    {
        Task ShowMessage(string message);
    }
}
