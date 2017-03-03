using System;
using System.Threading;
using System.Collections.Generic;

public class ProducerConsumerDemo
{
    static readonly int BUFFER_SIZE = 4;
    static Queue<int> circularBuffer = new Queue<int>( BUFFER_SIZE);
    static Semaphore semaFilledSlots = new Semaphore(0, BUFFER_SIZE);
    static Semaphore semaUnfilledSlots = new Semaphore(BUFFER_SIZE, BUFFER_SIZE);
    static Mutex mutex = new Mutex(false);

    static Random random = new Random();

    public static void Main()
    {
        Thread producer = new Thread(new ThreadStart(produce));
        Thread consumer = new Thread(new ThreadStart(consume)); 

        producer.Sstart();
        consumer.Start();

        producer.Join();
        consumer.Join();   
    }

    static void produce()
    {
        while(true){
            Thread.Sleep(random.Next(0,500));

            int produceNumber = random.Next(0, 20);
            Console.WriteLine("Produce : {0}", produceNumber);

            semaUnfilledSlots.WaitOne();
            mutex.WaitOne();

            circularBuffer.Enqueue(produceNumber);

            mutex.ReleaseMutex();
            semaUnfilledSlots.Release();

            if (produceNumber == 0)
            {
                break;
            }
        }
    }

    static void consume()
    {
        while(true){
            semaFilledSlots.WaitOne();
            mutex.WaitOne();

            int number = circularBuffer.Dequeue();
            Console.WriteLine("Consume: {0}", number);

            mutex.ReleaseMutex();
            semaUnfilledSlots.Release();

            if (number == 0)
            {
                break;
            }
            Thread.Sleep(random.Next(0,1000));
        }
    }
}