using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginApp
{
    public partial class RegistrationForm : Form
    {

        // Свързваща част със сървъра
        string mySqlConnection = "server=127.0.0.1; user=root; database=12adb; password=";

        public RegistrationForm()
        {
            InitializeComponent();

            // Обект от класа MySqlConnection
            MySqlConnection mySqlConnection1 = new MySqlConnection(mySqlConnection);

            try
            {
                mySqlConnection1.Open();
                MessageBox.Show("Connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection1.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            comboBoxGender.Items.Add("Мъж");
            comboBoxGender.Items.Add("Жена");
        }
    }
}
