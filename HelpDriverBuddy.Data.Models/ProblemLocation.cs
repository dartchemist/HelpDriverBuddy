using System.Runtime.Serialization;

namespace HelpDriverBuddy.Data.Models
{
    [DataContract]
    public class ProblemLocation
    {
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public double Latitude { get; set; }
    }
}
