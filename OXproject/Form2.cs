using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OXproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(inputP1.Text, inputP2.Text);
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = true;    
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
