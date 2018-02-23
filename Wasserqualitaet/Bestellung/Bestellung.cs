using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellung
{
    class Bestellung
    {
        private int Bestell_NR;
        Kunde kunde;
        private string Bestelldatum;
        private double Bestellwert;
        private char Zahlungsart;

        public Bestellung(int nr, Kunde kunde, string datum, double wert, char art)
        {
            Bestell_NR = nr;
            this.kunde = kunde;
            Bestelldatum = datum;
            Bestellwert = wert;
            Zahlungsart = art;
        }

        public bool checkZahlungsart()
        {
            if(Zahlungsart == 'K' || Zahlungsart == 'L' || Zahlungsart == 'R')
            {
                return true;
            }
            return false;
        }

        public double berechneVersandkosten(bool Versandgutschein)
        {
            double versandkosten = 0.0;
            if (checkZahlungsart())
            {
                if(Bestellwert < 2500)
                {
                    if (Versandgutschein)
                    {
                        if(Zahlungsart == 'K')
                        {
                            versandkosten = 25 - 20;
                        }
                    }
                    else
                    {
                        if(Zahlungsart == 'K')
                        {
                            versandkosten = 25;
                        }
                        else
                        {
                            versandkosten = 15;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ungültige Zahlungsmethode");
            }
            return versandkosten;
        }
    }
    class Kunde
    {
        public int Kunde_Nr { get; private set; }

        public Kunde(int nr)
        {
            Kunde_Nr = nr;
        }
    }
}
