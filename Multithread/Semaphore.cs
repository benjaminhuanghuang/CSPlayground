/*
Semaphores are used when we have to restrict how many threads can enter a critical region. 
Semaphore is simply a int32 variable maintained by the kernel. We have initialize the Semaphore 
variable we specify the count how many threads can enter into critical region at a time. 

A thread waiting on a semaphore blocks when the semaphore is 0 and unblocks when the semaphore is greater than 0.
 */

using System;
using System.Threading;
using System.Threading.Tasks;
public class Program
{
    static Semaphore semaphore = new Semaphore(5, 5);  //init count and max count
    public static void Main(string[] args)
    {
        Task.Factory.StartNew(() =>
        {
            for (int i = 1; i <= 15; ++i)
            {
                // PrintSomething(i);
                PrintSomethingWithoutSemaphore(i);
                if (i % 5 == 0)
                {
                    Thread.Sleep(2000);
                }
            }
        });
        Console.ReadLine();
    }
 
    public static void PrintSomething(int number)
    {
        semaphore.WaitOne();
        Console.WriteLine(number);
        semaphore.Release();
    }

    public static void PrintSomethingWithoutSemaphore(int number)
    {
        Console.WriteLine(number);
    }
}