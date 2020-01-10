using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{
    public partial class w : Form
    {
        public w()
        {
            InitializeComponent();
        }

        int i;
        int j;
        int y;

        private void w_Load(object sender, EventArgs e)
        {

        }

        private void startRaceButton_Click(object sender, EventArgs e)
        {
            String winner = null;
            Random rnd = new Random();
            int rndNumberOne = rnd.Next(99, 601);

            Random rndOne = new Random();
            int rndNumberTwo = rnd.Next(99, 601);

            Random rndTwo = new Random();
            int rndNumberThree = rnd.Next(99, 601);

            for (int i = 0; i < rndNumberOne; i++)
            {

                pictureBox1.Left = i;
            }

            for (int j = 0; j < rndNumberTwo; j++)
            {

                pictureBox2.Left = j;
            }

            for (int y = 0; y < rndNumberThree; y++)
            {
                pictureBox3.Left = y;
            }

            if (i >= j || i >= y)
            {
                winner = "Lighting";
            }
            if (j >= i || j >= y)
            {
                winner = "Thunder";
            }
            if (y >= i || y >= j)
            {
                winner = "Bumper";
            }
            textBox3.Text = winner;
        }
    }
}
