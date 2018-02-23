using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei
{
    abstract class Gehoelz
    {
        private string art;
        private int pflanzjahr;
        private float preis;

        public Gehoelz(string _art, int _jahr, float _preis)
        {
            art = _art;
            pflanzjahr = _jahr;
            preis = _preis;
        }

        public string Art
        {
            get
            {
                return art;
            }

            set
            {
                art = value;
            }
        }

        public int Pflanzjahr
        {
            get
            {
                return pflanzjahr;
            }

            set
            {
                pflanzjahr = value;
            }
        }

        public float Preis
        {
            get
            {
                return preis;
            }

            set
            {
                preis = value;
            }
        }

        public virtual string getInfo()
        {
            return art + "|" + pflanzjahr + "|" + preis;
        }
    }
}
