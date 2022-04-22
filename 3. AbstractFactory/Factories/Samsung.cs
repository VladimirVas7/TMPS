using AbstractFactory.Displays;
using AbstractFactory.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class Samsung : Smartphone
    {
        public Samsung()
        {
            Console.WriteLine("Model > Samsung A70");
        }
        public Display CreateDisplay()
        {
            return new AMOLED();
        }

        public Processor CreateProcessor()
        {
            return new Exynos();
        }
    }
}
