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
    public partial class XO : Form
    {
        public XO()
        {
            InitializeComponent();
            MessageBox.Show("Player 1 : X"+'\n'+"Player 2 : O", "Game Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label10.Text = "Player : X";
            timer_x.Enabled = true;
            timer_o.Enabled = false;
        }
        int count_score_x = 0, count_score_o = 0,  player = 0;
        bool l1 = true, l2 = true, l4 = true, l3 = true, l5 = true, l6 = true, l7 = true, l8 = true, l9 = true;
        double count_time_x = 0, count_time_o = 0;
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void XO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count_score_x = 0; 
            count_score_o = 0; 
            count_time_x = 0; 
            count_time_o = 0; 
            player = 0;
            l1 = true; 
            l2 = true; 
            l4 = true; 
            l3 = true; 
            l5 = true; 
            l6 = true; 
            l7 = true; 
            l8 = true; 
            l9 = true;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player1 (X) : " + count_score_x + '\n' + "Time Of Player1 (X) : " + (count_time_x)/100 + '\n' + "Player2 (O) : " + count_score_o + '\n'  + "Time Of Player1 (X) : " + (count_time_x)/100,"Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(l1)
            {
                if (player % 2 == 0)
                {
                    label1.Text = "X";
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    l1 = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";

                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                    
                }
                else
                {
                    l1 = false;
                    label1.Text = "O";
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                    
                }
                player++;
                
                
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(l2)
            {
                if (player % 2 == 0)
                {
                    label2.Text = "X";
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    l2 = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label2.Text = "O";
                    l2 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(l3)
            {
                if (player % 2 == 0)
                {
                    label3.Text = "X";
                    l3 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label3.Text = "O";
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    l3= false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(l6)
            {
                if (player % 2 == 0)
                {
                    label6.Text = "X";
                    l6 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false; timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true; timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label6.Text = "O";
                    l6 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false; timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if(l5)
            {
                if (player % 2 == 0)
                {
                    label5.Text = "X";
                    l5 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label5.Text = "O";
                    l5 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(l4)
            {
                if (player % 2 == 0)
                {
                    label4.Text = "X";
                    l4 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false; timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label4.Text = "O";
                    l4 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if(l9)
            {
                if (player % 2 == 0)
                {
                    label9.Text = "X";
                    l9 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label9.Text = "O";
                    l9 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false; timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if(l8)
            {
                if (player % 2 == 0)
                {
                    label8.Text = "X";
                    l8 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label8.Text = "O";
                    l8 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(l7)
            {
                if (player % 2 == 0)
                {
                    label7.Text = "X";
                    l7 = false;
                    timer_x.Enabled = false;
                    timer_o.Enabled = true;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : O";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_x++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (X)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : O";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                else
                {
                    label7.Text = "O";
                    l7 = false;
                    timer_x.Enabled = true;
                    timer_o.Enabled = false;
                    if (((label1.Text == label2.Text && label1.Text == label3.Text) && label1.Text != "" && label2.Text != "" && label3.Text != "") || ((label4.Text == label5.Text && label4.Text == label6.Text) && label4.Text != "" && label5.Text != "" && label6.Text != "") || ((label7.Text == label8.Text && label7.Text == label9.Text) && label7.Text != "" && label8.Text != "" && label9.Text != "") || ((label1.Text == label4.Text && label1.Text == label7.Text) && label1.Text != "" && label4.Text != "" && label7.Text != "") || ((label2.Text == label5.Text && label2.Text == label8.Text) && label5.Text != "" && label5.Text != "" && label8.Text != "") || ((label3.Text == label6.Text && label3.Text == label9.Text) && label3.Text != "" && label6.Text != "" && label9.Text != "") || ((label1.Text == label5.Text && label1.Text == label9.Text) && label1.Text != "" && label5.Text != "" && label9.Text != "") || ((label3.Text == label5.Text && label3.Text == label7.Text) && label3.Text != "" && label5.Text != "" && label7.Text != ""))
                    {
                        label10.Text = "Player : X";
                        l1 = false;
                        l2 = false;
                        l3 = false;
                        l4 = false;
                        l5 = false;
                        l6 = false;
                        l7 = false;
                        l8 = false;
                        l9 = false;
                        count_score_o++;
                        timer_o.Enabled = false;
                        timer_x.Enabled = false;
                        MessageBox.Show("Player1 (O)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer_o.Enabled = true;
                        timer_x.Enabled = true;
                        l1 = true;
                        l2 = true;
                        l4 = true;
                        l3 = true;
                        l5 = true;
                        l6 = true;
                        l7 = true;
                        l8 = true;
                        l9 = true;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                        label4.Text = "";
                        label5.Text = "";
                        label6.Text = "";
                        label7.Text = "";
                        label8.Text = "";
                        label9.Text = "";
                    }
                    else
                    {
                        label10.Text = "Player : X";
                        if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
                        {
                            MessageBox.Show("No One", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                            l1 = true;
                            l2 = true;
                            l3 = true;
                            l4 = true;
                            l5 = true;
                            l6 = true;
                            l7 = true;
                            l8 = true;
                            l9 = true;
                        }
                    }
                }
                player++;
                
            }
        }

        private void timer_x_Tick(object sender, EventArgs e)
        {
            count_time_x++;
        }

        private void timer_o_Tick(object sender, EventArgs e)
        {
            count_time_o++;
        }
    }
}
