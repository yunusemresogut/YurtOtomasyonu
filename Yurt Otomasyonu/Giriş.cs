using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurt_Otomasyonu
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
                SqlCommand cmd = new SqlCommand("select Yönetici_Adi,Yönetici_Sİfre from Yönetici where Yönetici_Adi=@Adı and Yönetici_Sİfre=@Sifre ", baglanti);
                cmd.Parameters.AddWithValue("@Adı", textBox1.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //timer2.Start();
                //label2.Visible = true;
                //label4.Visible = true;
                //progressBarLogin.Visible = true;
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "UYARI!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
                baglanti.Close();        
            
            }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarLogin.Maximum = 100;
            progressBarLogin.Minimum = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreIslemleri frm = new SifreIslemleri();
            frm.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\osk.exe");

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Kullanıcı Adı")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = Color.Blue;
            //}
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "Kullanıcı Adı";
            //    textBox1.ForeColor = Color.White;
            //}
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Şifre")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = Color.Blue;
            //}
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "Şifre";
            //    textBox1.ForeColor = Color.White;
            //}
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void TextBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
        }

        private void TextBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //progressBarLogin.Increment(1);
            //label4.Text = progressBarLogin.Value.ToString() + "%";
            //if (progressBarLogin.Value < 100)
            //{
            //    progressBarLogin.Value += 1;
            //}
            //else
            //{
            //    timer2.Stop();
            //    //Burada progressbar tamamen dolmuş oluyor, istediğiniz işlemi yapın
            //}
        }
    }
}
