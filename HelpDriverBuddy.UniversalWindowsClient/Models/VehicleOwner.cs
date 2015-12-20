using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class VehicleOwner : ModelWrapper<IVehicleOwner>, IEquatable<VehicleOwner>
    {
        public VehicleOwner(IVehicleOwner businessModel) : base(businessModel)
        { 

        }

        public Location Location { get; private set; }

        [Required(ErrorMessage = "Owner Name is required")]
        public string Name
        {
            get { return GetPropertyValue<string>(nameof(Name)); }
            set { SetPropertyValue(value, nameof(Name)); }
        }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Value must be a phone number")]
        public string PhoneNumber
        {
            get { return GetPropertyValue<string>(nameof(PhoneNumber)); }
            set { SetPropertyValue(value, nameof(PhoneNumber)); }
        }

        public bool Equals(VehicleOwner other)
        {
            return Name == other.Name &&
                PhoneNumber == other.PhoneNumber;
        }
    }
}
