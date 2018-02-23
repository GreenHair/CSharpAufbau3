using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalabteilung
{
    class Mitarbeiter
    {
        private int nummer;
        private string name;
        private string vorname;

        public Mitarbeiter() { }

        public int Nummer
        {
            get
            {
                return nummer;
            }

            set
            {
                nummer = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        
    }
}
