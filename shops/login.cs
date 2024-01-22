using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shops.Controls;


namespace shops
{


    public partial class login : Form

    {

        Form paneladmin = new paneladmin();
        Form HomePage = new HomePage();
        Form respass = new ResetPass();
        Form register = new register();
        bool login_otp = false;

        string code;
        public login()
        {
           
            InitializeComponent();

        }
        public string getmyusername()
        {
            return textBox1.Text;

        }




        private string GetUserPassRoll(string username, string password)
        {
            Program.connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", Program.connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Program.connection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString() == username &&
                    dr[2].ToString() == password)
                    return dr[3].ToString();
            }

            return "";
        }
        public void button1_Click(object sender, EventArgs e)
        {
            
            // دریافت یوزنیم و پسورد از فرم
            string username = textBox1.Text;
            string password = textBox2.Text;
            getmyusername();
            if (login_otp == false)
            {


                string roll = GetUserPassRoll(username, password);

                // بررسی نتیجه
                if (roll != "")
                {

                    // لاگین موفقیت‌آمیز
                    if(roll == "admin") {
                        paneladmin sp = new paneladmin(username);
                        sp.ShowDialog();


                    }
                    else
                    {

                        HomePage.Show();
                        this.Hide();
                    }
                }

                else
                {
                    // لاگین ناموفق
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
                }
                // بستن اتصال به دیتابیس
            }
            else
            {


                // اتصال به دیتابیس

                Program.connection.Open();

                // اجرای کوئری برای چک کردن یوزنیم و پسورد
                string query = "SELECT* FROM Users WHERE Username = @username ";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@username", username);


                // اجرای کوئری و دریافت نتیجه
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                string us = reader["UserName"].ToString();
                string roll = reader["Roll"].ToString();
                // بررسی نتیجه
                if (us == username && login_otp == true && code == password)
                {

                    // لاگین موفقیت‌آمیز
                    if (roll == "admin")
                    {

                        paneladmin sp = new paneladmin(username);
                        sp.ShowDialog();
                        paneladmin.Show();


                    }
                    else
                    {

                        HomePage.Show();
                        this.Hide();
                    }


                }
                else
                {
                    // لاگین ناموفق
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
                }
                // بستن اتصال به دیتابیس
                Program.connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            respass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            register.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {


        }
        public static string GenerateOtp(int x)
        {

            // ایجاد یک تولیدکننده اعداد تصادفی
            Random random = new Random();

            // تولید یک عدد تصادفی بین 0 و 9999
            int password = random.Next(10000);

            
            string passwordString = password.ToString();

            while (passwordString.Length < x)
            {
                passwordString = "0" + passwordString;
            }

            return passwordString;
        }


        private void button4_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;


            // اتصال به دیتابیس

            Program.connection.Open();

            // اجرای کوئری برای چک کردن یوزنیم و پسورد
            string query = "SELECT* FROM Users WHERE Username = @username ";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@username", username);


            // اجرای کوئری و دریافت نتیجه
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string Phone_num = reader["Phone_Num"].ToString();

            // بستن اتصال به دیتابیس
            Program.connection.Close();



            code = GenerateOtp(4);
            // ساخت یک httpclient
            HttpClient client = new HttpClient();

            // تنظیم کردن لینک درخواست
            string url = "https://mahdizangoei.ir/api/send-sms.php?code="+code+"&to="+ Phone_num + "&pid=lcz40t6ca7wem8c&type=send";


            // ارسال درخواست
            HttpResponseMessage response = client.GetAsync(url).Result;

            // برسی وضعیت درخواست
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // درخواست موفقیت امیز بود
                MessageBox.Show("رمز یکبار مصرف برای شما ارسال شد \n لطفا در باکس بالا وارد کنید.");

                label2.Text = "کد ارسال شده";
                login_otp = true;
            }
            else
            {
                // درخواست رد شد
                MessageBox.Show("مشکلی پیش امده است ما نتوانستیم برای شما کد را پیامک کنیم لطفا از رمز عبور خود استفاده کنید و یا از طریق گزینه فراموشی رمز عبور با استفاده از ایمیل خود رمز عبور خود را تغییر دهید.");

            }
        }
    }
}
