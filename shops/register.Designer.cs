
namespace shops
{
    partial class register
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(416, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(110, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(300, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(110, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(300, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(226, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(300, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(226, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(300, 311);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(226, 64);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(300, 381);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(226, 36);
            button1.TabIndex = 5;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(499, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 17);
            label1.TabIndex = 6;
            label1.Text = "نام ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(333, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 17);
            label2.TabIndex = 7;
            label2.Text = "نام خانوادگی";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(490, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 17);
            label3.TabIndex = 8;
            label3.Text = "ایمیل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(466, 244);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 17);
            label4.TabIndex = 9;
            label4.Text = "نام کاربری";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(483, 292);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 17);
            label5.TabIndex = 10;
            label5.Text = "آدرس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(446, 148);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 17);
            label6.TabIndex = 12;
            label6.Text = "شماره موبایل";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(300, 168);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(226, 25);
            textBox6.TabIndex = 11;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // register
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}