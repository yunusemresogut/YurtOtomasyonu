using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Otomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mevcutİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mevcutİslemler frm = new Mevcutİslemler();
            frm.Show();
            frm.Location = new Point(0, 0);
            
        }

        private void işlemEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yenislem frm = new Yenislem();
            frm.Show();
        }

        private void tümİzinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tümİzinler frm = new Tümİzinler();
            frm.Show();
        }

        private void izinİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yeni_İzin frm = new Yeni_İzin();
            frm.Show();
        }

        private void tümÖğrecilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TümÖğrenciler frm = new TümÖğrenciler();
            frm.Show();
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ögrenciİslemleri frm = new Ögrenciİslemleri();
            frm.Show();
        }

        private void mevcutOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaIslemleri frm = new OdaIslemleri();
            frm.Show();
        }

        private void odaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tümÖdemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ödemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeIslemleri frm = new OdemeIslemleri();
            frm.Show();
        }

        private void ödenenTaksitlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taksitler frm = new Taksitler();
            frm.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreIslemleri frm = new SifreIslemleri();
            frm.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2019 Tüm Hakları Saklıdır. \n\n✓ Yunus Emre SÖĞÜT tarafından tasarlanmıştır. \n✉ İletişim: yunusesogut@gmail.com ", "HAKKIMIZDA", MessageBoxButtons.OK,MessageBoxIcon.Information  );
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            //progressBarLogin.Maximum = 100;
            //progressBarLogin.Minimum = 0;
        }

        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ÖğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KolayErişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }

        private void WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
        }

        private void ExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ASDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://yurtkur.gsb.gov.tr/");
        }
    }
}
