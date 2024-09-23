using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5
{
    internal class Motorcycle : IVehicle
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public void Move()
        {
            Console.WriteLine("The motorcycle is moving.");
        }
        public void FuelUp()
        {
            Console.WriteLine("The motorcycle is fueling up.");
        }
    }
}
