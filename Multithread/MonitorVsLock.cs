/*
https://www.youtube.com/watch?v=N9jJKPVxD7c

*/

using System;
using System.Threading;

public class MonitorVsLockDemo
{   
    static int total = 0;
    static Object _lock = new Object();
    public static void AddOne()
    {
        for (int i =0 ;i < 1000; i++)
        {
            lock(_lock)
            {
                total ++;
            }
        }
    }

    public static void AddOneMonitor()
    {
        for (int i =0 ;i < 1000; i++)
        {
            Monitor.Enter(_lock);
            try
            {
                total ++;
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }    
}