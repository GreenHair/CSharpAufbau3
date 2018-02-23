using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Künslerverwaltung
{
    class KuenstlerListe
    {
        private List<Kuenstlergruppe> meineGruppen;
        private List<Auftritt> auftritte;

        public KuenstlerListe()
        {
            meineGruppen = new List<Kuenstlergruppe>();
            auftritte = new List<Auftritt>();
        }

        public void Hinzufügen(Kuenstlergruppe gruppe)
        {
            meineGruppen.Add(gruppe);
        }

        public bool Entfernen(Kuenstlergruppe gruppe)
        {
            int anzahl = meineGruppen.Count;
            meineGruppen.Remove(gruppe);
            // schauen ob löschen erfolgreich war
            if(meineGruppen.Count == anzahl -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Kuenstlergruppe GetGruppe(int index)
        {
            if (index >= 0 && index < meineGruppen.Count)
            {
                return meineGruppen[index];
            }
            else
            {
                return null;
            }
        }

        public void AuftrittHinzufuegen(string datum, string zeit, int dauer, Kuenstlergruppe gruppe)
        {
            auftritte.Add(new Auftritt(datum, zeit, dauer, gruppe));
        }

        public void auftrittEntfernen(int index)
        {
            auftritte.RemoveAt(index);
        }

        public Auftritt AuftrittAnzeigen(int index)
        {
            if(index >= 0 && index < auftritte.Count)
            {
                return auftritte[index];
            }
            else
            {
                return null;
            }
        }
    }
}
