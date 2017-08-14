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
    public partial class GPA : Form
    {
        public GPA()
        {
            InitializeComponent();
        }
        int all_hour = 0;
        double all = 0, aa1 = 0, aa2 = 0, aa3 = 0, aa4 = 0, aa5 = 0, aa6 = 0, aa7 = 0, aa8 = 0, aa9 = 0;
        private void G7_TextChanged(object sender, EventArgs e)
        {

        }

        private void G6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            G1.Text = "";
            G2.Text = "";
            G3.Text = "";
            G4.Text = "";
            G5.Text = "";
            G6.Text = "";
            G7.Text = "";
            G8.Text = "";
            G9.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            C4.Text = "";
            C5.Text = "";
            C6.Text = "";
            C7.Text = "";
            C8.Text = "";
            C9.Text = "";
            gg.Text = "";
            all_hour = 0;
            all = 0;
            aa1 = 0;
            aa2 = 0;
            aa3 = 0;
            aa4 = 0;
            aa5 = 0;
            aa6 = 0;
            aa7 = 0;
            aa8 = 0;
            aa9 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (C1.Text == "")
            {
                C1.Text = "0";
            }
            if (C2.Text == "")
            {
                C2.Text = "0";
            }
            if (C3.Text == "")
            {
                C3.Text = "0";
            }
            if (C4.Text == "")
            {
                C4.Text = "0";
            }
            if (C5.Text == "")
            {
                C5.Text = "0";
            }
            if (C6.Text == "")
            {
                C6.Text = "0";
            }
            if (C7.Text == "")
            {
                C7.Text = "0";
            }
            if (C8.Text == "")
            {
                C8.Text = "0";
            }
            if (C9.Text == "")
            {
                C9.Text = "0";
            }
            all_hour = (Convert.ToInt32(C1.Text) - 48) + (Convert.ToInt32(C2.Text) - 48) + (Convert.ToInt32(C3.Text) - 48) + (Convert.ToInt32(C4.Text) - 48) + (Convert.ToInt32(C5.Text) - 48) + (Convert.ToInt32(C6.Text) - 48) + (Convert.ToInt32(C7.Text) - 48) + (Convert.ToInt32(C8.Text) - 48) + (Convert.ToInt32(C9.Text) - 48);
            if (G1.Text != "")
            {
                if (G1.Text == "A" || G1.Text == "a")
                    aa1 = 4.0;
                else if (G1.Text == "-A" || G1.Text == "-a")
                    aa1 = 3.7;
                else if (G1.Text == "+B" || G1.Text == "+b")
                    aa1 = 3.3;
                else if (G1.Text == "B" || G1.Text == "b")
                    aa1 = 3.0;
                else if (G1.Text == "-B" || G1.Text == "-b")
                    aa1 = 2.7;
                else if (G1.Text == "+C" || G1.Text == "+c")
                    aa1 = 2.3;
                else if (G1.Text == "C" || G1.Text == "c")
                    aa1 = 2.0;
                else if (G1.Text == "-C" || G1.Text == "-c")
                    aa1 = 1.7;
                else if (G1.Text == "+D" || G1.Text == "+d")
                    aa1 = 1.3;
                else if (G1.Text == "D" || G1.Text == "d")
                    aa1 = 1.0;
                else if (G1.Text == "F" || G1.Text == "f")
                    aa1 = 0.0;
            }
            if (G2.Text != "")
            {
                if (G2.Text == "A" || G2.Text == "a")
                    aa2 = 4.0;
                else if (G2.Text == "-A" || G2.Text == "-a")
                    aa2 = 3.7;
                else if (G2.Text == "+B" || G2.Text == "+b")
                    aa2 = 3.3;
                else if (G2.Text == "B" || G2.Text == "b")
                    aa2 = 3.0;
                else if (G2.Text == "-B" || G2.Text == "-b")
                    aa2 = 2.7;
                else if (G2.Text == "+C" || G2.Text == "+c")
                    aa2 = 2.3;
                else if (G2.Text == "C" || G2.Text == "c")
                    aa2 = 2.0;
                else if (G2.Text == "-C" || G2.Text == "-c")
                    aa2 = 1.7;
                else if (G2.Text == "+D" || G2.Text == "+d")
                    aa2 = 1.3;
                else if (G2.Text == "D" || G2.Text == "d")
                    aa2 = 1.0;
                else if (G2.Text == "F" || G2.Text == "f")
                    aa2 = 0.0;
            }
            if (G3.Text != "")
            {
                if (G3.Text == "A" || G3.Text == "a")
                    aa3 = 4.0;
                else if (G3.Text == "-A" || G3.Text == "-a")
                    aa3 = 3.7;
                else if (G3.Text == "+B" || G3.Text == "+b")
                    aa3 = 3.3;
                else if (G3.Text == "B" || G3.Text == "b")
                    aa3 = 3.0;
                else if (G3.Text == "-B" || G3.Text == "-b")
                    aa3 = 2.7;
                else if (G3.Text == "+C" || G3.Text == "+c")
                    aa3 = 2.3;
                else if (G3.Text == "C" || G3.Text == "c")
                    aa3 = 2.0;
                else if (G3.Text == "-C" || G3.Text == "-c")
                    aa3 = 1.7;
                else if (G3.Text == "+D" || G3.Text == "+d")
                    aa3 = 1.3;
                else if (G3.Text == "D" || G3.Text == "d")
                    aa3 = 1.0;
                else if (G3.Text == "F" || G3.Text == "f")
                    aa3 = 0.0;
            }
            if (G4.Text != "")
            {
                if (G4.Text == "A" || G4.Text == "a")
                    aa4 = 4.0;
                else if (G4.Text == "-A" || G4.Text == "-a")
                    aa4 = 3.7;
                else if (G4.Text == "+B" || G4.Text == "+b")
                    aa4 = 3.3;
                else if (G4.Text == "B" || G4.Text == "b")
                    aa4 = 3.0;
                else if (G4.Text == "-B" || G4.Text == "-b")
                    aa4 = 2.7;
                else if (G4.Text == "+C" || G4.Text == "+c")
                    aa4 = 2.3;
                else if (G4.Text == "C" || G4.Text == "c")
                    aa4 = 2.0;
                else if (G4.Text == "-C" || G4.Text == "-c")
                    aa4 = 1.7;
                else if (G4.Text == "+D" || G4.Text == "+d")
                    aa4 = 1.3;
                else if (G4.Text == "D" || G4.Text == "d")
                    aa4 = 1.0;
                else if (G4.Text == "F" || G4.Text == "f")
                    aa4 = 0.0;
            }
            if (G5.Text != "")
            {
                if (G5.Text == "A" || G5.Text == "a")
                    aa5 = 4.0;
                else if (G5.Text == "-A" || G5.Text == "-a")
                    aa5 = 3.7;
                else if (G5.Text == "+B" || G5.Text == "+b")
                    aa5 = 3.3;
                else if (G5.Text == "B" || G5.Text == "b")
                    aa5 = 3.0;
                else if (G5.Text == "-B" || G5.Text == "-b")
                    aa5 = 2.7;
                else if (G5.Text == "+C" || G5.Text == "+c")
                    aa5 = 2.3;
                else if (G5.Text == "C" || G5.Text == "c")
                    aa5 = 2.0;
                else if (G5.Text == "-C" || G5.Text == "-c")
                    aa5 = 1.7;
                else if (G5.Text == "+D" || G5.Text == "+d")
                    aa5 = 1.3;
                else if (G5.Text == "D" || G5.Text == "d")
                    aa5 = 1.0;
                else if (G5.Text == "F" || G5.Text == "f")
                    aa5 = 0.0;
            }
            if (G6.Text != "")
            {
                if (G6.Text == "A" || G6.Text == "a")
                    aa6 = 4.0;
                else if (G6.Text == "-A" || G6.Text == "-a")
                    aa6 = 3.7;
                else if (G6.Text == "+B" || G6.Text == "+b")
                    aa6 = 3.3;
                else if (G6.Text == "B" || G6.Text == "b")
                    aa6 = 3.0;
                else if (G6.Text == "-B" || G6.Text == "-b")
                    aa6 = 2.7;
                else if (G6.Text == "+C" || G6.Text == "+c")
                    aa6 = 2.3;
                else if (G6.Text == "C" || G6.Text == "c")
                    aa6 = 2.0;
                else if (G6.Text == "-C" || G6.Text == "-c")
                    aa6 = 1.7;
                else if (G6.Text == "+D" || G6.Text == "+d")
                    aa6 = 1.3;
                else if (G6.Text == "D" || G6.Text == "d")
                    aa6 = 1.0;
                else if (G6.Text == "F" || G6.Text == "f")
                    aa6 = 0.0;
            }
            if (G7.Text != "")
            {
                if (G7.Text == "A" || G7.Text == "a")
                    aa7 = 4.0;
                else if (G7.Text == "-A" || G7.Text == "-a")
                    aa7 = 3.7;
                else if (G7.Text == "+B" || G7.Text == "+b")
                    aa7 = 3.3;
                else if (G7.Text == "B" || G7.Text == "b")
                    aa7 = 3.0;
                else if (G7.Text == "-B" || G7.Text == "-b")
                    aa7 = 2.7;
                else if (G7.Text == "+C" || G7.Text == "+c")
                    aa7 = 2.3;
                else if (G7.Text == "C" || G7.Text == "c")
                    aa7 = 2.0;
                else if (G7.Text == "-C" || G7.Text == "-c")
                    aa7 = 1.7;
                else if (G7.Text == "+D" || G7.Text == "+d")
                    aa7 = 1.3;
                else if (G7.Text == "D" || G7.Text == "d")
                    aa7 = 1.0;
                else if (G7.Text == "F" || G7.Text == "f")
                    aa7 = 0.0;
            }
            if (G8.Text != "")
            {
                if (G8.Text == "A" || G8.Text == "a")
                    aa8 = 4.0;
                else if (G8.Text == "-A" || G8.Text == "-a")
                    aa8 = 3.7;
                else if (G8.Text == "+B" || G8.Text == "+b")
                    aa8 = 3.3;
                else if (G8.Text == "B" || G8.Text == "b")
                    aa8 = 3.0;
                else if (G8.Text == "-B" || G8.Text == "-b")
                    aa8 = 2.7;
                else if (G8.Text == "+C" || G8.Text == "+c")
                    aa8 = 2.3;
                else if (G8.Text == "C" || G8.Text == "c")
                    aa8 = 2.0;
                else if (G8.Text == "-C" || G8.Text == "-c")
                    aa8 = 1.7;
                else if (G8.Text == "+D" || G8.Text == "+d")
                    aa8 = 1.3;
                else if (G8.Text == "D" || G8.Text == "d")
                    aa8 = 1.0;
                else if (G8.Text == "F" || G8.Text == "f")
                    aa8 = 0.0;
            }
            if (G9.Text != "")
            {
                if (G9.Text == "A" || G9.Text == "a")
                    aa9 = 4.0;
                else if (G9.Text == "-A" || G9.Text == "-a")
                    aa9 = 3.7;
                else if (G9.Text == "+B" || G9.Text == "+b")
                    aa9 = 3.3;
                else if (G9.Text == "B" || G9.Text == "b")
                    aa9 = 3.0;
                else if (G9.Text == "-B" || G9.Text == "-b")
                    aa9 = 2.7;
                else if (G9.Text == "+C" || G9.Text == "+c")
                    aa9 = 2.3;
                else if (G9.Text == "C" || G9.Text == "c")
                    aa9 = 2.0;
                else if (G9.Text == "-C" || G9.Text == "-c")
                    aa9 = 1.7;
                else if (G9.Text == "+D" || G9.Text == "+d")
                    aa9 = 1.3;
                else if (G9.Text == "D" || G9.Text == "d")
                    aa9 = 1.0;
                else if (G9.Text == "F" || G9.Text == "f")
                    aa9 = 0.0;
            }
            all = ((aa1 * (Convert.ToInt32(C1.Text) - 48)) + (aa2 * (Convert.ToInt32(C2.Text) - 48)) + (aa3 * (Convert.ToInt32(C3.Text) - 48)) + (aa4 * (Convert.ToInt32(C4.Text) - 48)) + (aa5 * (Convert.ToInt32(C5.Text) - 48)) + (aa6 * (Convert.ToInt32(C6.Text) - 48)) + (aa7 * (Convert.ToInt32(C7.Text) - 48)) + (aa8 * (Convert.ToInt32(C8.Text) - 48)) + (aa9 * (Convert.ToInt32(C9.Text) - 48))) / all_hour;
            gg.Text = Convert.ToString(all);
        }
    }
}
