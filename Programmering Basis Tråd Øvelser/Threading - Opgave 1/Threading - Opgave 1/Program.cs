class program
{
    // Opret en klasse, der udskriver "Simple Thread", 5 gamge
    /*
    public void WorkThreadFunction(object stateArg)
    {
        string? _msg = stateArg as string;
        // For-løkke
        for (int i = 0; i < 5; i++)
        {
            if (String.IsNullOrEmpty(_msg))
            {
                Console.WriteLine("I have no name");
            }
            else {
                //Console.WriteLine($"My name is {_msg}");
                switch (_msg)
                {

                    case "Main": {
                            Console.WriteLine("C#-trådning er nemt!");
                        }
                        break;

                    case "Slim Shady": {
                            Console.WriteLine("Også med flere tråde.");
                           
                        }
                        break;


                    default:
                        break;
                }
                Thread.Sleep(1000);
            }
            // udskriv til konsollen.
            
        }
    }
    */


}

// Opret en klasse der indeholder vores mainthread, og starter vores program-klasse
class threprog
{
    public static int alertCount = 0;
    // Definer vores Main metode
    public static void Main()
    {
        // Instantiér vores program-objekt
        //program pg = new program();
        // instantiér vores Main thread, og definér dens workload
        //Thread threadOne = new Thread(pg.WorkThreadFunction);
       /* Start opgave 3
        CustomAlerter alerter = new CustomAlerter();
        int alertCount = 0;
        Thread threadOne = new Thread(alerter.DoWork);
        threadOne.Name = "Worker";
        threadOne.Start();
        

        bool keepgoing = true;
        while (keepgoing = true) { 
            
            Thread threadTwo = new Thread(CheckForActivity);
            threadTwo.Name = "Main";
            Console.WriteLine("ThreadOne state: " + threadOne.IsAlive.ToString()  );
            threadTwo.Start(threadOne.IsAlive);
            threadTwo.Join();
            keepgoing = threadOne.IsAlive;
            Thread.Sleep(10000);
        }
        threadOne.Join();
        Slut opgave 3 */
        /*
        Thread threadTwo = new Thread(pg.WorkThreadFunction);
        
        threadTwo.Name = "Slim Shady";
        // Instantiér tråd nummer 2
        // Start tråden
        
        
        threadTwo.Start(threadTwo.Name);
        threadTwo.Join();


        // Læs fra keyboardet(for at undgå at programmet lukker uden yderligere varsel.
        Console.Read();
        */
        void CheckForActivity(object stateArg)
        {
            string? _msg = stateArg as string;
            if (!String.IsNullOrEmpty(_msg))
            {
                Console.WriteLine("Activity: " + stateArg);
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
                Thread.Sleep(4000);
            }

        }


    }
}
/*


*/