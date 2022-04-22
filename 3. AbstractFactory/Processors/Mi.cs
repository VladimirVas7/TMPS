using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Processors
{
    internal class Mi : Processor
    {
        public override void About()
        {
            Console.WriteLine("Xiaomi Mi MIX");
        }
    }
}
