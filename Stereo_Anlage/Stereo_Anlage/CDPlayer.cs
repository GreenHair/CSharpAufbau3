using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Stereo_Anlage
{
    class CDPlayer
    {
        private bool systemOn;
        private bool discInside;

        public CDPlayer()
        {
            systemOn = false;
            discInside = false;
        }

        public void Power()
        {
            systemOn = true;
        }

        public void Stop()
        {
            if(discInside == true)
            {
                Console.WriteLine("Abspielen der CD beendet!");
            }
        }

        public void OpenClose()
        {
            discInside = !discInside;
        }

        public void Play(CD disc)
        {
            if (discInside)
            {
                for (int i = disc.GetTitleTime(); i > 0; i--)
                {
                    Console.WriteLine(disc.GetInterpret());
                    Console.WriteLine(disc.GetTitle());
                    Console.WriteLine("Spieldauer: " + i);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Stop();
            }
            else
            {
                Console.WriteLine("Bitte eine CD einlegen!");
            }
        }
    }
}
