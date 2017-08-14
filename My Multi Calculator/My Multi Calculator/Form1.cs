using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Multi_Calculator
{
    public partial class Minu : Form
    {
        public Minu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Age se = new Age();
            se.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmer : Mohamed El_Hagry \nE-Mail : afrotoelhagry0127@yahoo.com \nPhone : 01273310002","About Creater",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pais secondscrean = new Pais();
            secondscrean.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GPA se = new GPA();
            se.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XO se = new XO();
            se.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DTB se = new DTB();
            se.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BTD se = new BTD();
            se.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Weight se = new Weight();
            se.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 se = new Form9();
            se.Show();
            this.Hide();
        }
    }
}
