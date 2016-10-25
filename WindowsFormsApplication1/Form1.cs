using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Thread th1;
        public Form1()
        {
            InitializeComponent();

            th1 = new Thread(new ThreadStart(Run));
            
            th1.Start();
            
        }

        private void Run()
        {
            this.progressBar1.Maximum = 1000;
            for (int i = 1; i <= 1000; i++)
            {
                this.label1.Text = i.ToString() + "/1000";
                this.progressBar1.Increment(1);
                Thread.Sleep(1000);
            }
            th1 = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
