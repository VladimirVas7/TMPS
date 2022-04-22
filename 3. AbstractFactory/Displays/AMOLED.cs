using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Displays
{
    internal class AMOLED : Display
    {
        public override void Info()
        {
            Console.WriteLine("AMOLED - Active-Matrix Organic Light-Emitting Diode");
        }
    }
}
