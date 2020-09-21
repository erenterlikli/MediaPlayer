using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\EREN BELGELER\\Kitaplarım\\DAYDREAM Korku Antolojisi\\Theme Song.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\Eren\\Desktop\\EREN BELGELER\\Kitaplarım\\DAYDREAM Korku Antolojisi\\1.Daydream-Ghost Town\\Kapak 3.png";
        }
    }
}
