using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PregovorCalulatorForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxFirst.Text);
            double b = double.Parse(textBoxSecond.Text);
            double result = a + b;
            labelResult.Text = result.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxFirst.Text);
            double b = double.Parse(textBoxSecond.Text);
            double result = a - b;
            labelResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxFirst.Text);
            double b = double.Parse(textBoxSecond.Text);
            double result = a * b;
            labelResult.Text = result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxFirst.Text);
            double b = double.Parse(textBoxSecond.Text);
            double result = a / b;
            labelResult.Text = result.ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxSecond.Clear();
            labelResult.Text = "";
        }
    }
}
