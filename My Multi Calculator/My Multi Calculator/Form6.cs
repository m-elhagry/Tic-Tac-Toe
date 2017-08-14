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
    public partial class DTB : Form
    {
        public DTB()
        {
            InitializeComponent();
        }
        long Deci=0, copy=0, re=0;
        bool t = true;
        int count=0;
        string bin = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t)
            {
                if (Convert.ToInt64(textBox1.Text) > 999999999 || textBox1.Text == "")
                {
                    MessageBox.Show("This Is Over", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
                else
                {
                    Deci = Convert.ToInt64(textBox1.Text);
                    while (Deci > 0)
                    {
                        re = Deci % 2;
                        copy = Deci;
                        Deci /= 2;
                        if (count < 16)
                        {
                            l3.Text += Convert.ToString(re) + '\n';
                            l1.Text += Convert.ToString(copy) + '\n';
                            l2.Text += Convert.ToString(Deci) + '\n';
                            bin += Convert.ToString(re);
                        }
                        else
                        {
                            l6.Text += Convert.ToString(re) + '\n';
                            bin += Convert.ToString(re);
                            l4.Text += Convert.ToString(copy) + '\n';
                            l5.Text += Convert.ToString(Deci) + '\n';
                        }
                        count++;
                    }
                    for (int i = bin.Length - 1; i >= 0; i--)
                    {
                        l7.Text += Convert.ToString(bin[i]);
                    }
                }
                t = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            l7.Text = "";
            count = 0;
            bin = "";
            textBox1.Text = "";
            t = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
