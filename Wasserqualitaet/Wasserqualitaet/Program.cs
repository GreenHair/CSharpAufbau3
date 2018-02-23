using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserqualitaet
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] messwerte = { 2.12, 2.14, 5.34, 5.37, 8.88, 8.976 };
            double result = Messung.vergleicheMesswerte(messwerte);
            Console.WriteLine("Der größere Gesamtwert ist : {0}",result);

            Console.ReadLine();
        }
    }
}
