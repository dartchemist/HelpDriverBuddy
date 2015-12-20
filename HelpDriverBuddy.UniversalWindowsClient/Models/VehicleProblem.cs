using HelpDriverBuddy.Interfaces.Models;
using HelpDriverBuddy.UniversalWindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models
{
    public class VehicleProblem : ModelWrapper<IVehicleProblem>, IEquatable<VehicleProblem>
    {
        public VehicleProblem(IVehicleProblem businessModel) : base(businessModel)
        {
            InitializeComplexProperties(businessModel);
        }

        public Vehicle Vehicle { get; private set; }
        public VehicleOwner VehicleOwner { get; private set; }

        public string Description
        {
            get { return GetPropertyValue<string>(nameof(Description)); }
            set { SetPropertyValue(value, nameof(Description)); }
        }

        public DateTime CreateOn
        {
            get { return GetPropertyValue<DateTime>(nameof(CreateOn)); }
            set { SetPropertyValue(value, nameof(CreateOn)); }
        }

        private void InitializeComplexProperties(IVehicleProblem model)
        {
            if (model.Vehicle == null)
            {
                throw new ArgumentException("Vehicle cannot be null");
            }

            if (model.VehicleOwner == null)
            {
                throw new ArgumentException("Owner cannot be null");
            }

            Vehicle = new Vehicle(model.Vehicle);
            VehicleOwner = new VehicleOwner(model.VehicleOwner);
        }

        public bool Equals(VehicleProblem other)
        {
            return Vehicle.Equals(other.Vehicle) && VehicleOwner.Equals(other.VehicleOwner) &&
                Description == other.Description;
        }
    }
}
