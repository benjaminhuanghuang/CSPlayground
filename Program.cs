using System;

using CSPlayground.AsyncAwait;

namespace CSPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AsyncAwaitDemo.ButtonClick1();

            Console.ReadLine(); // Wait the async function.
        }
    }
}
