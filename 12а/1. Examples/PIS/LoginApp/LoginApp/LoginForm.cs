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
    public partial class LoginForm : Form
    {
        // Свързваща част със сървъра
        string mySqlConnection = "server=127.0.0.1; user=root; database=12adb; password=";

        public LoginForm()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void login()
        {
            string qurey = "SELECT * FROM users WHERE username=\"" + textBoxUsername.Text +
                           "\" AND password=\"" + textBoxPassword.Text + "\" ;";

            MySqlConnection databaseConnection = new MySqlConnection(mySqlConnection);
            MySqlCommand commandDatabase = new MySqlCommand(qurey, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Pass");
            }


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
