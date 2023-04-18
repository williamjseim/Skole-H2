using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dining_Philosophers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Philosopher> philosophersList = new List<Philosopher>();
            List<Fork> forksList = new List<Fork>();
            /* Define Forks */
            for (int i = 0; i < 5; i++)
            {
                Fork fork = new Fork(); // Vi skal pille lidt i constructors her
                forksList.Add(fork);
            }

            /* Define Philosophers */
            for (int i = 0; i < 5; i++)
            {
                Philosopher philosopher = new Philosopher();
                philosopher.LeftHand = forksList[1];
                philosopher.RightHand = forksList[i+1];
                philosophersList.Add(philosopher);
            }



        }
    }

    class Philosopher
    {
        private int _id;
        private Fork _rightHand;
        private Fork _leftHand;
        private float _nextHungry;
        private string _state;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int RightHand
        {
            get { return _rightHand; }
            set { _rightHand = value; }
        }
        public int LeftHand
        {
            get { return _leftHand; }
            set { _leftHand = value; }
        }
        public float NextHungry
        {
            get { return _nextHungry; }
            set { _nextHungry = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
    }

    class Fork
    {

    }

    public enum State
    {
        Waiting,
        Eating,
        Thinking
    }
}
