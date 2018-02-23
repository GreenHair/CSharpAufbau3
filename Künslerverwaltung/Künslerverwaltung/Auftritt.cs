using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    class Auftritt
    {
        private string datum;
        private string uhrzeit;
        private int dauer;
        private Kuenstlergruppe gruppe;

        public Auftritt(string datum, string zeit, int dauer, Kuenstlergruppe gruppe)
        {
            this.datum = datum;
            uhrzeit = zeit;
            this.dauer = dauer;
            this.gruppe = gruppe;
        }
    }
}
