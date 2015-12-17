namespace HelpDriverBuddy.Service
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using Interfaces.Services;
    using Interfaces.Models;

    [ServiceContract]
    public interface IHelpDriverBuddyService : IVehicleProblemService
    {
        [OperationContract]
        Task<IEnumerable<IVehicleProblem>> GetVehicleProblems();
        [OperationContract]
        void AddProblem(IVehicleProblem infomation);
    }
}
