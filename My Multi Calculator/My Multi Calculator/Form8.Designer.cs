namespace My_Multi_Calculator
{
    partial class Weight
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
            this.textBoxw = new System.Windows.Forms.TextBox();
            this.textBoxh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxw
            // 
            this.textBoxw.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxw.Location = new System.Drawing.Point(26, 68);
            this.textBoxw.Multiline = true;
            this.textBoxw.Name = "textBoxw";
            this.textBoxw.Size = new System.Drawing.Size(109, 67);
            this.textBoxw.TabIndex = 0;
            // 
            // textBoxh
            // 
            this.textBoxh.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxh.Location = new System.Drawing.Point(26, 188);
            this.textBoxh.Multiline = true;
            this.textBoxh.Name = "textBoxh";
            this.textBoxh.Size = new System.Drawing.Size(109, 67);
            this.textBoxh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Weight (KG)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Hight (cm)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Curlz MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(161, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Curlz MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(187, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Curlz MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(187, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Report";
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(321, 42);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(281, 216);
            this.l1.TabIndex = 8;
            // 
            // Weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 267);
            this.ControlBox = false;
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxh);
            this.Controls.Add(this.textBoxw);
            this.MaximumSize = new System.Drawing.Size(630, 306);
            this.MinimumSize = new System.Drawing.Size(630, 306);
            this.Name = "Weight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfect Weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxw;
        private System.Windows.Forms.TextBox textBoxh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l1;
    }
}