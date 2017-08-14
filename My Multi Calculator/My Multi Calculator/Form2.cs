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
    public partial class Pais : Form
    {
        public Pais()
        {
            InitializeComponent();
        }
        double money;
        private void button3_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(textBox1.Text);
            label1.Text = Convert.ToString(money * 0.025);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "   Your Pais";
            textBox1.Text = "Enter Your Money Here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
