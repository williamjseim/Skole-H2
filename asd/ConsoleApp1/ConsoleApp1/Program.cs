using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {

        List<Philosopher> philosophersList = new List<Philosopher>();
        static List<Fork> forksList = new List<Fork>();
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Start();
        }
        public void Start()
        {
            /* Define Forks */
            for (int i = 0; i < 5; i++)
            {
                Fork fork = new Fork(); // Vi skal pille lidt i constructors her
                fork.Id = i;
                forksList.Add(fork);
            }
            /* Define Philosophers */
            for (int i = 0; i < 5; i++)
            {
                Philosopher philosopher = new Philosopher();
                philosopher.Id = i;
                philosopher.LeftHand = forksList[i];

                if (i == 4)
                {
                    philosopher.RightHand = forksList[0];
                }
                else {
                    philosopher.RightHand = forksList[i + 1];
                }

                philosophersList.Add(philosopher);
                philosopher.Awake(i);
            }

        }

        class Philosopher
        {
            static object _lock = new object();
            public Thread thread;
            private int _id;
            private Fork _rightHand;
            private Fork _leftHand;
            private int _nextHungry = 5;
            private State _state = State.Thinking;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public Fork RightHand
            {
                get { return (Fork)_rightHand; }
                set { _rightHand = value; }
            }
            public Fork LeftHand
            {
                get { return (Fork)_leftHand; }
                set { _leftHand = value; }
            }
            public int NextHungry
            {
                get { return _nextHungry; }
                set { _nextHungry = value; }
            }
            public State State
            {
                get { return _state; }
                set { _state = value; }
            }

            public int ThinkAboutEating()
            {
                int nextHungryInt;
                Random rnd = new Random();
                nextHungryInt = rnd.Next(0, 6);
                return nextHungryInt;
            }

            public bool isHungry()
            {
                if (_state == State.Hungry)
                {

                    return true;
                }
                return false;
            }

            public void CanEat()
            {
                Monitor.Enter(_lock);
                try
                {
                    if (!Monitor.TryEnter(_rightHand))
                    {
                        Monitor.Wait(_rightHand);
                        Monitor.Enter(_rightHand);
                    }
                    if (!Monitor.TryEnter(_rightHand))
                    {
                        Monitor.Wait(_leftHand);
                        Monitor.Enter(_leftHand);
                    }
                }
                finally { Eat(); }
            }

            void Eat()
            {
                Console.WriteLine(Id+" Is Eating");
                //Thread.Sleep(1000);
                Monitor.Exit(_lock);
                _state = State.Thinking;
                Console.WriteLine(Id + " Is Thinking");
            }

            void StartEating()
            {
                bool stop = false;
                while (!stop)
                {
                    int i = this.ThinkAboutEating();
                    //Console.WriteLine(i);
                    if (i == 5)
                    {
                        this.State = State.Hungry;
                        CanEat();
                    }
                }
            }

            public void Awake(int i)
            {
                thread = new Thread(StartEating);
                thread.Name = i.ToString();
                thread.Start();
            }
        }

        class Fork
        {
            private int _id;
            public object inUse = new object();


            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

        }

        public enum State
        {
            Waiting,
            Eating,
            Hungry,
            Thinking
        }
    }
}