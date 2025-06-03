using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextForm
{
    public partial class Form1 : Form
    {
        public static int userId = 0;
        public static string name = "Ivan";
        public static string password = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {

            if (name != "" && password != "")
            {
                if (name == textBoxNameForm1.Text &&
                    password == textBoxPassForm1.Text)
                {
                    this.Hide();
                    new Form2().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid data!");
                }
                
            }
            else
            {
                if (name != "" && password == "")
                {
                    MessageBox.Show("Warning! Please enter password!");
                }
                else if (name == "" && password != "")
                {
                    MessageBox.Show("Warning! Please enter username!");
                }
                else
                {
                    MessageBox.Show("Warning! Please enter username and password!");
                }


            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
