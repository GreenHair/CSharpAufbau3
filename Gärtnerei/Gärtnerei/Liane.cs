using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei
{
    class Liane:Gehoelz
    {
        public Liane(string _art, int _jahr, float _preis) : base(_art, _jahr, _preis) { }
    }

    class Strauch : Gehoelz
    {
        private bool istGiftig;

        public Strauch(bool giftig, string _art, int _jahr, float _preis) : base(_art, _jahr, _preis)
        {
            istGiftig = giftig;
        }

        public override string getInfo()
        {
            return base.getInfo() + "|" + istGiftig;
        }
    }
}
