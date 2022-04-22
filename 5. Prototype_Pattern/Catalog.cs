using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    abstract class Catalog
    {
        
        public abstract void Get_Obiecte();
        public abstract void Get_Studenti();    
        public abstract void Creare();
        public abstract Catalog Clone();
    }
}
