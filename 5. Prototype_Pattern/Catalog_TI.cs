using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    class Catalog_TI : Catalog
    {
        public List<string> obiecte = new List<string>();
        public List<string> studenti = new List<string>();
        public int nr_ob;
        public int nr_st;
        string[,] data = new string[50, 50];
        public override void Get_Obiecte()
        {
            Console.Write("Nr de obiecte > ");
            nr_ob = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nr_ob; i++)
            {
                Console.Write($"Obiectul [{i}] > ");
                string ob = new string(Console.ReadLine());
                obiecte.Add(ob);
            }
        }
        public override void Get_Studenti()
        {
            Console.Write("Nr de studenti > ");
            nr_st = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nr_st; i++)
            {
                Console.Write($"Studentul [{i}] > ");
                string ob = new string(Console.ReadLine());
                studenti.Add(ob);
            }
        }
        
        public override void Creare()
        {
            data[0, 0] = "      ";
            for (int i = 1; i < nr_ob; i++)
            {
                for (int j = 1; j < nr_st; j++)
                {
                    data[i,j] = "-";
                }
            }

            for(int i = 1; i < nr_ob; i++)
            {
                data[1, i] = obiecte[i-1];
            }
            for (int i = 1; i < nr_st; i++)
            {
                data[i, 1] = studenti[i-1];
            }

            for (int i = 0; i < nr_ob; i++)
            {
                for (int j = 0; j < nr_st; j++)
                {
                    Console.Write(" " + data[i,j]);
                }
                Console.WriteLine();
            }
        }
        public override Catalog Clone()
        {
            Catalog_TI copy = new Catalog_TI();
            copy.nr_ob = this.nr_ob;
            copy.obiecte = this.obiecte;
            return copy;
        }
    }
}
