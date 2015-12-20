using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IVehicleProblem
    {
        int Id { get; set; }
        IVehicle Vehicle { get; set; }
        IVehicleOwner VehicleOwner { get; set; }
        string Description { get; set; }
        DateTime CreateOn { get; set; }
    }
}
