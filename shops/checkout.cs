using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;

using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using shops;
using Microsoft.Identity.Client.NativeInterop;
using System.Net.Http;

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
                    label4.Text = Price + "تومان";
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
            int price = int.Parse(label2.Text);
            int totall = int.Parse(textBox2.Text);

            int sum = price * totall;

            label4.Text = sum + "تومان";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = label1.Text;
            int price = int.Parse(label2.Text);
            int totall = int.Parse(textBox2.Text);
            int sum = price * totall;
            string address = richTextBox2.Text;
            string num = textBox1.Text;




            string text = $@"سلام

فاکتور خرید شما به شرح زیر میباشد:
نام کالا :‌ {name}
قیمت خرید : {price.ToString()} 
تعداد : {totall.ToString()} 
جمع کل :‌ {sum.ToString()} 


آدرس :‌ {address}
شماره تماس :‌ {num}

وضعیت :‌پرداخت شده";


            // ساخت یک httpclient
            HttpClient client = new HttpClient();
            string subemail = "فاکتور پرداخت مشتری";
            // تنظیم کردن لینک درخواست
            string url = $"https://mahdizangoei.ir/api/send-email.php?to_email=mahdizangoei1@gmail.com&email_subject={subemail}&text_email={text}";


            // ارسال درخواست
            HttpResponseMessage response = client.GetAsync(url).Result;

            // برسی وضعیت درخواست
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // دریافت ادرس دسکتاپ
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // ساخت یک فایل txt در دسکتاپ
                StreamWriter writer = new StreamWriter(Path.Combine(desktopPath, "output.txt"));

                // نوشتن در فایل
                writer.Write(text);

                // بستن فایل
                writer.Close();

                MessageBox.Show("فاکتور در دسکتاپ شما ذخیره شد.");

                this.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

