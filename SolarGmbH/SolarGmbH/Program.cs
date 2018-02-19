using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarGmbH
{
    class Program
    {
        static void Main(string[] args)
        {
            Investor inv = new Investor();
            inv.Vorname = "Fritz";
            inv.Zuname = "Sonnenschein";
            inv.Telefonnr = "022142345112";
            inv.Email = "Sonneschein@Sonne.de";

            Console.WriteLine("{0} {1} tel: {2} email: {3}", inv.Vorname, inv.Zuname, inv.Telefonnr, inv.Email);
            Console.ReadLine();
        }
    }
}
