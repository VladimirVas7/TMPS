using AbstractFactory.Displays;
using AbstractFactory.Factories;
using AbstractFactory.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Xiaomi();
            Display ecran = smartphone.CreateDisplay();
            Processor procesor = smartphone.CreateProcessor();
            ecran.Info();
            procesor.About();
        }
    }
}