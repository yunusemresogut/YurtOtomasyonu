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
    public partial class Taksitler : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L01MAVE;Initial Catalog='YurtOtomasyonu';Integrated Security=True");

        public Taksitler()
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

        private void Taksitler_Load(object sender, EventArgs e)
        {
          

            VerileriGoster(@"SELECT   dbo.Öğrenci.Ogrenci_Isim, dbo.Odalar.Oda_No,  dbo.Ödemeler.Ödenen_Ay, dbo.Ödemeler.Toplam_Borç
                        FROM         dbo.Ödemeler INNER JOIN
                      dbo.Öğrenci ON dbo.Ödemeler.ÖğrenciID = dbo.Öğrenci.ÖğrenciID INNER JOIN
                      dbo.Odalar ON dbo.Ödemeler.OdaID = dbo.Odalar.OdaID  ORDER BY Ogrenci_Isim ,Ödenen_Ay ASC ");
        }
    
       
    }
    }

