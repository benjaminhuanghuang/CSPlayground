using System;

using CSPlayground.Threads;
using CSPlayground.AsyncAwait;

namespace CSPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // --  Async Await
            // AsyncAwaitDemo.ButtonClick1();
            // AsyncAwaitDemo.ButtonClick2();
            // AsyncAwaitDemo.ButtonClick2_Wrong();
            // Console.ReadLine(); // Wait the async function.
            
            // -- Thread
            // MultiThreadDemo.TwoThreads();
            double a = 2.0;
            Console.WriteLine("{0:F}",a);
            Console.WriteLine("{0:F1}",a);
            Console.WriteLine("{0,5:F1}",a);  // arg0, right align, float
            Console.WriteLine("{0,-5:F1}",a); // arg0, left align, float
            // Console.WriteLine("{-10:F1}",a);
        }
    }
}
