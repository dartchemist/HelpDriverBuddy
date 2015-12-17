namespace HelpDriverBuddy.Service
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Data.Repositories;
    using Interfaces.Models;

    public class HelpDriverBuddyService : IHelpDriverBuddyService
    {
        private IRepository<long, VehicleProblem> repository;

        public HelpDriverBuddyService()
        {
            var filePath = ConfigurationManager.AppSettings["STSdbFile"];
            var stsdbContext = new STSdbContext(filePath);
            this.repository = new STSdbRepository<long, VehicleProblem>(stsdbContext);
        }

        public void AddProblem(IVehicleProblem problem)
        {
            var last = repository.All().Last();
            var castProblem = VehicleProblem.From(problem);

            this.repository.Replace(last.Key + 1, castProblem);
        }

        public Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            return Task<IEnumerable<IVehicleProblem>>.Run(() => this.repository.All().Select(x => x.Value).Cast<IVehicleProblem>());
        }
    }
}
