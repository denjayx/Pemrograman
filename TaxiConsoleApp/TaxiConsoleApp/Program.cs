using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Deni";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10.ToString();

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}