using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            KuenstlerListe kl = new KuenstlerListe();
            kl.Hinzufügen(new Musikgruppe("The Beatles", "Rock", 3000));
            Console.WriteLine(kl.GetGruppe(0).getName());
        }
    }
}
