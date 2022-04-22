using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Displays
{
    internal class OLED : Display
    {
        public override void Info()
        {
            Console.WriteLine("OLED - Organic Light-Emitting Diode");
        }
    }
}
