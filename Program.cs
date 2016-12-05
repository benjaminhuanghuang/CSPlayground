using System;

using CSPlayground.AsyncAwait;

namespace CSPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // AsyncAwaitDemo.ButtonClick1();
            // AsyncAwaitDemo.ButtonClick2();
            AsyncAwaitDemo.ButtonClick2_Wrong();

            Console.ReadLine(); // Wait the async function.
        }
    }
}
