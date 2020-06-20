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
    public partial class Yenislem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");

        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        } 

        public Yenislem()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int kap = Convert.ToInt32(textBox9.Text);
            int mevcut = Convert.ToInt32(textBox8.Text);
            if (mevcut < kap)
            { 
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into İşlemler(ÖğrenciID,OdaID,Giriş_Tarihi,Çıkış_Tarihi,Toplam_Borç,Peşinat,Toplam_Süre) values(@ÖğrenciID,@OdaID,@Giris,@CIkıs,@Borc,@Pesinat,@Sure)", baglanti);
                cmd.Parameters.AddWithValue("@ÖğrenciID", listBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@OdaID", listBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@Giris", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@CIkıs", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@Borc", textBox1.Text);
                cmd.Parameters.AddWithValue("@Pesinat", textBox2.Text);
                cmd.Parameters.AddWithValue("@Sure", comboBox3.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                VerileriGoster(@"select dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İşlemler.Giriş_Tarihi, dbo.İşlemler.Çıkış_Tarihi, dbo.İşlemler.Toplam_Borç, dbo.İşlemler.Peşinat, dbo.İşlemler.Toplam_Süre
                                 FROM  dbo.İşlemler INNER JOIN
                             dbo.Odalar ON dbo.İşlemler.OdaID = dbo.Odalar.OdaID INNER JOIN
                              dbo.Öğrenci ON dbo.İşlemler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID ORDER BY Oda_No ASC ");
                baglanti.Close();
                MessageBox.Show("İşlem Eklendi", "MESAJ");
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz.", "!! UYARI !!");
            }
                


                baglanti.Open();
                SqlCommand komutoda = new SqlCommand("UPDATE Odalar SET Kişi_Sayısı=Kişi_Sayısı+1 WHERE Oda_No=@Oda", baglanti);              
                komutoda.Parameters.AddWithValue("@Oda", listBox2.Text);
                komutoda.ExecuteNonQuery();
                baglanti.Close();

                listBox1.Text = null;
                listBox2.Text = null;
                dateTimePicker1.Text = null;
                dateTimePicker2.Text = null;
                textBox1.Clear();
                textBox2.Clear();
                comboBox3.Text = null;
                listBox1.Focus();

            }
            else
            {
                MessageBox.Show("Oda Kapasitesi Dolu. Lütfen Boş Oda Seçiniz.","!! UYARI !!");
            }


        }

    
        private void Yenislem_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            {
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT ÖğrenciID,Ogrenci_Isim FROM Öğrenci", baglanti))
                    da.Fill(table);
            }
            listBox1.DataSource = new BindingSource(table, null);
            listBox1.DisplayMember = "Ogrenci_Isim";
            listBox1.ValueMember = "ÖğrenciID";
            baglanti.Close();


            


            DataTable table1 = new DataTable();
            baglanti.Open();
            {
                using (SqlDataAdapter da1 = new SqlDataAdapter(@"SELECT OdaID,Oda_No FROM Odalar", baglanti))
                    da1.Fill(table1);
            }
            listBox2.DataSource = new BindingSource(table1, null);
            listBox2.ValueMember = "OdaID";
            listBox2.DisplayMember = "Oda_No";         
            baglanti.Close();

            


            VerileriGoster(@" select dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İşlemler.Giriş_Tarihi, dbo.İşlemler.Çıkış_Tarihi, dbo.İşlemler.Toplam_Borç, dbo.İşlemler.Peşinat, dbo.İşlemler.Toplam_Süre
                                 FROM  dbo.İşlemler INNER JOIN
                             dbo.Odalar ON dbo.İşlemler.OdaID = dbo.Odalar.OdaID INNER JOIN
                              dbo.Öğrenci ON dbo.İşlemler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID ORDER BY Oda_No ASC ");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update İşlemler set OdaID='" + listBox2.SelectedValue+ "',Giriş_Tarihi='" + dateTimePicker1.Text+ "',Çıkış_Tarihi='" + dateTimePicker2.Text + "',  Toplam_Borç='" + textBox1.Text + "', Peşinat='" + textBox2.Text + "' ,Toplam_Süre='" + comboBox3.Text+ "' where ÖğrenciID='" + listBox1.SelectedValue + "' ", baglanti);
            cmd.ExecuteNonQuery();
            VerileriGoster(@" select dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İşlemler.Giriş_Tarihi, dbo.İşlemler.Çıkış_Tarihi, dbo.İşlemler.Toplam_Borç, dbo.İşlemler.Peşinat, dbo.İşlemler.Toplam_Süre
                                 FROM  dbo.İşlemler INNER JOIN
                             dbo.Odalar ON dbo.İşlemler.OdaID = dbo.Odalar.OdaID INNER JOIN
                              dbo.Öğrenci ON dbo.İşlemler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID ORDER BY Oda_No ASC ");
            baglanti.Close();
            MessageBox.Show("İşlem Güncellendi", "BİLGİLENDİRME");
        }

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            listBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            listBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();       
            textBox2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sck = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "!! UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sck == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from İşlemler where ÖğrenciID=@ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", listBox1.SelectedValue);
                cmd.ExecuteNonQuery();
                VerileriGoster(@" select dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İşlemler.Giriş_Tarihi, dbo.İşlemler.Çıkış_Tarihi, dbo.İşlemler.Toplam_Borç, dbo.İşlemler.Peşinat, dbo.İşlemler.Toplam_Süre
                                 FROM  dbo.İşlemler INNER JOIN
                             dbo.Odalar ON dbo.İşlemler.OdaID = dbo.Odalar.OdaID INNER JOIN
                              dbo.Öğrenci ON dbo.İşlemler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID ORDER BY Oda_No ASC ");
                baglanti.Close();
                MessageBox.Show("İşlem Silindi", "BİLGİLENDİRME");

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("UPDATE Odalar SET Kişi_Sayısı=Kişi_Sayısı-1 WHERE Oda_No=@Oda", baglanti);
                komut3.Parameters.AddWithValue("@Oda", listBox2.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                listBox1.Text = null;
                listBox2.Text = null;
                dateTimePicker1.Text = null;
                dateTimePicker2.Text = null;
                textBox1.Clear();
                textBox2.Clear();
                comboBox3.Text = null;
                listBox1.Focus();
            }
          else if(sck== DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "MESAJ");
            }

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam, pesinat, yeniborc;
            toplam = Convert.ToInt16(textBox1.Text);
            pesinat = Convert.ToInt16(textBox2.Text);
            yeniborc = toplam - pesinat;
            textBox1.Text = yeniborc.ToString();
            textBox2.Text = pesinat.ToString();
        }

    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
            baglanti.Open();
            string sorgu = " select Ogrenci_TC,Ogrenci_Telefon,Veli_İsmi,Veli_Telefonu from Öğrenci where Ogrenci_Isim='" + listBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {       
                string sTC = dr.GetString(0);
                string sTlf = dr.GetString(1);
                string sVeli = dr.GetString(2);
                string sVTlf = dr.GetString(3);

                textBox4.Text = sTC;
                maskedTextBox1.Text = sTlf;
                textBox6.Text = sVeli;
                maskedTextBox2.Text = sVTlf;
            }
            baglanti.Close();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
            baglanti.Open();
            SqlCommand cmd = baglanti.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Kapasite,Kişi_Sayısı,Oda_Ücreti,Oda_Özellikleri from Odalar where Oda_No='" + listBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);
            foreach (DataRow da in dt.Rows)
            {
                textBox9.Text = da["Kapasite"].ToString();
                textBox8.Text = da["Kişi_Sayısı"].ToString();
                textBox7.Text = da["Oda_Ücreti"].ToString();
                richTextBox1.Text = da["Oda_Özellikleri"].ToString();
            }

            baglanti.Close();


            
        }

        private void MaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
