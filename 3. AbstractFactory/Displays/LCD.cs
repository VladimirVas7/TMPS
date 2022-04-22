using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Displays
{
    internal class LCD : Display
    {
        public override void Info()
        {
            Console.WriteLine("LCD - Liquid Crystal Display");
        }
    }
}
