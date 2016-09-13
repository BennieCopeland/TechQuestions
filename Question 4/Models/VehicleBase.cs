using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class VehicleBase : IVehicle
    {
        public int Year { get; private set; }

        public Makes Make { get; private set; }

        public string Model { get; private set; }

        public int NumberOfWheels { get; private set; }

        public virtual string GetDisplayName()
        {
            return string.Format("{0} {1} {2}", Year, Make.ToString(), Model);
        }

        public VehicleBase(Makes Make, string Model, int Year, int NumberOfWheels)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.NumberOfWheels = NumberOfWheels;
        }
    }
}
