using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterDienstwagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter mitarbeiter1 = new Mitarbeiter { Name = "Fesch", Vorname = "Uwe" };
            Mitarbeiter mitarbeiter2 = new Mitarbeiter { Name = "Fröhlich", Vorname = "Fritz" };
            Mitarbeiter mitarbeiter3 = new Mitarbeiter { Name = "Schmidt", Vorname = "Bruno" };
            Dienstwagen auto1 = new Dienstwagen("Audi", "Blau") { Kennzeichen = "S-GHT 223", SeinFahrer = mitarbeiter1 };
            Dienstwagen auto2 = new Dienstwagen("BMW", "Gelb") { Kennzeichen = "BC-FE 4321", SeinFahrer = mitarbeiter2 };
            Dienstwagen auto3 = new Dienstwagen("Mercedes", "Rot") { Kennzeichen = "S-HE 1122", SeinFahrer = mitarbeiter3 };
            mitarbeiter1.SeinAuto = auto1;
            mitarbeiter2.SeinAuto = auto2;
            mitarbeiter3.SeinAuto = auto3;

            Console.WriteLine("Der Dienstwagen von {0} {1} :", mitarbeiter1.Vorname, mitarbeiter1.Name);
            Console.WriteLine("\t{0}\n\t{1}\n\t{2}", mitarbeiter1.SeinAuto.Hersteller, mitarbeiter1.SeinAuto.Farbe, mitarbeiter1.SeinAuto.Kennzeichen);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Der Fahrer von Dienstwagen 2 :");
            Console.WriteLine("\t{0}\n\t{1}", auto2.SeinFahrer.Vorname, auto2.SeinFahrer.Name);
            Console.ReadLine();
        }
    }
}
