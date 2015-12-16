using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.Interfaces.Services
{
    public interface IVehicleProblemService
    {
        Task<IEnumerable<IVehicleProblem>> GetVehicleProblems();
    }
}
