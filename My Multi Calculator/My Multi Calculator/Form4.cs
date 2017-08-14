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
    public partial class Age : Form
    {
        public Age()
        {
            InitializeComponent();
        }
        int bd, nd, bm, nm, by, ny;
        private void button2_Click(object sender, EventArgs e)
        {
            bd = Convert.ToInt32(D2.Text);
            bm = Convert.ToInt32(M2.Text);
            by = Convert.ToInt32(Y2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            D1.Text = "";
            M1.Text = "";
            Y1.Text = "";
            D2.Text = "";
            M2.Text = "";
            Y2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bd = Convert.ToInt32(D2.Text);
            bm = Convert.ToInt32(M2.Text);
            by = Convert.ToInt32(Y2.Text);
        }
    }
}
