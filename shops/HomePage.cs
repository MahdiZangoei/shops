using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace shops
{
    public partial class HomePage : Form
    {
        Bitmap memoryImage;

        public HomePage()
        {
            InitializeComponent();
            this.Load += HomePage_Load;

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

/*            string User_Name = ID;

            try
            {
                // اتصال به دیتابیس

                Program.connection.Open();

                // اجرای کوئری برای چک کردن نام کاربر
                string query = "SELECT Name FROM Users WHERE Username = @username";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@username", User_Name);




                // اجرای کوئری و دریافت نتیجه
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string Name = reader["Name"].ToString();
                string welcomeText = " سلام " + Name + " عزیز ";
                label1.Text = welcomeText;

                Program.connection.Close();
            }
            catch { }*/



            Task.Run(() => { LoadDataWidthoutFIlter(); });
        }

        private void LoadDataWidthoutFIlter()
        {
            string command = "SELECT * FROM products";


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
            int top = 0;
            int left = 0;
            int objectwidth = 200;
            int objectheight = 300;
            foreach (DataRow row in Table.Rows)
            {
                string name = row["Name"].ToString();
                string Information = row["Description"] + "\t" + row["Price"];
                string base64image = row["Image"].ToString();
                string Id = row["Id"].ToString();
                Invoke(new Action(() =>
                {
                    if (left > panel2.Width - objectwidth - 10)
                    {
                        top += objectheight + 20;
                        left = 0;
                    }
                    shops.Controls.Product p = new Controls.Product();
                    p.Name = name;
                    p.Information = Information;
                    try
                    {
                        p.Image = new Bitmap(new MemoryStream(Convert.FromBase64String(base64image)));
                    }
                    catch { }
                    p.ProductID = int.Parse(Id);
                    p.ObjectOpenClick += P_ObjectOpenClick;

                    p.Top = top;
                    p.Left = left;

                    p.Width = objectwidth;
                    p.Height = objectheight;

                    left += objectwidth + 10;

                    panel2.Controls.Add(p);
                }));
            }
        }
        private void P_ObjectOpenClick(int ProductID)
        {
            //this function is called when the mouse clicked "show" button
            ShowProduct sp = new ShowProduct(ProductID);
            sp.ShowDialog();
            // MessageBox.Show($"Mouse Clicked on product {ProductID}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
