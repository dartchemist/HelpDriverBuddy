namespace HelpDriverBuddy.Service.Models
{
    using Interfaces.Models;
    using System.Runtime.Serialization;


    public class Image : IImage
    {
        [DataMember]

        public int Id { get; set; }

        [DataMember]
        public byte[] ImageBytes { get; set; }

        [DataMember]
        public string ImageExt { get; set; }
    }
}
