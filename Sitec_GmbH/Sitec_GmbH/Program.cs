using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitec_GmbH
{
    class Program
    {
        static void Main(string[] args)
        {
            Abrechnung a = new Abrechnung();
            a.Endsumme();
            Console.ReadLine();
        }
    }
}
