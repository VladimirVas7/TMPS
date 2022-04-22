using AbstractFactory.Displays;
using AbstractFactory.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class Xiaomi : Smartphone
    {
        public Xiaomi()
        {
            Console.WriteLine("Model > Xiaomi Mi 11 PRO");
        }
        public Display CreateDisplay()
        {
            return new LCD();
        }

        public Processor CreateProcessor()
        {
            return new Mi();
        }
    }
}
