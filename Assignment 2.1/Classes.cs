using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1_Part_2
{
    class Vehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Passengers { get; set; }
        public string PowerWindows { get; set; }
        public int Color { get; set; }
        public virtual void Accelerate()
        {
            Console.WriteLine("Press the gas pedal to accelerate.");
            Console.ReadLine();
        }
        public virtual void Brake()
        {
            Console.WriteLine("Press the brake pedal to stop.");
            Console.ReadLine();
        }        
    }

    class Car : Vehicle
    {
        public string TrunkStyle { get; set; }
    }

    class Truck : Vehicle
    {
        public int BedSize { get; set; }
        public string CabStyle { get; set; }
    }

    class Van : Vehicle
    {
        public string PowerDoors { get; set; }
        public string SeatStyle { get; set; }
    }

    class PoliceCar : Car
    {
        public string LightColor { get; set; }
        public string Decals { get; set; }
    }

    class RaceCar : Car
    {
        public string HarnessStyle { get; set; }
    }

    class Semi : Truck
    {
        public bool Cabin { get; set; }
        public bool FifthWheel { get; set; }
    }

    class MailTruck : Van
    {
        public int Shelves { get; set; }
    }
}
