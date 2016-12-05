using System;
using System.Threading;


namespace CSPlayground.Threads
{
    public class MultiThreadDemo
    {
        public static void TwoThreads()
        {
            ThreadStart job = new ThreadStart(PrintY);
            Thread thread = new Thread(job);
            thread.Start();

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
