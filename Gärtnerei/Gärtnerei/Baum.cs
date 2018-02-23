using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei
{
    class Baum:Gehoelz
    {
        private int maxHoehe;

        public Baum(int hoehe, string _art, int _jahr, float _preis) : base(_art, _jahr, _preis)
        {
            maxHoehe = hoehe;
        }

        public int MaxHoehe
        {
            get
            {
                return maxHoehe;
            }

            set
            {
                maxHoehe = value;
            }
        }

        public override string getInfo()
        {
            return base.getInfo() + "|" + maxHoehe;
        }
    }
}
