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
using System.Timers;

namespace NextForm
{
    public partial class Form2 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public static int timer = 0;

        public Form2()
        {
            InitializeComponent();
            lableForm2.Text = Form1.name;
        }
        private void timerCounter()
        {
            myTimer



            for (int i = timer; i < 10; i++)
            {
                
                if (i == 10)
                {
                    this.Hide();
                }
            }
        }

        private void lableForm2_Click(object sender, EventArgs e)
        {

        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timerCounter();

        }
    }
}
