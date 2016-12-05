using System;
using System.Threading.Tasks;



namespace CSPlayground.AsyncAwait
{
    public class AsyncAwaitDemo{
        public async static void ButtonClick1()
        {
            Task<string> task = LongWork1Async();
            Console.WriteLine("Start working... " + DateTime.Now.ToString("hh:mm:ss:fff"));

            string result = await task;
            Console.WriteLine("Value of result is " + result);
            Console.WriteLine("Value of task.result is " + task.Result);

        }
        public static void ButtonClick2()
        {

        }

        async static Task<string> LongWork1Async()
        {
            await Task.Delay(3000);
            return DateTime.Now.ToString("hh:mm:ss:fff");
        }
    }
}