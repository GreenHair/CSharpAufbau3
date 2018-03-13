using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();

            if(liste == null)
            {
                Console.WriteLine("null");
            }

            if(liste.Count == 0)
            {
                Console.WriteLine("null");
            }
            Console.ReadLine();
        }
    }
}
