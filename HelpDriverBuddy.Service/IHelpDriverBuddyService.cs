namespace HelpDriverBuddy.Service
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using Service.Models;

    [ServiceContract]
    public interface IHelpDriverBuddyService
    {
        [OperationContract]
        IEnumerable<VehicleProblem> GetVehicleProblems();
        [OperationContract]
        void AddVecleProblem(VehicleProblem infomation);
    }
}
