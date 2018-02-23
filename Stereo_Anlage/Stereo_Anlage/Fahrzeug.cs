using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Anlage
{
    class Fahrzeug
    {
        protected Fahrer driver;
        protected Tuning_Paket tuning;
        protected Motor engine;
        protected int anzahlRäder;
        protected int gewicht;
        protected int anzahlSitzplätze;
        protected float luftwiderstand;
        
        public Fahrzeug() { }

        public int Beschleunigen(double wert) { throw new NotImplementedException(); }
        public int Bremsen(double wert) { throw new NotImplementedException(); }
        public int Lenken(double wert) { throw new NotImplementedException(); }
        public void Starten() { }
        public void Airbag() { }
    }

    class Fahrer { }
    class Tuning_Paket { }
    class Motor { }
}
