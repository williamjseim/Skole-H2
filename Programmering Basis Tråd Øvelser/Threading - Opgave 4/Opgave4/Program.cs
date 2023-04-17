using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opgave4
{
    internal class Program
    {

        // Denne statiske variabel, fortæller Writer tråden hvad den skal skrive. Og kan ændres af Reader tråden.
        public static char thisChar;
        static void Main(string[] args)
        {
            // Opgaven behøvede ikke være særlig kompleks.
            // En tråd læser, en anden tråd skriver.
            Thread threadOne = new Thread(ReadThis);
            Thread threadTwo = new Thread(WriteThis);

            threadOne.Start();
            threadTwo.Start();
            threadOne.Join();
            threadTwo.Join();



        }

        public static void ReadThis()
        {
            while (true)
            {
                thisChar = Console.ReadKey().KeyChar;
            }
        }
        public static void WriteThis()
        {

            while (true)
            {
                Console.Write(thisChar);
            }

        }
    }
}
