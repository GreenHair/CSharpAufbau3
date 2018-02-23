using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei
{
    class Gaertnerei
    {
        private List<Gehoelz> inboedel;

        public void Einkaufen(Gehoelz pflanze)
        {
            inboedel.Add(pflanze);
        }

        public string Verkaufen()
    }
}
