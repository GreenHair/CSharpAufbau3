using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endmontage
{
    class Motor
    {
        private string typbezeichnung;
        private string motornummer;

        public Motor(string typbezeichnung, string motornummer)
        {
            this.typbezeichnung = typbezeichnung;
            this.motornummer = motornummer;
        }

        public string getMotornummer()
        {
            return motornummer;
        }

        public string getTypbezeichnung()
        {
            return typbezeichnung;
        }
    }
}
