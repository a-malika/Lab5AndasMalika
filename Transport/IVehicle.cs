using Laboratory5.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5
{
    internal interface IVehicle : IProperties
    {
        public void Move();
        public void FuelUp();
    }
}
