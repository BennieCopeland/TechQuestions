using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface ICar : IVehicle
    {
        int NumberOfDoors { get; }
        int NumberOfGears { get; }
    }
}
