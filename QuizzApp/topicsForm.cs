using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class topicsForm : Form
    {
        public topicsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newGame = new SinglePlayerForm();
            newGame.FormClosed += (s, args) => this.Close();
            newGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newGame = new musicFormSP();
            newGame.FormClosed += (s, args) => this.Close();
            newGame.Show();
        }
    }
}
