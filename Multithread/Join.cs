using System;
using System.Threading;

/*
当NewThread调用Join方法的时候，MainThread就被停止执行，
直到NewThread线程执行完毕
 */
public class SimpleThread
{
    String name;

    public static void Main()
    {
        SimpleThread a = new SimpleThread("Thread A");
        SimpleThread b = new SimpleThread("Thread B");

        Thread aThread = new Thread(a.Run);
        Thread bThread = new Thread(b.Run);

        aThread.Start();       
        bThread.Start();
        aThread.Join();
        bThread.Join();
    }
    SimpleThread(string name)
    {
        this.name = name;
    }

    public void Run()
    {
        for (int i =0; i < 10 ;i++)
        {
            string line = this.name + ":" + i;
            Console.WriteLine(line);
        }
    }
}


