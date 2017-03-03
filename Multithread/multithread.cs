using System;
using System.Threading;
 
namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Thread without args
            // Thread th = new Thread(ThreadMethod);
			// Console.WriteLine("This thread");
            // th.Start();

            Thread th = new Thread(ThreadMethod);
            th.Start("Hello");
        }
 
        private static void ThreadMethod()
        {
            Console.WriteLine("Another Thread");
        }

        private static void ThreadMethodWithArgs(object args)
        {
            Console.WriteLine(args.ToString());
        }

    }
}