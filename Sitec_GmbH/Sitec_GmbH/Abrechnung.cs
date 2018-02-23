using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sitec_GmbH
{
    class Abrechnung
    {
        public void Endsumme()
        {
            string line = null;
            string[] felder = null;
            double endsumme = 0.0;
            double mwst_A_Gesamt = 0.0;
            double mwst_B_Gesamt = 0.0;
            double mwst_Betrag = 0.0;
            int mwst_A_Satz = 19;
            int mwst_B_Satz = 7;

            // Öffnen der Datei
            StreamReader file = new StreamReader("Positionen.txt");
            // erster datensatz lesen
            line = file.ReadLine();

            while(line != null)
            {
                felder = line.Split(';');
                Console.WriteLine(line);
                for(int i = 0; i < felder.Length; i++)
                {
                    Console.Write(felder[i] + "\t");
                }
                Console.WriteLine();
                endsumme += Convert.ToDouble(felder[5]);
                if(felder[6][0] == 'A')
                {
                    mwst_Betrag = Convert.ToDouble(felder[5]) * mwst_A_Satz / (100 + mwst_A_Satz);
                    Console.WriteLine(mwst_Betrag);
                    mwst_A_Gesamt += mwst_Betrag;
                }
                else
                {
                    mwst_Betrag = Convert.ToDouble(felder[5]) * mwst_B_Satz / (100 + mwst_B_Satz);
                    Console.WriteLine(mwst_Betrag);
                    mwst_B_Gesamt += mwst_Betrag;
                }
                //Nächster Datensatz lesen
                line = file.ReadLine();
            }
            Console.WriteLine("Endsumme: {0:F2} Mehrwertsteuer A : {1:F2} Mehrwertsteuer B : {2:F2} Mehrwertsteuer Gesamt : {3:F2}",
                endsumme, mwst_A_Gesamt, mwst_B_Gesamt, mwst_A_Gesamt + mwst_B_Gesamt);
            file.Close();
        }
    }
}
