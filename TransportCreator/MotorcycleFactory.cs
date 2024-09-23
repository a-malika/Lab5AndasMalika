using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5
{
    internal class MotorcycleFactory : ITransportFactory
    {
        public IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
