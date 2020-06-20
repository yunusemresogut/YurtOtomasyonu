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
    public partial class Ögrenciİslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");

        public Ögrenciİslemleri()
        {
            InitializeComponent();
        }


        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Ögrenciİslemleri_Load(object sender, EventArgs e)
        {
            VerileriGoster("Select Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci ORDER BY Ogrenci_Isim ASC");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Öğrenci(Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres) " +
                    "values(@Öisim,@ÖTC,@ÖTelefon,@DogumYeri,@DogumTarihi,@Visim,@VTelefon,@Adres) ", baglanti);
                cmd.Parameters.AddWithValue("@Öisim", textBox2.Text);
                cmd.Parameters.AddWithValue("@ÖTC", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@ÖTelefon", maskedTextBox3.Text);
                cmd.Parameters.AddWithValue("@DogumYeri", textBox5.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Visim", textBox6.Text);
                cmd.Parameters.AddWithValue("@VTelefon", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@Adres", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci ORDER BY Ogrenci_Isim ASC");
                baglanti.Close();
                MessageBox.Show("Öğrenci Eklendi", "MESAJ");
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "!! UYARI !!");
            }       

            textBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = null;
            textBox6.Clear();
            maskedTextBox2.Clear();
            richTextBox1.Text = null;
            textBox2.Focus();

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();          
            textBox5.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update Öğrenci set Ogrenci_Isim='" + textBox2.Text + "', Ogrenci_Telefon='" + maskedTextBox3.Text + "', Dogum_Yeri='" + textBox5.Text + "', Dogum_Tarihi='" + dateTimePicker1.Text + "',Veli_İsmi='" + textBox6.Text + "',Veli_Telefonu='" + maskedTextBox2.Text + "',Veli_Adres='" + richTextBox1.Text + "'  where Ogrenci_TC='" + maskedTextBox1.Text + "' ", baglanti);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci ORDER BY Ogrenci_Isim ASC");
                baglanti.Close();
                MessageBox.Show("Öğrenci Güncellendi.", "MESAJ");
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "!! UYARI !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "MESAJ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Öğrenci where Ogrenci_TC=@TC", baglanti);
                cmd.Parameters.AddWithValue("@TC", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci ORDER BY Ogrenci_Isim ASC");
                baglanti.Close();
                MessageBox.Show("Öğrenci Silindi. Lütfen Oda İşlemlerinden Öğrencinin Bulunduğu Odanın Mevcut Kişi Sayısını Güncelleyiniz.", "MESAJ",MessageBoxButtons.OK);

               

                textBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                dateTimePicker1.Text = null;
                textBox6.Clear();
                maskedTextBox2.Clear();
                richTextBox1.Text = null;
                textBox2.Focus();
            }
            else if(secenek== DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.", "MESAJ");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "Select Ogrenci_Isim,Ogrenci_Telefon,Ogrenci_TC,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci where Ogrenci_Isim Like '" + textBox8.Text + "%'";
            SqlDataAdapter dp = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            dp.Fill(ds, "Öğrenci");
            this.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select Ogrenci_Isim,Ogrenci_Telefon,Ogrenci_TC,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci where Ogrenci_TC Like '" + textBox1.Text + "%'";
            SqlDataAdapter dp = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            dp.Fill(ds, "Öğrenci");
            this.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = null;
            textBox6.Clear();
            maskedTextBox2.Clear();
            richTextBox1.Text = null;
            textBox2.Focus();
        }
    }
}