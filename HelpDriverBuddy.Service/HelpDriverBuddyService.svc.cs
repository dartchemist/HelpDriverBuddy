namespace HelpDriverBuddy.Service
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Threading.Tasks;
    using System.IO;
    using System.ServiceModel;
    using AutoMapper;
    using Data;
    using Data.Repositories;
    using Models;
    using Config;

    using DatabaseVehicleProblem = HelpDriverBuddy.Data.Models.VehicleProblem;
    using Data.Models;

    public class HelpDriverBuddyService : IHelpDriverBuddyService
    {
        private IRepository<long, DatabaseVehicleProblem> repository;

        public HelpDriverBuddyService()
        {
            var fileName = ConfigurationManager.AppSettings["STSdbFile"];
            var dataDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var stsdbContext = new STSdbContext(Path.Combine(dataDir, fileName));
            this.repository = new STSdbRepository<long, DatabaseVehicleProblem>(stsdbContext);

            AutoMapperConfig.RegisterMappings(new KeyValuePair<Type, Type>(typeof(DatabaseVehicleProblem), typeof(Models.VehicleProblem)));
        }

        public void AddVecleProblem(Models.VehicleProblem problem)
        {
            try
            {

                var last = repository.All().Last();
                this.repository.Replace(last.Key + 1, Mapper.Map<DatabaseVehicleProblem>(problem));
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }

        public IEnumerable<Models.VehicleProblem> GetVehicleProblems()
        {
            try
            {
                return this.repository
                    .All()
                    .Select(x =>
                        Mapper.Map<Models.VehicleProblem>(x.Value));
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }
    }
}
