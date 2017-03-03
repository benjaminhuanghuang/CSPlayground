using System;
using System.Threading;

/*
    Each time, the program gives different result.
    Inc的代码会 和 Dec的代码 交错执行
 */
public class RaceDemo
{
    static int counter=0;
    static int R1=0;
    static Random random = new Random();

    public static void Main(string[] args)
    {
        Thread thread_inc = new Thread(inc);
        Thread thread_dec = new Thread(dec);

        thread_inc.Start();
        thread_dec.Start();

        thread_inc.Join();
        thread_dec.Join();
        
    }

    static void waitAndSee(string message)
    {
        Thread.Sleep(random.Next(0,10));
        Console.WriteLine(message + "   R1:"+ R1 + "  counter:"+ counter);
    }

    static void Inc()
    {
        R1 = counter;
        waitAndSee("inc: R1 = counter");
        
        R1 = R1 +1;
        waitAndSee("inc: R1 = R1 + 1");

        counter = R1;
        waitAndSee("inc: counter = R1");
    }

    static void Dec()
    {
        R1 = counter;
        waitAndSee("dec: R1 = counter");
        
        R1 = R1 -1;
        waitAndSee("dec: R1 = R1 - 1");

        counter = R1;
        waitAndSee("dec: counter = R1");
    }
}


public class RaceDemo2
{
    static int counter=0;
    static int R1=0;
    static Random random = new Random();
    string string counterLocker = "counterLocker";

    public static void Main(string[] args)
    {
        Thread thread_inc = new Thread(inc);
        Thread thread_dec = new Thread(dec);

        thread_inc.Start();
        thread_dec.Start();

        thread_inc.Join();
        thread_dec.Join();
        
    }

    static void waitAndSee(string message)
    {
        Thread.Sleep(random.Next(0,10));
        Console.WriteLine(message + "   R1:"+ R1 + "  counter:"+ counter);
    }

    static void Inc()
    {
        lock(counterLocker)
        {
            R1 = counter;
            waitAndSee("inc: R1 = counter");
            
            R1 = R1 +1;
            waitAndSee("inc: R1 = R1 + 1");

            counter = R1;
            waitAndSee("inc: counter = R1");
        }
    }

    static void Dec()
    {
        lock(counterLocker)
        {
            R1 = counter;
            waitAndSee("dec: R1 = counter");
            
            R1 = R1 -1;
            waitAndSee("dec: R1 = R1 - 1");

            counter = R1;
            waitAndSee("dec: counter = R1");
        }
    }
}