using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Displays
{
    internal class IPS_LCD : Display
    {
        public override void Info()
        {
            Console.WriteLine("IPS-LCD - In-Plane Switching Liquid Crystal Display");
        }
    }
}
