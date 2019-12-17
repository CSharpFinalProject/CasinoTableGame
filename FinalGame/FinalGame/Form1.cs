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
    public partial class welcomForm : Form
    {
        public welcomForm()
        {
            InitializeComponent();
        }

        private void pokerButton_Click(object sender, EventArgs e)
        {
            new playingPokerForm().Show();
        }

        private void sportsBetting_Click(object sender, EventArgs e)
        {

        }
    }
}
