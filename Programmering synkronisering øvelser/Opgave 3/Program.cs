using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace programmering_synkronisering_øvelser___Opgave_3
{
    internal class Program
    {
        static int counter = 0;
        private static object _lock = new object();
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(StarsnHashtags);
            Thread threadTwo = new Thread(StarsnHashtags);

            threadOne.Start("*");
            threadTwo.Start("#");

            threadOne.Join();
            threadTwo.Join();
        }
        public static void StarsnHashtags(object stateArg)
        {
            bool keepgoing = true;
            string param = stateArg as string;
            while (keepgoing)
            {
                try
                {
                    Monitor.Enter(_lock);
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write(stateArg);
                        counter++;
                    }
                    Console.WriteLine($"     [{counter}] ");
                    
                    Monitor.Exit(_lock);
                }
                catch
                {
                    Console.WriteLine("An error occured while incrementing...");
                }
                finally
                {
                    if (counter > 1000) { keepgoing = false;  }
                    Thread.Sleep(1000);
                    // Now exitting with thread still locked
                }
            }
        }
    }
}
