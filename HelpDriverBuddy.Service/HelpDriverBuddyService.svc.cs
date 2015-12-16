namespace HelpDriverBuddy.Service
{
    using System;
    using System.Collections.Generic;
    using Data.Models;
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HelpDriverBuddyService : IHelpDriverBuddyService
    {
        public void AddProblem(FullProblemInformation infomation)
        {
            throw new NotImplementedException();
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
