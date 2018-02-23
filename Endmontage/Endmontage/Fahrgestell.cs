using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endmontage
{
    class Fahrgestell
    {
        private string seriennummer;
        private string aufbaubezeichnung;
        private Motor motor;

        public Fahrgestell(string seriennummer, string aufbaubezeichnung, Motor motor)
        {
            this.seriennummer = seriennummer;
            this.aufbaubezeichnung = aufbaubezeichnung;
            this.motor = motor;
        }

        public string getSeriennummer()
        {
            return seriennummer;
        }

        public string getAufbaubezeichnung()
        {
            return aufbaubezeichnung;
        }

        public Motor getMotor()
        {
            return motor;
        }
    }
}
