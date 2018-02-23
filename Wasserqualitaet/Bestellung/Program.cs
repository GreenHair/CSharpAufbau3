using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bestellung bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'K');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'K', ohne Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(false));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'V');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'V', ohne Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(false));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'L');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'L', ohne Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(false));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'R');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'R', ohne Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(false));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 2500, 'K');
            Console.WriteLine("Bestellwert 2500, Zahlungsart 'K', ohne Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(false));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'K');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'K', mit Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(true));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'L');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'L', mit Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(true));
            bestellung1 = new Bestellung(1, new Kunde(4711), "12.03.12044", 1200, 'R');
            Console.WriteLine("Bestellwert 1200, Zahlungsart 'R', mit Gutschein. Versandkosten : " + bestellung1.berechneVersandkosten(true));

            Console.ReadLine();
        }        
    }
}
