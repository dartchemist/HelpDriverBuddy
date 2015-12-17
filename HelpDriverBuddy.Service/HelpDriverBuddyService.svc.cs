namespace HelpDriverBuddy.Service
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    
    using Data;
    using Data.Models;
    using Data.Repositories;    
    public class HelpDriverBuddyService : IHelpDriverBuddyService
    {
        private IRepository<Guid, FullProblemInformation> repository;

        public HelpDriverBuddyService()
        {
            var filePath = ConfigurationManager.AppSettings["STSdbFile"];
            var stsdbContext = new STSdbContext(filePath);
            this.repository = new STSdbRepository<Guid, FullProblemInformation>(stsdbContext);
        }

        public void AddProblem(FullProblemInformation infomation)
        {
            try
            { 
            this.repository.Replace(Guid.NewGuid(), infomation);
            }
            catch
            {
                AddProblem(infomation);
            }
        }

        public IEnumerable<KeyValuePair<Guid, BaseProblemInformation>> GetAllProblems()
        {
            throw new NotImplementedException();
        }

        public FullProblemInformation GetProblem(Guid idOfProblem)
        {
            throw new NotImplementedException();
        }
    }
}
