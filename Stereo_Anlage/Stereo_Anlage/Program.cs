using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Anlage
{
    class Program
    {
        static void Main(string[] args)
        {
            CDPlayer player = new CDPlayer();
            CD disc = new CD();
            disc.SetTitleTime(5);
            player.OpenClose();
            player.Play(disc);
        }
    }
}
