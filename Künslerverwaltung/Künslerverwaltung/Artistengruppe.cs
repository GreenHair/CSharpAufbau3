using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    class Artistengruppe:Kuenstlergruppe
    {
        private double pauschalPreis;
        private string genre;

        public Artistengruppe(string name, string genre, double preis):base(name)
        {
            pauschalPreis = preis;
            this.genre = genre;
        }

        public double GetPauschlpreis()
        {
            return pauschalPreis;
        }

        public override string getArt()
        {
            return "Keine Ahnung";
        }
    }
}
