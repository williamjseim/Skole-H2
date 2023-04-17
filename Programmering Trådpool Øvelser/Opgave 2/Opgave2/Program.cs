using System;
using System.Threading;
using System.Diagnostics;
namespace ThreadPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiér nyt stopur
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start(); 
            ProcessWithThreadPoolMethod(); // Start Threadpool Benchmark
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start(); 
            ProcessWithThreadMethod(); // Start single-thread benchmark
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        }
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        static void Process(object callback)
        {
            for (int a = 0; a < 100000; a++)
            {
                //
                for (int b = 0; b < 100000; b++)
                {
                    
                    for (int c = 0; c < 100000; c++)
                    {
                        
                        for (int d = 0; d < 100000; d++)
                        {

                        }
                        
                    }
                    
                }
                //
            }
        }
    }
}
