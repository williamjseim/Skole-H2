/* C# Program to Create a Simple Thread */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

class program
{
    public void SaySomething(object stateArg)
    {
        string _msg = stateArg as string;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(stateArg);
        }
    }
}
class threprog
{
    public static void Main()
    {
        string something = "C#-trådning er nemt!";
        program pg = new program();
        Thread threadOne = new Thread(pg.SaySomething);
        threadOne.Start(something);

        something = "Også med flere tråde...";
        Thread threadTwo = new Thread(pg.SaySomething);
        threadTwo.Start(something);
        threadOne.Join();
        threadTwo.Join();
        Console.Read();
    }
}