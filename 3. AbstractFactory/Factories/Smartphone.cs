using AbstractFactory.Displays;
using AbstractFactory.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    interface Smartphone
    {
        Display CreateDisplay();
        Processor CreateProcessor();

    }
}
