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
    public partial class Weight : Form
    {
        public Weight()
        {
            InitializeComponent();
        }
        double Rate;
        bool t = true;
        long h;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t)
            {
                Rate = (Convert.ToDouble(textBoxw.Text) / ((Convert.ToDouble(textBoxh.Text) / 100) * (Convert.ToDouble(textBoxh.Text) / 100)));
                h = Convert.ToInt32(Rate);
                Rate = Convert.ToDouble(h);
                if(Rate >= 25 )
                {
                    l1.Text += "Your Rate Is"+ Rate + '\n';
                    l1.Text += "Your Rate In Danger"+'\n';
                    Rate = 21.5 * ((Convert.ToDouble(textBoxh.Text) / 100) * (Convert.ToDouble(textBoxh.Text) / 100));
                    h = Convert.ToInt32(Rate);
                    Rate = Convert.ToDouble(h);
                    l1.Text += "Your Perfect Weight : " + Convert.ToString(Rate) +" KG" + '\n';
                    l1.Text += "So" + '\n';
                    l1.Text += "You Should Loose : " + Convert.ToString(Convert.ToDouble(textBoxw.Text) - Rate) + " KG" + '\n';
                    l1.Text += "You Should See A Doctor" + '\n';
                }
                else if (Rate <= 18)
                {
                    l1.Text += "Your Rate Is" + Rate + '\n';
                    l1.Text += "Your Rate Is Very Weak" + '\n';
                    Rate = 21.5 * ((Convert.ToDouble(textBoxh.Text) / 100) * (Convert.ToDouble(textBoxh.Text) / 100));
                    h = Convert.ToInt32(Rate);
                    Rate = Convert.ToDouble(h);
                    l1.Text += "Your Perfect Weight : " + Convert.ToString(Rate) + " KG" + '\n';
                    l1.Text += "So" + '\n';
                    l1.Text += "You Should Gain : " + Convert.ToString(Rate - Convert.ToDouble(textBoxw.Text)) + " KG" + '\n';
                    l1.Text += "You Should See A Doctor"+'\n';
                }
                else if (Rate != 21.5)
                {
                    if (Rate > 21.5)
                    {
                        l1.Text += "Your Rate Is" + Rate + '\n';
                        l1.Text += "Your Rate Is Good" + '\n';
                        Rate = 21.5 * ((Convert.ToDouble(textBoxh.Text) / 100) * (Convert.ToDouble(textBoxh.Text) / 100));
                        h = Convert.ToInt32(Rate);
                        Rate = Convert.ToDouble(h);
                        l1.Text += "Your Perfect Weight : " + Convert.ToString(Rate) + " KG" + '\n';
                        l1.Text += "So" + '\n';
                        l1.Text += "You Should Loose : " + Convert.ToString(Convert.ToDouble(textBoxw.Text) - Rate) + " KG" + '\n';
                    }
                    else
                    {
                        l1.Text += "Your Rate Is" + Rate + '\n';
                        l1.Text += "Your Rate Is Good" + '\n';
                        Rate = 21.5 * ((Convert.ToDouble(textBoxh.Text) / 100) * (Convert.ToDouble(textBoxh.Text) / 100));
                        h = Convert.ToInt32(Rate);
                        Rate = Convert.ToDouble(h);
                        l1.Text += "Your Perfect Weight : " + Convert.ToString(Rate) + " KG" + '\n';
                        l1.Text += "So" + '\n';
                        l1.Text += "You Should Gain : " + Convert.ToString(Rate - Convert.ToDouble(textBoxw.Text)) + " KG" + '\n';
                    }
                }
                if (Rate == 21.5)
                {
                    l1.Text += "Your Rate Is" + Rate + '\n';
                    l1.Text += "Your Rate Is Perfect" + '\n';
                }
                t = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = true;
            l1.Text = "";
            textBoxh.Text = "";
            textBoxw.Text = "";
        }
    }
}
