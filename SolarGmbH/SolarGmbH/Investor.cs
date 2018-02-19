using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarGmbH
{
    class Investor
    {
        private string _vorname;
        private string _zuname;
        private string _telefonnr;
        private string _email;
        private List<Anlage> _investierungen;

        public Investor()
        {
            _investierungen = new List<Anlage>();
        }

        public string Vorname
        {
            get
            {
                return _vorname;
            }

            set
            {
                _vorname = value;
            }
        }

        public string Zuname
        {
            get
            {
                return _zuname;
            }

            set
            {
                _zuname = value;
            }
        }

        public string Telefonnr
        {
            get
            {
                return _telefonnr;
            }

            set
            {
                _telefonnr = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public List<Anlage> Investierungen
        {
            get
            {
                return _investierungen;
            }
        }
    }

    class Anlage
    {
        private int _baujahr;
        private int _leistung;
        private int _laufzeit;
        private Standort _standort;

        public Anlage(int baujahr, int leistung, Standort stand)
        {
            _baujahr = baujahr;
            _leistung = leistung;
            _standort = stand;
        }

        public int Baujahr { get { return _baujahr; } }
        public int Leistung { get { return _leistung; } }
        public int Laufzeit { get { return _laufzeit; } set { _laufzeit = value; } }
        public Standort Standort { get { return _standort; } }
    }

    class Standort { }
}
