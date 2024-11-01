using Colors.Net.StringColorExtensions;
using Colors.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10
{
    public class ProgressBar
    {
        public int Len { get; set; }
        public int Delay { get; set; }
        public ProgressBar(int len =30 ,int delay = 100)
        { Delay = delay;
            Len = len;
        }
        public void DisPlay()
        {
            for (int i = 0; i < Len; i++)
            {
                ColoredConsole.Write("==".DarkGreen());
                Thread.Sleep(Delay);
            }

        }
    }
}
