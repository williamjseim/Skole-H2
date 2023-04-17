class program
{
     public void WorkThreadFunction(object stateArg)
    {
        // Blot for at ryste posen lidt, har jeg slået et par af opgaverne sammen, med de tricks vi har lært i dag.
        // Tænker også det er hurtigere at kigge igennem, istedet for flere forskellige kodefiler.
        // Opg + n: ; indikerer Opgaven der løses. F.eks. Opg1, Opg2

        // Svar til Opgave 2's spørgsmål: Er det smart at benytte Thread.Sleep(1000)?
        // Det kommer helt an på hvilken case man har. For at simulere arbejde, og lære i en setting som denne.. Så kan det være en genvej til at simulere en "busy" state.
        // I den virkelige verden, er 1000ms rigtig lang tid. Og benytter man sleeps her, introducerer man alvorlige performance problemer, helt unødvendigt.

        // Herunder definerer vi en privat variabel, der gerne må være null. Den tager parameteren metoden blev kaldt med, og antager at den er en string.
         string? _msg = stateArg as string;
        // For-løkke, kører 5 gange
        for (int i = 0; i < 5; i++)
        {
            // Default der sikrer at der ikke går lort i den, hvis der skulle passed en null værdi.
            if (String.IsNullOrEmpty(_msg))
            {
                
                Console.WriteLine("I have no name");
            }
            else {
                // Med en switch fortolker vi indholdet af vores private variabel. For at løse 2 opgaver sideløbende.
                switch (_msg)
                {

                    case "Main": {
                            Console.WriteLine("Opg1: Jeg hedder: Main. Opg2: C#-trådning er nemt!");
                        }
                        break;

                    case "Slim Shady": {
                            Console.WriteLine("Opg1: Jeg hedder Slim Shady. Opg2: Også med flere tråde.");
                        }
                        break;


                    default:
                        break;
                }
                // Sleep, opgaven beskriver jeg skulle lave
                Thread.Sleep(1000);
            }
        }
    }
    


}

// Opret en klasse der indeholder vores mainthread, og starter vores program-klasse
class threprog
{
    // Definer vores Main metode
    public static void Main()
    {
        // Instantiér vores program-objekt
        program pg = new program();
        // instantiér vores Main thread, og definér dens workload. Er ikke helt sikker på, hvorfor vi gør det i et program objekt. Men det stod i opgaven at det skulle være sådan.
        Thread threadOne = new Thread(pg.WorkThreadFunction);
        threadOne.Name = "Main";
        // Start Main thread
        threadOne.Start(threadOne.Name);
        // Instantiér vores sekundære tråd og giv den et navn. Start den herefter.
        Thread threadTwo = new Thread(pg.WorkThreadFunction);
        threadTwo.Name = "Slim Shady";
        threadTwo.Start(threadTwo.Name);

        // Join begge trådende til main tråden
        threadTwo.Join();
        threadTwo.Join();


        // Læs fra keyboardet(for at undgå at programmet lukker uden yderligere varsel.
        Console.Read();
    }
}
