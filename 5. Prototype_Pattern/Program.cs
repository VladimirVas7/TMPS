using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog_TI catalog_ti193 = new Catalog_TI();
            catalog_ti193.Get_Obiecte();
            catalog_ti193.Get_Studenti();
            catalog_ti193.Creare();

            catalog_ti193.obiecte[0] = "test";

            Catalog_TI catalog_ti192 = (Catalog_TI)catalog_ti193.Clone();
            catalog_ti192.Get_Studenti();
            catalog_ti192.Creare();
            Console.WriteLine(catalog_ti192.obiecte[0]);
        }
    }
}