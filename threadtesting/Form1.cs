using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadtesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = textBox1.Text + "Hello\r\n";
                textBox1.Text = Environment.ProcessorCount.ToString();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(LongOperation);
            t.Name = "Doing long operation";
            t.Start();
            MessageBox.Show(t.IsAlive.ToString());
            t.Join();
            //LongOperation();
        }

            void LongOperation() {
            Thread.Sleep(5000);
            
            MessageBox.Show("Long operation done");
        }
    }

    
}
