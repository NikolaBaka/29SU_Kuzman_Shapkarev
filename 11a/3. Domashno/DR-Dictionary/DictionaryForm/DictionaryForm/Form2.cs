using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryForm
{
    public partial class Form2 : Form
    {

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form2()
        {
            InitializeComponent();
            dictionary.Add("Cat", "Kotka");
            dictionary.Add("Dog", "Kuche");
            dictionary.Add("House", "Kushta");
            dictionary.Add("Name", "Ime");
            dictionary.Add("Water", "Voda");
            dictionary.Add("Plane", "Samolet");
            dictionary.Add("Pistol", "Pistolet");
            dictionary.Add("Car", "Kola");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEN.Text == "")
            {
                MessageBox.Show("Enter a word");
            }
            else
            {
                if (dictionary.ContainsKey(textBoxEN.Text))
                {
                    string result = dictionary[textBoxEN.Text];
                    labelBG.Text = result;
                }
                else
                {
                    MessageBox.Show("Translation not found");
                }
            }
        }

        private void textBoxEN_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.SuppressKeyPress)
            //{
            //    button1_Click();
            //    e.Handled = true;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
