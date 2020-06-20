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
    public partial class Mevcutİslemler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");
        public Mevcutİslemler()
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
        private void Mevcutİslemler_Load(object sender, EventArgs e)
        {
            VerileriGoster(@" select dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No, dbo.İşlemler.Giriş_Tarihi, dbo.İşlemler.Çıkış_Tarihi, dbo.İşlemler.Toplam_Borç, dbo.İşlemler.Peşinat, dbo.İşlemler.Toplam_Süre
                                 FROM  dbo.İşlemler INNER JOIN
                             dbo.Odalar ON dbo.İşlemler.OdaID = dbo.Odalar.OdaID INNER JOIN
                              dbo.Öğrenci ON dbo.İşlemler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID ORDER BY Oda_No ASC ");


        }
    }
}
