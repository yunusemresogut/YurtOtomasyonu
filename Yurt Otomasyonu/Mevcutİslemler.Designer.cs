namespace Yurt_Otomasyonu
{
    partial class Mevcutİslemler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mevcutİslemler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.işlemlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.yurt_OtomasyonuDataSet9 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet9();
            //this.İşlemlerTableAdapter = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet9TableAdapters.İşlemlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.işlemlerBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // işlemlerBindingSource
            // 
            this.işlemlerBindingSource.DataMember = "İşlemler";
            //this.işlemlerBindingSource.DataSource = this.yurt_OtomasyonuDataSet9;
            // 
            // yurt_OtomasyonuDataSet9
            // 
            //this.yurt_OtomasyonuDataSet9.DataSetName = "Yurt_OtomasyonuDataSet9";
            //this.yurt_OtomasyonuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // İşlemlerTableAdapter
            // 
            //this.İşlemlerTableAdapter.ClearBeforeFill = true;
            // 
            // Mevcutİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 385);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mevcutİslemler";
            this.Text = "Tüm İşlemler";
            this.Load += new System.EventHandler(this.Mevcutİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.işlemlerBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private Yurt_OtomasyonuDataSet9 yurt_OtomasyonuDataSet9;
        private System.Windows.Forms.BindingSource işlemlerBindingSource;
        //private Yurt_OtomasyonuDataSet9TableAdapters.İşlemlerTableAdapter İşlemlerTableAdapter;
    }
}