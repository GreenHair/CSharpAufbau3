using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalabteilung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiterliste verwaltung = new Mitarbeiterliste();
            List<Mitarbeiter> liste = new List<Mitarbeiter>();
            Mitarbeiter m1 = new Mitarbeiter();
            m1.Name = "Schultz";
            m1.Vorname = "Henk";
            m1.Nummer = 1;
            liste.Add(m1);

            m1 = new Mitarbeiter();
            m1.Name = "Schmidt";
            m1.Vorname = "Franz";
            m1.Nummer = 2;
            liste.Add(m1);

            m1 = new Mitarbeiter();
            m1.Name = "Kunz";
            m1.Vorname = "Jan";
            m1.Nummer = 3;
            liste.Add(m1);

            verwaltung.setMitarbeiterliste(liste);
            verwaltung.schreibeListe();
        }
    }
}
