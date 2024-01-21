using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shops.Controls
{
    public delegate void ProductShow(int ProductID);
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
            this.SizeChanged += Product_SizeChanged;
            this.Load += Product_Load;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ObjectImage.Image = Image;
            ObjectNameLabel.Text = Name;
            ObjectInformation.Text = Information;

            Product_SizeChanged(sender, e);
        }

        public event ProductShow ObjectOpenClick;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public Bitmap Image { get; set; }
        private void Product_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = this.Height - this.Height / 3;
            ObjectImage.Height = panel1.Height;
            ObjectImage.Width = panel1.Width * 2 / 3;
            ObjectImage.Top = 0;
            ObjectImage.Left = this.Width / 2 - ObjectImage.Width / 2;

            OpenButton.Top = this.Height - OpenButton.Height;
            OpenButton.Left = this.Width/2 - OpenButton.Width/2;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (ObjectOpenClick != null)
                ObjectOpenClick.Invoke(this.ProductID);
        }
    }
}
