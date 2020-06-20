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
   

    public partial class SifreIslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");

        public SifreIslemleri()
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

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;           
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Yönetici(Yönetici_Adi,Yönetici_Sİfre ) values(@Adı,@Sifre) ", baglanti);
            cmd.Parameters.AddWithValue("@Adı", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", textBox2.Text);
            cmd.ExecuteNonQuery();
            VerileriGoster("Select Yönetici_Adi,Yönetici_Sİfre from Yönetici ORDER BY Yönetici_Adi ");
            baglanti.Close();
            MessageBox.Show("Yönetici Eklendi", "MESAJ");
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand cmd = new SqlCommand("update Yönetici set Yönetici_Sİfre='" + textBox2.Text + "'where Yönetici_Adi='" + textBox1.Text + "'", baglanti);
        //    cmd.ExecuteNonQuery();
        //    VerileriGoster("Select Yönetici_Adi,Yönetici_Sİfre from Yönetici ORDER BY Yönetici_Adi ");
        //    baglanti.Close();
        //    MessageBox.Show("Yönetici Güncellendi", "MESAJ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek3 = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "!! UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek3 == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Yönetici where Yönetici_Adi=@Adi", baglanti);
                cmd.Parameters.AddWithValue("@Adi", textBox1.Text);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Yönetici_Adi,Yönetici_Sİfre from Yönetici ORDER BY Yönetici_Adi ");
                baglanti.Close();
                MessageBox.Show("Yönetici Silindi", "MESAJ");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else if(secenek3== DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "MESAJ");
            }
        }

        private void SifreIslemleri_Load(object sender, EventArgs e)
        {

            VerileriGoster("Select Yönetici_Adi,Yönetici_Sİfre from Yönetici ORDER BY Yönetici_Adi ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
