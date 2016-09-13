using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(Makes.BMW, "X1 SUV", 2014, NumberOfDoors: 4, NumberOfGears: 8);
            Console.WriteLine(bmw.GetDisplayName());

            Car datsun = new Car(Makes.Other, "240Z Coupe", 1970, NumberOfDoors: 2, NumberOfGears: 5);
            Console.WriteLine(datsun.GetDisplayName());

            Motorcycle yamaha = new Motorcycle(Makes.Yamaha, "FZ6", 2009, TypeOfDrive: DriveTypes.Chain);
            Console.WriteLine(yamaha.GetDisplayName());
        }
    }
}
