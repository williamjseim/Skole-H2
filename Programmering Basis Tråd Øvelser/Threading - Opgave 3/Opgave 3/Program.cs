using System.Threading;
using System;


// Opret en klasse der indeholder vores mainthread, og starter vores program-klasse
class threprog
{
    // Vi benytter denne variabel for at holde en føling med, hvornår vi har set de 3 fejl, opgaven sætter som øvre grænse for programmets(trådens) levetid
    public static int alertCount = 0;
    // Definer vores Main metode
    public static void Main()
    {

        // Vi instantierer en klasse jeg har lavet for hyggens skyld
         CustomAlerter alerter = new CustomAlerter();
         int alertCount = 0;
        // Vi kalder alerter-klassens DoWork() metode i en worker-tråd
         Thread threadOne = new Thread(alerter.DoWork);
        // Giver tråden et passende navn
        threadOne.Name = "Worker"; // Thready McThreadFace lød bare ikke godt.
        threadOne.Start();

        // I stedet for at køre en while for evigt, kan vi lige så godt bruge den bool, vi får foræret fra IsAlive. Effektiv genbrug.
         while (threadOne.IsAlive) {
            Thread.Sleep(10000); // Denne sleep blev der bedt om
            Thread threadTwo = new Thread(CheckForActivity); // Start en ny tråd, der skal checke for, om forrige tråd stadigvæk lever. Den har fået et originalt navn.
             threadTwo.Name = "Main";
            // Vi starter tråden, og sender threadOne's isAlive property med. Denne ændrer sig løbende i takt med at programmet kører.
             threadTwo.Start(threadOne.IsAlive);
            // Join tråd 2 til main thread
             threadTwo.Join();

            }
         // Join tråd 1 til main thread
         threadOne.Join();
        // Lad brugeren se hvad der skete, før programmet afsluttes.
        Console.ReadKey();

        // Metoden der kontrollerer om temperatur-generator tråden stadigvæk lever
        void CheckForActivity(object stateArg)
        {
            // Igen, vi er ikke interesseret i at se nogle error, der kunne være forhindret ved lige at tjekke for nulls
            if (!String.IsNullOrEmpty(stateArg.ToString()))
            {
                // Hvis vi kan få inputtet til metoden her, til at ligne en boolsk 'true', så fortsætter vi. Ellers... må vi jo.. antage det værste..
                if (bool.Parse(stateArg.ToString()) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Temperature-Generator thread is alive and well!");
                    Console.ResetColor();
                }
                // Så er det sgu sket. Så kunne programmet ikke mere.
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
                    
                }
            }
            
        }

    }


    // Klassen her, har jeg skrevet fordi jeg lige ville genopfriske lidt klasse-gymnastik. 
    class CustomAlerter
    {
        private int temperature;

        public int Temperature
        {
            get
            {
                // Når klassens Temperature property hentes, generere vi en ny temperature, hver gang det sker.
                Random rnd = new Random();
                temperature = rnd.Next(-20, 120);
                return temperature;
            }
        }

        public void DoWork()
        {
            // Worker metoden, opgaven tager sit afsæt i..
            while (alertCount < 3)
            {
                int _alertValue = this.Temperature;

                // Mål på, om temperaturen er inde for skiven.. Hvis den er, så fortsæt. Hvis ikke, så giv den et rap over nallerne.
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
                // Sleep der simulerer lidt busyness.
                Thread.Sleep(2000);
            }

        }


    }
}
