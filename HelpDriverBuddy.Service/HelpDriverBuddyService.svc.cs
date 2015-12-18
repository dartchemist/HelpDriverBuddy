namespace HelpDriverBuddy.Service
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Threading.Tasks;
    using System.IO;
    using AutoMapper;
    using Data;
    using Data.Repositories;
    using Interfaces.Models;
    using Models;
    using Config;

    using DatabaseVehicleProblem = HelpDriverBuddy.Data.Models.VehicleProblem;
  
    public class HelpDriverBuddyService : IHelpDriverBuddyService
    {
        private IRepository<long, DatabaseVehicleProblem> repository;

        public HelpDriverBuddyService()
        {
            var fileName = ConfigurationManager.AppSettings["STSdbFile"];
            var dataDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var stsdbContext = new STSdbContext(Path.Combine(dataDir, fileName));
            this.repository = new STSdbRepository<long, DatabaseVehicleProblem>(stsdbContext);

            AutoMapperConfig.RegisterMappings(new KeyValuePair<Type, Type>(typeof(DatabaseVehicleProblem), typeof(VehicleProblem)));
            AutoMapperConfig.RegisterMappings(new KeyValuePair<Type, Type>(typeof(IVehicleProblem), typeof(DatabaseVehicleProblem)));
        }

        public Task AddProblem(IVehicleProblem problem)
        {
            return Task.Run(() =>
             {
                 var last = repository.All().Last();
                 this.repository.Replace(last.Key + 1, Mapper.Map<DatabaseVehicleProblem>(problem));
             }
             );
        }

        public Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            return Task<IEnumerable<IVehicleProblem>>.Run(() => 
                this.repository
                .All()
                .Select(x=> 
                    (IVehicleProblem)Mapper.Map<VehicleProblem>(x.Value)));
        }
    }
}
