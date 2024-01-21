using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace shops
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Password_Generator = GenerateOtp(6);
            string name = textBox1.Text;
            string last = textBox2.Text;
            string Email = textBox3.Text;
            string username = textBox4.Text;
            string Address = textBox5.Text;
            string Password = Password_Generator;
            string Num = textBox6.Text;
            string roll = "user";

            Program.connection.Open();
            string query = "INSERT INTO Users (UserName,Password,Roll,Name,LastName,Email,Address,Phone_Num)" +
             " VALUES('" + username + "',' " + Password + "',' " + roll + "',' " + name + "',' " + last + "',' " + Email + "', '" + Address + "' , '" + Num + "')";

            SqlCommand command = new SqlCommand(query, Program.connection);
            command.ExecuteNonQuery();
            Program.connection.Close();
            this.Hide();





            
            // ساخت یک httpclient
            HttpClient client = new HttpClient();

            // تنظیم کردن لینک درخواست
            string url = "https://mahdizangoei.ir/api/send-sms.php?code=" + Password_Generator + "&to=" + Num + "&pid=lcz40t6ca7wem8c&type=sendd";


            // ارسال درخواست
            HttpResponseMessage response = client.GetAsync(url).Result;

            // برسی وضعیت درخواست
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // درخواست موفقیت امیز بود
                MessageBox.Show($"رمز عبور شما برای شما پیامک شد \n رمز شما: {Password_Generator}");

            }
            else
            {
                // درخواست رد شد
                MessageBox.Show($"نتوانستیم رمز را برای شما پیامک کنیم. \nرمز عبور شما: {Password_Generator}");
            }


        }
        public static string GenerateOtp(int x)
        {

            // Create a random number generator
            Random random = new Random();

            // Generate a random number between 0 and 9999
            int password = random.Next(10000);

            // Convert the number to a 4-digit string
            string passwordString = password.ToString();

            // Pad the string with zeros to make it 4 digits long
            while (passwordString.Length < x)
            {
                passwordString = "0" + passwordString;
            }

            // Return the password
            return passwordString;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
