using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Processors
{
    internal class Exynos : Processor
    {
        public override void About()
        {
            Console.WriteLine("Exynos 2100");
        }
    }
}
