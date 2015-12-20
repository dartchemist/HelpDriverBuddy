namespace HelpDriverBuddy.Service.Models
{
    using Interfaces.Models;
    using System.Runtime.Serialization;


    public class Image : IImage
    {
        [DataMember]
        public byte[] ImageBytes { get; set; }

        [DataMember]
        public string ImageExt { get; set; }
    }
}
