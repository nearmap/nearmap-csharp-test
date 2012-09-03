using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NMTest.Sample
{
    public static class Program
    {

        [DllImport("winmm.dll")]
        internal static extern uint timeBeginPeriod(uint period);
        [DllImport("winmm.dll")]
        internal static extern uint timeEndPeriod(uint period);

        public static void Main(string[] parameters)
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    //Sets the resolution of the timer. This has to be done per thread to ensure that 5ms sleep is actually 5 ms.
                    //http://stackoverflow.com/a/522681
                    timeBeginPeriod(5);
                    //Your code should go here.
                    timeEndPeriod(5);

                }).Start();
            }
        }
    }
}
