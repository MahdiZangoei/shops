namespace shops
{
    partial class checkout
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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            richTextBox1.Location = new System.Drawing.Point(12, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            richTextBox1.Size = new System.Drawing.Size(511, 63);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "توضیحاتی تعریف نشده است.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(590, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 17);
            label2.TabIndex = 8;
            label2.Text = "قیمت محصول";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(714, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 54);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(606, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 17);
            label1.TabIndex = 6;
            label1.Text = "نام محصول";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(16, 376);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(83, 25);
            button1.TabIndex = 10;
            button1.Text = "خرید";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(712, 256);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 17);
            label3.TabIndex = 11;
            label3.Text = ":مجموع";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(574, 256);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 17);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(413, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(110, 25);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(681, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(35, 25);
            textBox2.TabIndex = 14;
            textBox2.Text = "1";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(120, 178);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(140, 25);
            button2.TabIndex = 15;
            button2.Text = "اعمال تغییرات";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(722, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 17);
            label5.TabIndex = 16;
            label5.Text = "تعداد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(529, 186);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 17);
            label6.TabIndex = 17;
            label6.Text = "کد تخفیف";
            label6.Click += label6_Click;
            // 
            // checkout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "checkout";
            Text = "برسی خرید";
            Load += checkout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}