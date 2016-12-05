using System;
using System.Threading;


namespace CSPlayground.Threads
{
    public class MultiThreadDemo
    {
        public static void TwoThreads()
        {
            //http://www.albahari.com/threading/
            // ThreadStart job = new ThreadStart(PrintY);
            // Thread thread = new Thread(job);
            Thread t = new Thread(PrintY);
            t.Start();
            t.Join();    // main thred wait t to end
            PrintX();
        }

        static void PrintX()
        {
            for (int i=0; i < 100; i++)
            {
                Console.Write ("X");
                //Thread.Sleep(500);
            }
        }
        static void PrintY()
        {
            for (int i=0; i < 100; i++)
            {
                Console.Write ("Y");
                //Thread.Sleep(500);
            }
        }

    }
}
