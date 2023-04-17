/*
* C# Program to Create Thread Pools
*/
using System;
using System.Threading;
class ThreadPoolDemo
{
    /* Opret en metode til vores demo. Skriver "task is being executed" et par gange */
    public void task1(object obj)
    {
        /* Start en for-løkke*/
        for (int i = 0; i <= 2; i++)
        {
            /* Skriv output til konsollen */
            Console.WriteLine("Task 1 is being executed");
        }
    }
    /* Opret endnu en metode til vores demo. Skriver "task is being executed" et par gange */

    public void task2(object obj)
    {
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Task 2 is being executed");
        }
    }
    /* Opret en Main() metode */
    static void Main()
    {
        /* Instantiér en threadpool, der hedder tpd */
        ThreadPoolDemo tpd = new ThreadPoolDemo();
        /* Start en for-løkke */
        for (int i = 0; i < 2; i++)
        {
            /* Smid to opgaver ind til threadpoolen tpd. */
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
        }
        Console.Read();
    }
}
