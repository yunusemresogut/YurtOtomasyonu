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
    public partial class Yeni_İzin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
        public Yeni_İzin()
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

        private void Yeni_İzin_Load(object sender, EventArgs e)
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

            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select OdaID,Oda_No from Odalar", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "OdaID";
            comboBox2.DisplayMember = "Oda_No";
            baglanti.Close();

            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İzinler.BaşlangıçTarihi, dbo.İzinler.BitişTarihi
                          FROM         dbo.İzinler INNER JOIN
                      dbo.Öğrenci ON dbo.İzinler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.İzinler.OdaID = dbo.Odalar.OdaID ORDER BY BitişTarihi DESC");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            listBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into İzinler(ÖğrenciID,OdaID,BaşlangıçTarihi,BitişTarihi) values(@Öisim,@Oda,@Başlangıç,@Bitiş) ", baglanti);
            cmd.Parameters.AddWithValue("@Öisim", listBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@Oda", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@Başlangıç", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Bitiş", dateTimePicker2.Text);
            cmd.ExecuteNonQuery();

            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İzinler.BaşlangıçTarihi, dbo.İzinler.BitişTarihi
                          FROM         dbo.İzinler INNER JOIN
                      dbo.Öğrenci ON dbo.İzinler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.İzinler.OdaID = dbo.Odalar.OdaID ORDER BY BitişTarihi DESC ");

            baglanti.Close();
            MessageBox.Show("İzin Eklendi", "MESAJ");

            listBox1.Text = null;
            comboBox2.Text = null;
            dateTimePicker1.Text = null;
            dateTimePicker2.Text = null;
            listBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update İzinler set OdaID='" + comboBox2.SelectedValue + "', BaşlangıçTarihi='" + dateTimePicker1.Text + "', BitişTarihi='"+dateTimePicker2.Text+ "' where ÖğrenciID='" + listBox1.SelectedValue + "'", baglanti);
            cmd.ExecuteNonQuery();
            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İzinler.BaşlangıçTarihi, dbo.İzinler.BitişTarihi
                          FROM         dbo.İzinler INNER JOIN
                      dbo.Öğrenci ON dbo.İzinler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.İzinler.OdaID = dbo.Odalar.OdaID ORDER BY BitişTarihi DESC ");
            baglanti.Close();
            MessageBox.Show("İzin Güncellendi", "BİLGİLENDİRME");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek2 = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "!! UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek2 == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from İzinler where ÖğrenciID=@ID", baglanti);
                cmd.Parameters.AddWithValue("@ID", listBox1.SelectedValue);
                cmd.ExecuteNonQuery();
                VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İzinler.BaşlangıçTarihi, dbo.İzinler.BitişTarihi
        q                  FROM         dbo.İzinler INNER JOIN
                      dbo.Öğrenci ON dbo.İzinler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.İzinler.OdaID = dbo.Odalar.OdaID ORDER BY BitişTarihi DESC ");
                baglanti.Close();
                MessageBox.Show("İzin Silindi", "BİLGİLENDİRME");
                listBox1.Text = null;
                comboBox2.Text = null;
                dateTimePicker1.Text = null;
                dateTimePicker2.Text = null;
                listBox1.Focus();
            }
         else if(secenek2==DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "MESAJ");
            }
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
    }
}
