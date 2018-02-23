using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endmontage
{
    class Program
    {
        static void Main(string[] args)
        {
            Montageband m = new Montageband();
            Console.WriteLine(m.getMotorbezeichnung("VVVWZV4571"));

            Console.ReadLine();
        }
    }
}
