using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5.Transport
{
    internal interface IProperties
    {
        public string Model { get; set; }
        public double Speed { get; set; }
    }
}
