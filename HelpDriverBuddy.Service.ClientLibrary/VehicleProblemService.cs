namespace HelpDriverBuddy.Service.ClientLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using AutoMapper;
    using Config;
    using HelpDriverBuddy.Interfaces.Services;
    using HelpDriverBuddy.Interfaces.Models;
    using HelpDriverBuddyService;

    public class VehicleProblemService : IVehicleProblemService
    {
        HelpDriverBuddyServiceClient client;

        public VehicleProblemService()
        {
            this.client = new HelpDriverBuddyServiceClient();
            AutoMapperConfig.RegisterOneWayMappings(new KeyValuePair<Type, Type>(typeof(IVehicleProblem), typeof(VehicleProblem)));
        }

        public Task AddVecleProblem(IVehicleProblem problem)
        {
            return this.client.AddVecleProblemAsync(Mapper.Map<VehicleProblem>(problem));
        }

        public Task<IEnumerable<IVehicleProblem>> GetVehicleProblems()
        {
            return Task<IEnumerable<IVehicleProblem>>.Run(
                () =>
                {
                    return this.client.GetVehicleProblems().Cast<IVehicleProblem>();
                });
        }
    }
}
