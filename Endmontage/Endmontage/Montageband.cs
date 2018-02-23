using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endmontage
{
    class Montageband
    {
        private List<Fahrgestell> band;

        public Montageband()
        {
            band = new List<Fahrgestell>();
            band.Add(new Fahrgestell("VVVWZV4571", "Kombi", new Motor("RZK68.99", "12345")));
        }

        public string getMotorbezeichnung(string fahrgestellnummer)
        {
            Fahrgestell f = band.Find(fg => fg.getSeriennummer() == fahrgestellnummer);
            return f.getMotor().getTypbezeichnung();
        }
    }
}
