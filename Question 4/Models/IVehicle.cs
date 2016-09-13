using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IVehicle
    {
        int Year { get; }
        Makes Make { get; }
        string Model { get; }
        int NumberOfWheels { get; }
        string GetDisplayName();
    }
}
