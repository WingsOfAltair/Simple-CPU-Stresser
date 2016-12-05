using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        private static int x = 0, y = 0;
        private static Thread[] Processes = new Thread[Environment.ProcessorCount]; // creates an array of threads based on the amount of your processor's cores count
        static void Main(string[] args)
        {
            for (int i = 0; i < Processes.Length; i++)
            {
                if (i % 2 == 0) // for diversity
                    Processes[i] = new Thread(new ThreadStart(Run)); // assigns function one to the thread if its id is even
                else Processes[i] = new Thread(new ThreadStart(Run2)); // assigns function two to the thread if its id is odd
                Processes[i].Start(); // notifies the thread to start working (calling its assigned function)
            }
        }

        public static void Run() // function number one
        {
            while (true) // so it would run as long as the main program thread is alive
            {
                Console.WriteLine("X: " + x++ + ", Y: " + y++); // a simple output statement that can be replaced with anything else you want to stress it with
            }
        }

        public static void Run2() // function number two
        {
            while (true)
            {
                Console.WriteLine("X2: " + x++ + ", Y2: " + y++);
            }
        }


        // old abandoned code replaced with the loop above.

        /* Thread RunningThread = new Thread(new ThreadStart(Run));
        Thread RunningThread2 = new Thread(new ThreadStart(Run2));
        Thread RunningThread3 = new Thread(new ThreadStart(Run2));
        Thread RunningThread4 = new Thread(new ThreadStart(Run2));
        Thread RunningThread5 = new Thread(new ThreadStart(Run2));
        Thread RunningThread6 = new Thread(new ThreadStart(Run2));
        Thread RunningThread7 = new Thread(new ThreadStart(Run2));
        Thread RunningThread8 = new Thread(new ThreadStart(Run2));
        Thread RunningThread9 = new Thread(new ThreadStart(Run2));
        Thread RunningThread10 = new Thread(new ThreadStart(Run2));
        Thread RunningThread11 = new Thread(new ThreadStart(Run2));
        Thread RunningThread12 = new Thread(new ThreadStart(Run2));
        Thread RunningThread13 = new Thread(new ThreadStart(Run2));
        Thread RunningThread14 = new Thread(new ThreadStart(Run2));
        Thread RunningThread15 = new Thread(new ThreadStart(Run2));
        Thread RunningThread16 = new Thread(new ThreadStart(Run2));
        Thread RunningThread17 = new Thread(new ThreadStart(Run2));
        Thread RunningThread18 = new Thread(new ThreadStart(Run2));
        Thread RunningThread19 = new Thread(new ThreadStart(Run2));
        Thread RunningThread20 = new Thread(new ThreadStart(Run2));
        Thread RunningThread21 = new Thread(new ThreadStart(Run2));
        Thread RunningThread22 = new Thread(new ThreadStart(Run2));
        Thread RunningThread23 = new Thread(new ThreadStart(Run2));
        Thread RunningThread24 = new Thread(new ThreadStart(Run2));
        Thread RunningThread25 = new Thread(new ThreadStart(Run2));
        Thread RunningThread26 = new Thread(new ThreadStart(Run2));
        Thread RunningThread27 = new Thread(new ThreadStart(Run2));
        Thread RunningThread28 = new Thread(new ThreadStart(Run2));
        Thread RunningThread29 = new Thread(new ThreadStart(Run2));
        Thread RunningThread30 = new Thread(new ThreadStart(Run2));
        Thread RunningThread31 = new Thread(new ThreadStart(Run2));
        Thread RunningThread32 = new Thread(new ThreadStart(Run2));
        Thread RunningThread33 = new Thread(new ThreadStart(Run2));
        Thread RunningThread34 = new Thread(new ThreadStart(Run2));
        Thread RunningThread35 = new Thread(new ThreadStart(Run2));
        Thread RunningThread36 = new Thread(new ThreadStart(Run2));
        Thread RunningThread37 = new Thread(new ThreadStart(Run2));
        Thread RunningThread38 = new Thread(new ThreadStart(Run2));
        Thread RunningThread39 = new Thread(new ThreadStart(Run2));
        Thread RunningThread40 = new Thread(new ThreadStart(Run2));

        RunningThread.Start();
        RunningThread2.Start();
        RunningThread3.Start();
        RunningThread4.Start();
        RunningThread5.Start();
        RunningThread6.Start();
        RunningThread7.Start();
        RunningThread8.Start();
        RunningThread9.Start();
        RunningThread10.Start();
        RunningThread11.Start();
        RunningThread12.Start();
        RunningThread13.Start();
        RunningThread14.Start();
        RunningThread15.Start();
        RunningThread16.Start();
        RunningThread17.Start();
        RunningThread18.Start();
        RunningThread19.Start();
        RunningThread20.Start();
        RunningThread21.Start();
        RunningThread22.Start();
        RunningThread23.Start();
        RunningThread24.Start();
        RunningThread25.Start();
        RunningThread26.Start();
        RunningThread27.Start();
        RunningThread28.Start();
        RunningThread29.Start();
        RunningThread30.Start();
        RunningThread31.Start();
        RunningThread32.Start();
        RunningThread33.Start();
        RunningThread34.Start();
        RunningThread35.Start();
        RunningThread36.Start();
        RunningThread37.Start();
        RunningThread38.Start();
        RunningThread39.Start();
        RunningThread40.Start();
            */
    }
}
