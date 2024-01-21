namespace shops.Controls
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ObjectImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ObjectNameLabel = new System.Windows.Forms.Label();
            this.ObjectInformation = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectImage
            // 
            this.ObjectImage.BackColor = System.Drawing.Color.Coral;
            this.ObjectImage.Location = new System.Drawing.Point(94, 3);
            this.ObjectImage.Name = "ObjectImage";
            this.ObjectImage.Size = new System.Drawing.Size(369, 239);
            this.ObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObjectImage.TabIndex = 0;
            this.ObjectImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ObjectImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 289);
            this.panel1.TabIndex = 1;
            // 
            // ObjectNameLabel
            // 
            this.ObjectNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObjectNameLabel.Location = new System.Drawing.Point(0, 289);
            this.ObjectNameLabel.Name = "ObjectNameLabel";
            this.ObjectNameLabel.Size = new System.Drawing.Size(548, 36);
            this.ObjectNameLabel.TabIndex = 2;
            this.ObjectNameLabel.Text = "Name";
            this.ObjectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ObjectInformation
            // 
            this.ObjectInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ObjectInformation.Location = new System.Drawing.Point(0, 325);
            this.ObjectInformation.Name = "ObjectInformation";
            this.ObjectInformation.Size = new System.Drawing.Size(548, 36);
            this.ObjectInformation.TabIndex = 3;
            this.ObjectInformation.Text = "Information";
            this.ObjectInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(236, 364);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(94, 29);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "مشاهده";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.ObjectInformation);
            this.Controls.Add(this.ObjectNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(548, 410);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ObjectImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ObjectNameLabel;
        private System.Windows.Forms.Label ObjectInformation;
        private System.Windows.Forms.Button OpenButton;
    }
}
