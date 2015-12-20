namespace HelpDriverBuddy.UniversalWindowsClient.Infrastructure.Dialogs
{
    using System.Threading.Tasks;
    using Interfaces.Models;

    public interface ILocationService
    {
        Task<ILocation> GetLocation();
    }
}
