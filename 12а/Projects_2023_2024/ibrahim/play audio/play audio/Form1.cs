using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace play_audio
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = (@"C:\Users\Student 07\Downloads\\Future, Metro Boomin - Like That (Official Audio).mp3");
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}
