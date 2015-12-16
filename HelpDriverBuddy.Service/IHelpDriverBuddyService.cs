namespace HelpDriverBuddy.Service
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Data.Models;
   
    [ServiceContract]
    public interface IHelpDriverBuddyService
    {
        IEnumerable<KeyValuePair<Guid, BaseProblemInformation>> GetAllProblems();
        FullProblemInformation GetProblem(Guid idOfProblem);
        void AddProblem(FullProblemInformation infomation);
    }
}
