using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace shops
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // دریافت یوزرنیم از کاربر
            string username = textBox1.Text;
            //متن ارسال ایمیل
            string text_resetpass = "تست متن بازیابی رمز عبور.";

            //تولید پسورد




            // اتصال به دیتابیس

            Program.connection.Open();

            // اجرای کوئری برای چک کردن یوزنیم و پسورد
            string query = "SELECT Email FROM Users WHERE Username = @username";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@username", username);



            // اجرای کوئری و دریافت نتیجه
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string Email_add = reader["Email"].ToString();

            //بستن اتصال
            Program.connection.Close();
            
            // ساخت یک httpclient
            HttpClient client = new HttpClient();

            // تنظیم کردن لینک درخواست
            string url = "https://mahdizangoei.ir/api/send-email.php?text=" + text_resetpass + "&to=" + Email_add + "&sub=بازیابی رمز عبور";




            // ارسال درخواست
            HttpResponseMessage response = client.GetAsync(url).Result;

            // برسی وضعیت درخواست
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // درخواست موفقیت امیز بود
                MessageBox.Show("The request was successful.");
            }
            else
            {
                // درخواست رد شد
                MessageBox.Show("The request failed.");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
