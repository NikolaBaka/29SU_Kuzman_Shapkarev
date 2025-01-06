using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПИС_12А___ПЗ_Александър_Христов
{
    public partial class Form1 : Form
    {
        public static string name = "";
        public static string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Form1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            password = textBox2.Text;

            if (textBox2.Text.Length > 0)
            {
                this.Hide();
                new Form2().ShowDialog();
            }
            else
            {
                if (name != "" && password != "")
                {
                    MessageBox.Show("Please enter password");
                }
                else if (name != "" && password == "")
                {
                    MessageBox.Show("Please enter username");
                }
                else
                {
                    MessageBox.Show("Please enter username and password");
                }
            } 
        }
    }
}
