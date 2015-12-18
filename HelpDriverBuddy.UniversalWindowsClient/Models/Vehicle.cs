using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class Vehicle : ModelWrapper<IVehicle>
    {
        public Vehicle(IVehicle businessModel) : base(businessModel)
        {

        }

        public string Brand
        {
            get { return GetPropertyValue<string>(nameof(Brand)); }
            set { SetPropertyValue(value, nameof(Brand)); }
        }

        public string Model
        {
            get { return GetPropertyValue<string>(nameof(Model)); }
            set { SetPropertyValue(value, nameof(Model)); }
        }

        public string RegistrationNumber
        {
            get { return GetPropertyValue<string>(nameof(RegistrationNumber)); }
            set { SetPropertyValue(value, nameof(RegistrationNumber)); }
        }

        public byte[] Image
        {
            get { return GetPropertyValue<byte[]>(nameof(Image)); }
            set { SetPropertyValue(value, nameof(Image)); }
        }

        public string BrandAndModel
        {
            get { return $"{Brand} {Model}"; }
        }

    }
}
