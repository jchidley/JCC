using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace JCC
{
    public class Helper
    {
        public static void DebugPrint(string _message)
        {
            // replaces the debug print method with something where we choose how to 
            // display or consume debug messages - could be a log file
            Debug.Print(_message);
        }
        public static void WaitUntilNextPeriod(int period)
        {
            long now = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            var offset = (int)(now % period);
            int delay = period - offset;
            DebugPrint("sleep for " + delay + " ms\r\n");
            Thread.Sleep(delay);
        }
    }
}
