using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterDienstwagen
{
    public class Mitarbeiter
    {
        private string _name;
        private string _vorname;
        private Dienstwagen _seinAuto;
        
        public string Name { get { return _name; } set { _name = value; } } 
        public string Vorname { get { return _vorname; } set { _vorname = value; } }
        public Dienstwagen SeinAuto { get { return _seinAuto; } set { _seinAuto = value; } }
    }

    public class Dienstwagen
    {
        private string _kennzeichen;
        private string _hersteller;
        private string _farbe;
        private Mitarbeiter _seinFahrer;

        public Dienstwagen(string hersteller, string farbe)
        {
            _hersteller = hersteller;
            _farbe = farbe;
        }

        public string Kennzeichen { get { return _kennzeichen; } set { _kennzeichen = value; } }
        public string Hersteller { get { return _hersteller; } }
        public string Farbe { get { return _farbe; } }
        public Mitarbeiter SeinFahrer { get { return _seinFahrer; } set { _seinFahrer = value; } }
    }
}
