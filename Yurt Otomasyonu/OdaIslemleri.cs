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

    public partial class OdaIslemleri : Form
    {
        public OdaIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");


        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        } 


        private void TümOdalar_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            VerileriGoster("Select Oda_No,Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri from Odalar ORDER BY Oda_No ASC ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Odalar(Oda_No,Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri) values(@No,@Kapasite,@KisiSayisi,@Ucret,@Ozellik) ", baglanti);
                cmd.Parameters.AddWithValue("@No", textBox2.Text);
                cmd.Parameters.AddWithValue("@Kapasite", textBox3.Text);
                cmd.Parameters.AddWithValue("@KisiSayisi", textBox4.Text);
                cmd.Parameters.AddWithValue("@Ucret", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Ozellik", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select OdaID,Oda_No,Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri from Odalar ORDER BY Oda_No ASC ");
                baglanti.Close();
                MessageBox.Show("Oda Eklendi", "MESAJ");
            }

            catch(Exception)
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "!! UYARI !!");
            }
          
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox2.Text=null;
            richTextBox1.Text = null;
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update Odalar set Kapasite='" + textBox3.Text + "', Kişi_Sayısı='" + textBox4.Text + "', Oda_Ücreti='" + comboBox2.Text + "', Oda_Özellikleri='" + richTextBox1.Text + "' where Oda_No='" + textBox2.Text + "' ", baglanti);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Oda_No,Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri from Odalar ORDER BY Oda_No ASC ");
                baglanti.Close();
                MessageBox.Show("Oda Güncellendi", "BİLGİLENDİRME");
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "!! UYARI !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult scnk = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "MESAJ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (scnk == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Odalar where Oda_No=@no", baglanti);
                cmd.Parameters.AddWithValue("@no", textBox2.Text);
                cmd.ExecuteNonQuery();
                VerileriGoster("Select Oda_No,Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri from Odalar ORDER BY Oda_No ASC ");
                baglanti.Close();
                MessageBox.Show("Oda Silindi", "BİLGİLENDİRME");

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox2.Text = null;
                richTextBox1.Text = null;
                textBox2.Focus();
            }
           else if(scnk==DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "MESAJ");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
