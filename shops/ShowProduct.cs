using shops.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace shops
{
    public partial class ShowProduct : Form
    {

        public ShowProduct()
        {
            InitializeComponent();
        }
        public ShowProduct(int Id)
        {
            InitializeComponent();
            ID = Id;


        }
        public int ID { get; set; }
        private void ShowProduct_Load(object sender, EventArgs e)
        {
            LoadDataWidthoutFIlter();
        }
        private void LoadDataWidthoutFIlter()
        {
            string command = $"SELECT * FROM products";

            Program.connection.Open();
            SqlCommand cmd = new SqlCommand(command, Program.connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Program.connection.Close();
            LoadProducts(dt);

        }
        public void LoadProducts(DataTable Table)
        {
            foreach (DataRow row in Table.Rows)
            {
                string Id = row["Id"].ToString();
                if (ID == int.Parse(Id))
                {
                    string Price = row["Price"].ToString();
                    string name = row["Name"].ToString();
                    string Information = row["Description"].ToString();
                    string base64image = row["Image"].ToString();

                    label1.Text = name;
                    label2.Text = Price;
                    richTextBox1.Text = Information;

                    try
                    {
                        pictureBox1.Image = new Bitmap(new MemoryStream(Convert.FromBase64String(base64image)));
                    }
                    catch { }
                    break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ch = new checkout(ID);
            ch.ShowDialog();
            ch.Show();



        }
    }
}
