using System.Runtime.Serialization;

namespace HelpDriverBuddy.Data.Models
{
    [DataContract]
    public class FullProblemInformation : BaseProblemInformation
    {
        [DataMember]
        public string Problem { get; set; }
        [DataMember]
        public string OwnerName { get; set; }
        [DataMember]
        public string OwnerPhone { get; set; }

        [DataMember]
        public ProblemLocation Location { get; set; }
    }
}
