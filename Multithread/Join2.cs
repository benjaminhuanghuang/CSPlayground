using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test
{
    class TestThread
    {
        private static void ThreadFuncOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name +"   i =  " + i);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " has finished");
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "MainThread";

            Thread newThread = new Thread(new ThreadStart(TestThread.ThreadFuncOne));
            newThread.Name = "NewThread";

            for (int j = 0; j < 20; j++)
            {
                if (j == 10)
                {
                    newThread.Start();
                    newThread.Join();
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "   j =  " + j);
                }
            }
            Console.Read();
        }
    }
}
