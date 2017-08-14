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
    public partial class BTD : Form
    {
        public BTD()
        {
            InitializeComponent();
        }
        bool t = true;
        int count=0;
        long sum=0;
        public int Power(int x)
        { 
            int sum = 1;
            for (int i = 0; i < x; i++)
                sum *= 2;
            return sum;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 32)
            {
                MessageBox.Show("That is Over", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            else
            {
                if (t)
                {
                    for (int i = textBox1.Text.Length-1; i >= 0; i--)
                    {
                        if (textBox1.Text[i] == '1')
                        {
                            if (count < 16)
                            {
                                l1.Text += textBox1.Text[i] + " * 2 ^ " + count + " = " + Power(count) + '\n';
                            }
                            else
                                l2.Text += textBox1.Text[i] + " * 2 ^ " + count + " = " + Power(count) + '\n';
                            sum += Power(count);
                            
                            count++;
                            
                            t = false;
                        }
                        else
                        {
                            if (count < 16)
                            {
                                l1.Text += textBox1.Text[i] + " * 2 ^ " + count + " = " + "0" + '\n';
                            }
                            else
                                l2.Text += textBox1.Text[i] + " * 2 ^ " + count + " = " + "0" + '\n';
                            count++;
                            t = false;
                        }
                    }
                    l3.Text = Convert.ToString(sum);
                    t = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            textBox1.Text = "";
            t = true;
            count = 0;
            sum = 0;
        }
    }
}
