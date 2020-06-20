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
    public partial class OdemeIslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");


        public OdemeIslemleri()
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

        private void OdemeIslemleri_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            baglanti.Open();
            {
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT ÖğrenciID,Ogrenci_Isim FROM Öğrenci", baglanti))
                    da.Fill(table);
            }
            listBox1.DataSource = new BindingSource(table, null);
            listBox1.ValueMember = "ÖğrenciID";
            listBox1.DisplayMember = "Ogrenci_Isim";
            
            baglanti.Close();

           

            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select OdaID,Oda_No from Odalar", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox3.DataSource = dt2;
            comboBox3.ValueMember = "OdaID";
            comboBox3.DisplayMember = "Oda_No";
            baglanti.Close();


            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.Ödemeler.Ödenen_Ay, dbo.İşlemler.Toplam_Borç
                       FROM         dbo.Ödemeler INNER JOIN
                      dbo.Öğrenci ON dbo.Ödemeler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.Ödemeler.OdaID = dbo.Odalar.OdaID INNER JOIN
                      dbo.İşlemler ON dbo.Öğrenci.ÖğrenciID = dbo.İşlemler.ÖğrenciID ORDER BY Ogrenci_Isim ,Ödenen_Ay ASC ");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string  isim,oda, ay, ödenen ;
            isim = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            oda = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ay = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ödenen = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
          
            listBox1.Text = isim;
            comboBox3.Text = oda;
            dateTimePicker1.Text = ay;
            textBox1.Text = ödenen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBox1.Text);
            kalan = Convert.ToInt16(textBox3.Text);
            yeniborc = kalan - odenen;
            textBox3.Text = yeniborc.ToString();


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Ödemeler(ÖğrenciID,OdaID,Ödenen_Ay,Toplam_Borç) values(@Öisim,@Oda,@OdenenAy,@Toplam) ", baglanti);
            cmd.Parameters.AddWithValue("@Öisim", listBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@Oda", comboBox3.SelectedValue);
            cmd.Parameters.AddWithValue("@OdenenAy", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Toplam", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ödeme Alındı", "MESAJ");

            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No,  dbo.Ödemeler.Ödenen_Ay, dbo.Ödemeler.Toplam_Borç
                        FROM         dbo.Ödemeler INNER JOIN
                      dbo.Öğrenci ON dbo.Ödemeler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.Ödemeler.OdaID = dbo.Odalar.OdaID  ORDER BY Ogrenci_Isim ,Ödenen_Ay ASC ");

            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("update İşlemler set Toplam_Borç='"+ textBox3.Text + "' where ÖğrenciID='" + listBox1.SelectedValue + "'  ", baglanti);
            cmd2.ExecuteNonQuery();
            baglanti.Close();


            listBox1.Text = null;
            comboBox3.Text = null;
            dateTimePicker1.Text = null;
            textBox3.Clear();
            textBox1.Clear();
            listBox1.Focus();
          
        }

     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
            baglanti.Open();
            string sorgu = " select Ogrenci_TC,Ogrenci_Telefon,Veli_İsmi,Veli_Telefonu from Öğrenci where Ogrenci_Isim='" + listBox1.Text + "'   ";
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
