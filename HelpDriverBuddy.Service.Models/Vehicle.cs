namespace HelpDriverBuddy.Service.Models
{
    using System;
    using System.Runtime.Serialization;
    using HelpDriverBuddy.Interfaces.Models;


    [DataContract]
    public class Vehicle : IVehicle
    {
        private Image image;

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public IImage Image
        {
            get
            {
                return image;
            }

            set
            {
                if(value == null)
                {
                    image = null;

                    return;
                }

                var castImage = value as Image;

                if(castImage == null)
                {
                    castImage = new Image()
                    {
                        ImageBytes = value.ImageBytes,
                        ImageExt = value.ImageExt
                    };
                }

                image = castImage;
            }
        }
    }
}
