using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace programmering_synkronisering_øvelser___Opgave_1
{
    internal class Program
    {
        static int counter = 0;
        private static object _lock = new object();
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(Increment);
            Thread threadTwo = new Thread(Decrement);
            
                threadOne.Start();
                threadTwo.Start();
            

        }
        public static void Increment() {
            while (true)
            {
                try
                {
                    Monitor.Enter(_lock);
                    counter++;
                    Monitor.Exit(_lock);
                    Console.WriteLine("Value of counter is currently: " + counter.ToString());
                }
                catch
                {
                    Console.WriteLine("An error occured while incrementing...");
                }
                finally
                {

                    Thread.Sleep(1000);
                }
            }
        }
        public static void Decrement() {
            while (true)
            {
                try
                {
                    Monitor.Enter(_lock);
                    counter--;
                    Monitor.Exit(_lock);
                    Console.WriteLine("Value of counter is currently: " + counter.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occured while decrementing...");
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
         }
    }
}
