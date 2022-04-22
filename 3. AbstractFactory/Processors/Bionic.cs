using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Processors
{
    internal class Bionic : Processor
    {
        public override void About()
        {
            Console.WriteLine("A12 Bionic processor");
        }
    }
}
