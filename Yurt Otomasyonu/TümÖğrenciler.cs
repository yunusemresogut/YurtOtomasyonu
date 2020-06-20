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
    public partial class TümÖğrenciler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");

        public TümÖğrenciler()
        {
            InitializeComponent();
        }
        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }
        private void TümÖğrenciler_Load(object sender, EventArgs e)
        {
            VerileriGoster("Select Ogrenci_Isim,Ogrenci_TC,Ogrenci_Telefon,Dogum_Yeri,Dogum_Tarihi,Veli_İsmi,Veli_Telefonu,Veli_Adres from Öğrenci ORDER BY Ogrenci_Isim ASC ");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand tumOgr = new SqlCommand("SELECT COUNT(Ogrenci_Isim) from Öğrenci", baglanti);
            SqlDataReader oku = tumOgr.ExecuteReader();
            while (oku.Read())
            {
                label2.Text = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
