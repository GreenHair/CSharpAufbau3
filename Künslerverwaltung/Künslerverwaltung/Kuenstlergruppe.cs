using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    abstract class Kuenstlergruppe
    {
        private string name;

        public Kuenstlergruppe(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public abstract string getArt();        
    }
}
