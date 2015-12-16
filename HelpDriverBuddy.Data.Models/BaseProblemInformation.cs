using System.Runtime.Serialization;

namespace HelpDriverBuddy.Data.Models
{
    [DataContract]
    public class BaseProblemInformation
    {
        /// <summary>
        /// Image represent with byte array
        /// </summary>
        [DataMember]
        public byte[] Image { get; set; }

        [DataMember]
        public string CarBrand { get; set; }
        [DataMember]
        public string CarModel { get; set; }
        [DataMember]
        public string RegisrationNumber { get; set; }
    }
}
