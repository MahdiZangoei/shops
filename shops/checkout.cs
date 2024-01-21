using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shops
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }
        public checkout(int Id)
        {
            InitializeComponent();
            ID = Id;


        }
        public int ID { get; set; }
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
                    label4.Text = Price+"تومان";
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkout_Load(object sender, EventArgs e)
        {
            LoadDataWidthoutFIlter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = int.Parse(label2.Text) ;
            int totall = int.Parse(textBox2.Text);
            string copon = textBox1.Text;

            if (copon == "")
            {
                int percent = 0;
            }
            else
            {
                //خواندن محصولات از دیتابیس 
                Program.connection.Open();
                string query1 = "SELECT code FROM copon";
                SqlCommand command1 = new SqlCommand(query1, Program.connection);

                SqlDataReader readerr = command1.ExecuteReader();
                readerr.Read();
                string string_percent = readerr["percent"].ToString();
                int percent = int.Parse(string_percent);
                MessageBox.Show(string_percent);
                    
                Program.connection.Close();
            }
            int sum = price*totall;

            label4.Text = sum + "تومان";

        }
    }
}
