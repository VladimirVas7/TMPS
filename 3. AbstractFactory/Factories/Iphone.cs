using AbstractFactory.Displays;
using AbstractFactory.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class Iphone : Smartphone
    {
        public Iphone()
        {
            Console.WriteLine("Model > Iphone 13 PRO MAX");
        }
        public Display CreateDisplay()
        {
            return new OLED();
        }

        public Processor CreateProcessor()
        {
            return new Bionic();
        }
    }
}
