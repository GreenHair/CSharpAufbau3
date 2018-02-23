using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserqualitaet
{
    class Messung
    {
        public static double vergleicheMesswerte(double[] messwerte)
        {
            double summe1 = 0.0;
            double summe2 = 0.0;
            double summeMax = 0.0;
            int anzahl = messwerte.Length;
            
            for(int i = 0; i < anzahl; i++)
            {
                if( i%2 == 0)
                {
                    summe1 += messwerte[i];
                }
                else
                {
                    summe2 += messwerte[i];
                }
            }

            if(summe1 > summe2)
            {
                summeMax = summe1;
            }
            else
            {
                summeMax = summe2;
            }

            return summeMax;
        }
    }
}
