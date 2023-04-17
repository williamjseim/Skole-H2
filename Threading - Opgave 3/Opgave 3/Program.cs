using System.Threading;
using System;


// Opret en klasse der indeholder vores mainthread, og starter vores program-klasse
class threprog
{
    public static int alertCount = 0;
    // Definer vores Main metode
    public static void Main()
    {

         CustomAlerter alerter = new CustomAlerter();
         int alertCount = 0;
         Thread threadOne = new Thread(alerter.DoWork);
         threadOne.Name = "Worker";
         threadOne.Start();

         while (threadOne.IsAlive) {
            Thread.Sleep(10000);
            Thread threadTwo = new Thread(CheckForActivity);
             threadTwo.Name = "Main";
             threadTwo.Start(threadOne.IsAlive);
             threadTwo.Join();

            }
         threadOne.Join();
        
        void CheckForActivity(object stateArg)
        {
            
            if (!String.IsNullOrEmpty(stateArg.ToString()))
            {
                if (bool.Parse(stateArg.ToString()) == true)
                {
                    Console.WriteLine("Temperature-Generator thread is alive and well!");
                }
                else {
                    string rip = @"
                  ____
                 (    )
                 __)(__
           _____/      \\_____
          |  _     ___   _   ||
          | | \     |   | \  ||
          | |  |    |   |  | ||
          | |_/     |   |_/  ||
          | | \     |   |    ||
          | |  \    |   |    ||
          | |   \. _|_. | .  ||
          |                  ||
          |  Temp Thread     ||
          | Hot & Cool 4ever ||
  *       | *   **    * **   |**      **
";
                    Console.WriteLine("Temperature-Generator thread died.");
                    Console.Write(rip);
                    Console.ReadKey();
                }
            }
            
        }

    }


    class CustomAlerter
    {
        private int temperature;

        public int Temperature
        {
            get
            {
                Random rnd = new Random();
                temperature = rnd.Next(-20, 120);
                return temperature;
            }
        }

        public void DoWork()
        {

            while (alertCount < 3)
            {
                int _alertValue = this.Temperature;

                if ((_alertValue > 0) && (_alertValue < 100))
                {
                    Console.WriteLine("Current Temperature is: " + _alertValue.ToString());
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Temperature was not within acceptable parameters. Temperature was: " + _alertValue.ToString());
                    Console.ResetColor();
                    alertCount++;
                }
                Thread.Sleep(2000);
            }

        }


    }
}
