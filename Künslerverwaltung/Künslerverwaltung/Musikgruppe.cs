using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    class Musikgruppe:Kuenstlergruppe
    {
        private static double aktGemaPauschale;
        private double preisProStunde;
        private string musikStil;

        public Musikgruppe(string name, string stil, double preis):base(name)
        {
            preisProStunde = preis;
            musikStil = stil;
        }

        public double getAktGemPauschale()
        {
            return aktGemaPauschale;
        }

        public double GetPreisProStunde()
        {
            return preisProStunde;
        }

        public override string getArt()
        {
            return "Keine Ahnung";
        }
    }
}
