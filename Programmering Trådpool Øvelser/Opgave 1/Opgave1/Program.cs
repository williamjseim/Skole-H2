using System;
using System.Diagnostics;
using System.Threading;

namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ThreadPool.QueueUserWorkItem(Process);
            Stopwatch mywatch = new Stopwatch();
            
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();
            ProcessWithThreadPoolMethod();
            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();

            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());

            Console.ReadKey();
        }

        /* Angående at man skal begrunde, om man skal tage "object callback" med, når man queuer en opgave til en threadpool:
           Ja, det skal man.
            Hvorfor: Fordi at Threadpools er lavet sådan, åbentbart. Vi kan se det, hvis vi kigger på implementeringen af Threadpool.QueueUserWorkItem():
                
                public static bool QueueUserWorkItem(WaitCallback callBack)
                {
                    StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
                    return QueueUserWorkItemHelper(callBack, null, ref stackMark, compressStack: true);
                }
         
            Så, den er simpelthen med i konstruktøren. Og skal med - uanset om man benytter callback eller ej.
            Jeg testede om man kunne nøjes med at fodre den med en discard variabel. Det kan man godt.
            Læs mere her: https://www.c-sharpcorner.com/blogs/c-sharp-hidden-gems-sharp1-discards-variable
         */
        //static void Process(object callback)
        static void Process(object _)
        {
        }

        // Opret metode der starter en thread og eksekverer den ti gange
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        // Opret metode der queuer en opgave til en threadpool ti gange
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                // Send en opgave ind til Threadpoolen
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
