using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{
    public partial class playingPokerForm : Form
    {
        public playingPokerForm()
        {
            InitializeComponent();
        }

        int winner;

        private void hitButton_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\Users\General User\Desktop\BlackjackPics", "*.png");
            List<string> images = paths.ToList();

            Random random = new Random();
            pictureBox6.ImageLocation = paths[random.Next(0, images.Count - 1)];
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += winner;

            
        }

        private void playingPokerForm_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\Users\General User\Desktop\BlackjackPics", "*.png");
            List<string> images = paths.ToList();

            Random random = new Random();
            pictureBox7.ImageLocation = paths[random.Next(0, images.Count - 1)];
            pictureBox5.ImageLocation = paths[random.Next(0, images.Count - 1)];

            pictureBox1.ImageLocation = paths[random.Next(0, images.Count - 1)];
            pictureBox2.ImageLocation = paths[random.Next(0, images.Count - 1)];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
