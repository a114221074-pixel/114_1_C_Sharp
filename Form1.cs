using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent( );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos días";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }

        private void translationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
