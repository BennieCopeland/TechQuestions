using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motorcycle : VehicleBase, IMotorcycle
    {
        public DriveTypes TypeOfDrive { get; private set; }

        public Motorcycle(Makes Make, string Model, int Year, DriveTypes TypeOfDrive, int NumberOfWheels = 2)
            : base(Make, Model, Year, NumberOfWheels)
        {
            this.TypeOfDrive = TypeOfDrive;
        }

        public override string GetDisplayName()
        {
            return string.Format("{0} ({1}-driven)", base.GetDisplayName(), TypeOfDrive.ToString());
        }
    }
}
