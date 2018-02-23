using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereo_Anlage
{
    class CD
    {
        private string title;
        private string interpret;
        private int titleTime;

        public CD()
        {
            title = "NO TITLE";
            interpret = "No Interpreter";
            titleTime = 0;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetInterpret()
        {
            return interpret;
        }

        public int GetTitleTime()
        {
            return titleTime;
        }

        public void SetInterpret(string _interpret)
        {
            interpret = _interpret;
        }

        public void SetTitle(string _title)
        {
            title = _title;
        }

        public void SetTitleTime(int time)
        {
            titleTime = time;
        }
    }
}
