using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _21_Understanding_Events_and_Event_Driven_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Elapsed += myTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event");
            Console.ReadLine();

            myTimer.Elapsed -= myTimer_Elapsed1;


            Console.ReadLine();
           
        }

        private static void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
        }

        private static void myTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss:fff}", e.SignalTime);
        }
    }
}
