using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : VehicleBase, ICar
    {
        public int NumberOfDoors { get; private set; }

        public int NumberOfGears { get; private set; }

        public Car(Makes Make, string Model, int Year, int NumberOfWheels = 4, int NumberOfDoors = 4, int NumberOfGears = 4) : base(Make, Model, Year, NumberOfWheels)
        {
            this.NumberOfDoors = NumberOfDoors;
            this.NumberOfGears = NumberOfGears;
        }
    }
}
