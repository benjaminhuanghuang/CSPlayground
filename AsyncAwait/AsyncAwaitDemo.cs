using System;
using System.Threading;
using System.Threading.Tasks;

/*
1. How to conver a sync method to async method: 
    Task.Factory.StartNew

*/
namespace CSPlayground.AsyncAwait
{
    public class AsyncAwaitDemo{
        // public static void Main()
        // {
        //     ButtonClick1();
        // }
        public async static void ButtonClick1()
        {
            Task<string> task = LongWork1Async();
            Console.WriteLine("Start working... " + DateTime.Now.ToString("hh:mm:ss:fff"));

            string result = await task;
            Console.WriteLine("Value of result is " + result);
            Console.WriteLine("Value of task.result is " + task.Result);
        }

        async static Task<string> LongWork1Async()
        {
            await Task.Delay(3000);
            return DateTime.Now.ToString("hh:mm:ss:fff");
        }

        public static void ButtonClick2()
        {
            CallLongWork();
            Console.WriteLine("Starting.... " + DateTime.Now.ToString("hh:mm:ss:fff"));
        }

        // Wrong! compare with ButtonClick2
        public async static void ButtonClick2_Wrong()
        {
            var result = await LongWorkAsync("csharp");
            Console.WriteLine("Starting.... " + DateTime.Now.ToString("hh:mm:ss:fff"));
            Console.WriteLine(result + ", " + DateTime.Now.ToString("hh:mm:ss:fff"));
        }

        private async static void CallLongWork()
        {
            var result = await LongWorkAsync("csharp");
            Console.WriteLine(result + ", " + DateTime.Now.ToString("hh:mm:ss:fff"));
        }

        private static string LongWork(string name)
        {
            Thread.Sleep(3000);
            return "Hello " + name;
        }

        private static Task<string> LongWorkAsync(string name)
        {
           return Task.Factory.StartNew(()=>LongWork(name));
        }

    }
}