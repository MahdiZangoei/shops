using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shops
{


    public partial class paneladmin : Form
    {
        Form homepage = new HomePage();
        //Form login = new login();
        string base64Image;




        public paneladmin()
        {
            InitializeComponent();

        }
        public paneladmin(string U_n)
        {
            InitializeComponent();
            ID = U_n;


        }
        public string ID { get; set; }
        /*        public void ShowDialog(ref string username)
                {
                    //Assign received parameter(s) to local context
                    User_Name = username;

                    this.ShowDialog(); //Display and activate this form (Form2)

                    //Return parameter(s)
                    username = User_Name;

                }*/

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paneladmin_Load(object sender, EventArgs e)
        {
            textBox4.Visible = textBox5.Visible = textBox6.Visible = textBox7.Visible = textBox8.Visible = false;
            del_product.Visible = true;
            Edit_user.Visible = false;
            comboBox4.Visible = false;
            label11.Visible = label12.Visible = label13.Visible = label15.Visible = label17.Visible = label16.Visible = false;





            string User_Name = ID;


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


            //خواندن محصولات از دیتابیس 
            Program.connection.Open();
            string query1 = "SELECT Name FROM products";
            SqlCommand command1 = new SqlCommand(query1, Program.connection);

            SqlDataReader readerr = command1.ExecuteReader();

            while (readerr.Read())
            {
                string name = readerr["Name"].ToString();
                comboBox1.Items.Add(name);
            }
            Program.connection.Close();
            
            

            //خواندن کاربران از دیتابیس 
            Program.connection.Open();
            string query2 = "SELECT Name FROM users";
            SqlCommand command2 = new SqlCommand(query2, Program.connection);

            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                string name = reader2["Name"].ToString();
                comboBox2.Items.Add(name);
            }

            Program.connection.Close();



            label8.Visible = label9.Visible = label10.Visible = textBox1.Visible = textBox1.Visible = textBox2.Visible = textBox3.Visible = button2.Visible = false;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            homepage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxprudactname.Text;
            string price = textBoxprudactprice.Text;
            string description = textBoxprudactdescription.Text;
            Program.connection.Open();
            string query = "INSERT INTO products (Name,Price,Description,Image) VALUES ('" + name + "','" + price + "','" + description + "','" + base64Image + "')";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.ExecuteNonQuery();
            Program.connection.Close();
            MessageBox.Show("محصول اضافه شد.");
            textBoxprudactname.Text = textBoxprudactprice.Text = textBoxprudactdescription.Text = "";
            comboBox1.Items.Add(name);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void del_product_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            Program.connection.Open();
            string query = "DELETE FROM products WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.ExecuteNonQuery();
            Program.connection.Close();
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
        }

        private void edit_product_Click(object sender, EventArgs e)
        {
            label8.Visible = label9.Visible = label10.Visible = textBox1.Visible =
            textBox1.Visible = textBox2.Visible = textBox3.Visible = button2.Visible = true;
            del_product.Visible = false;


            string Price;
            string Description;
            string Image;
            // دریافت اسم محصول
            string productName = comboBox1.SelectedItem.ToString();

            // اتصال به دیتابیس

            Program.connection.Open();

            // ایجاد کوئری
            var query = new SqlCommand("SELECT Price, Description, Image FROM Products WHERE Name = @productName", Program.connection);

            // قرار دادن مقادیر در کوئری
            query.Parameters.AddWithValue("@productName", productName);

            // اجرای کوئری
            var reader = query.ExecuteReader();

            // در صورت وجود نتیجه
            if (reader.Read())
            {
                // دریافت مقدار Price
                string price = reader["Price"].ToString();

                // دریافت مقدار Description
                string description = reader["Description"].ToString();

                // دریافت مقدار Image
                string image = reader["Image"].ToString();

                // ذخیره مقادیر در متغیرها
                Price = price;
                Description = description;
                Image = image;


                textBox1.Text = comboBox1.SelectedItem.ToString();
                textBox2.Text = Price;
                textBox3.Text = Description;


            }
            Program.connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // دریافت اطلاعات محصول
            string ProductName = textBox1.Text;
            string price = textBox2.Text;
            string description = textBox3.Text;
            string image = "none";

            // اتصال به دیتابیس

            Program.connection.Open();

            // ایجاد کوئری
            var query1 = new SqlCommand("UPDATE Products SET Name = @ProductName, Price = @price, Description = @description, Image = @image WHERE Name = @ProductName", Program.connection);

            // قرار دادن مقادیر در کوئری
            query1.Parameters.AddWithValue("@productName", ProductName);
            query1.Parameters.AddWithValue("@price", price);
            query1.Parameters.AddWithValue("@description", description);
            query1.Parameters.AddWithValue("@image", image);

            // اجرای کوئری
            query1.ExecuteNonQuery();

            Program.connection.Close();

            del_product.Visible = true;
            label8.Visible = label9.Visible = label10.Visible = textBox1.Visible = textBox1.Visible = textBox2.Visible = textBox3.Visible = button2.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private string ImageToBase64(string imagePath)
        {
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, (int)fileStream.Length);
                return Convert.ToBase64String(bytes);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                    // Convert the image to Base64 and store it in the variable
                    base64Image = ImageToBase64(openFileDialog.FileName);

                    Console.WriteLine(base64Image);

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void del_user_Click(object sender, EventArgs e)
        {
            string name = comboBox2.SelectedItem.ToString();
            Program.connection.Open();
            string query = "DELETE FROM users WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.ExecuteNonQuery();
            Program.connection.Close();
            comboBox2.Items.Remove(comboBox2.SelectedItem.ToString());
        }

        private void Edit_user_btn_Click(object sender, EventArgs e)
        {
            textBox4.Visible = textBox5.Visible = textBox6.Visible = textBox7.Visible = textBox8.Visible = true;
            del_product.Visible = false;
            Edit_user.Visible = true;
            comboBox4.Visible = true;
            label11.Visible = label12.Visible = label13.Visible = label15.Visible = label17.Visible = label16.Visible = true;



            // دریافت اسم محصول
            string NameUser = comboBox2.SelectedItem.ToString();

            // اتصال به دیتابیس

            Program.connection.Open();

            // ایجاد کوئری
            var query = new SqlCommand("SELECT UserName, Roll, Name,LastName,Email,Address,Phone_Num FROM users WHERE Name = @NameUser", Program.connection);

            // قرار دادن مقادیر در کوئری
            query.Parameters.AddWithValue("@NameUser", NameUser);

            // اجرای کوئری
            var reader = query.ExecuteReader();

            // در صورت وجود نتیجه
            if (reader.Read())
            {
                string UserName = reader["UserName"].ToString();
                string Name = reader["Name"].ToString();
                string LastName = reader["LastName"].ToString();
                string Email = reader["Email"].ToString();
                string Address = reader["Address"].ToString();
                string Phone_Num = reader["Phone_Num"].ToString();
                string roll = reader["Roll"].ToString();


                textBox6.Text = Name + LastName;
                textBox5.Text = Phone_Num;
                textBox7.Text = Email;
                textBox8.Text = UserName;
                textBox4.Text = Address;
                comboBox4.SelectedText = roll;
                comboBox4.Items.Add("admin");
                comboBox4.Items.Add("user");

            }
            Program.connection.Close();
        }

        private void Edit_user_Click(object sender, EventArgs e)
        {

        }

        private void Edit_user_Click_1(object sender, EventArgs e)
        {

            // دریافت اطلاعات محصول
            string Phone_Num = textBox5.Text;
            string Email = textBox7.Text;
            string UserName = textBox8.Text;
            string Address = textBox4.Text;
            string roll = comboBox4.SelectedItem.ToString();

            // اتصال به دیتابیس

            Program.connection.Open();

            // ایجاد کوئری
            var query1 = new SqlCommand("UPDATE users SET Phone_Num = @Phone_Num, Email = @Email, UserName = @UserName, Address = @Address, Roll = @roll WHERE Name = @Name", Program.connection);

            // قرار دادن مقادیر در کوئری
            query1.Parameters.AddWithValue("@Name", comboBox2.SelectedItem.ToString());
            query1.Parameters.AddWithValue("@Phone_Num", Phone_Num);
            query1.Parameters.AddWithValue("@Email", Email);
            query1.Parameters.AddWithValue("@UserName", UserName);
            query1.Parameters.AddWithValue("@Address", Address);
            query1.Parameters.AddWithValue("@roll", roll);

            // اجرای کوئری
            query1.ExecuteNonQuery();

            Program.connection.Close();

            textBox4.Visible = textBox5.Visible = textBox6.Visible = textBox7.Visible = textBox8.Visible = false;
            del_product.Visible = true;
            Edit_user.Visible = false;
            comboBox4.Visible = false;
            label11.Visible = label12.Visible = label13.Visible = label15.Visible = label17.Visible = label16.Visible = false;

        }

    }
}
