using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Personalabteilung
{
    class Mitarbeiterliste
    {
        private List<Mitarbeiter> mitarbeiterliste;

        public void setMitarbeiterliste(List<Mitarbeiter> liste)
        {
            mitarbeiterliste = liste;
        }

        public void schreibeListe()
        {
            StreamWriter stream = new StreamWriter(@"..\..\mitarbeiter.txt");
            foreach(Mitarbeiter m in mitarbeiterliste)
            {
                stream.Write(m.Name + ";");
                stream.Write(m.Vorname + ";");
                stream.Write(m.Nummer);
                stream.WriteLine();
            }
            stream.Close();
        }
    }
}
