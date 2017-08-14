namespace My_Multi_Calculator
{
    partial class BTD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Curlz MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(133, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 71);
            this.button3.TabIndex = 22;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 34);
            this.textBox1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Curlz MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(104, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 71);
            this.button2.TabIndex = 20;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Curlz MT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(122, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 80);
            this.button1.TabIndex = 19;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(626, 68);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(255, 404);
            this.l2.TabIndex = 24;
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(440, 68);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(190, 404);
            this.l1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(262, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Your Decimal";
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(402, 20);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(467, 28);
            this.l3.TabIndex = 27;
            // 
            // BTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(893, 481);
            this.ControlBox = false;
            this.Controls.Add(this.l3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(909, 520);
            this.MinimumSize = new System.Drawing.Size(909, 520);
            this.Name = "BTD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert From Binary To Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l3;
    }
}