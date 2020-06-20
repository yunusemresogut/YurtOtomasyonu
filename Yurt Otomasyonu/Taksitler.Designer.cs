namespace Yurt_Otomasyonu
{
    partial class Taksitler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taksitler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borçlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.yurt_OtomasyonuDataSet17 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet17();
            this.ödemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.yurt_OtomasyonuDataSet8 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet8();
            //this.ödemelerTableAdapter = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet8TableAdapters.ÖdemelerTableAdapter();
            //this.borçlarTableAdapter = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet17TableAdapters.BorçlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borçlarBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödemelerBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // borçlarBindingSource
            // 
            this.borçlarBindingSource.DataMember = "Borçlar";
            //this.borçlarBindingSource.DataSource = this.yurt_OtomasyonuDataSet17;
            // 
            // yurt_OtomasyonuDataSet17
            // 
            //this.yurt_OtomasyonuDataSet17.DataSetName = "Yurt_OtomasyonuDataSet17";
            //this.yurt_OtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ödemelerBindingSource
            // 
            this.ödemelerBindingSource.DataMember = "Ödemeler";
            //this.ödemelerBindingSource.DataSource = this.yurt_OtomasyonuDataSet8;
            // 
            // yurt_OtomasyonuDataSet8
            // 
            //this.yurt_OtomasyonuDataSet8.DataSetName = "Yurt_OtomasyonuDataSet8";
            //this.yurt_OtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ödemelerTableAdapter
            // 
            //this.ödemelerTableAdapter.ClearBeforeFill = true;
            // 
            // borçlarTableAdapter
            // 
            //this.borçlarTableAdapter.ClearBeforeFill = true;
            // 
            // Taksitler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(445, 406);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Taksitler";
            this.Text = "Taksitler";
            this.Load += new System.EventHandler(this.Taksitler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borçlarBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ödemelerBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private Yurt_OtomasyonuDataSet8 yurt_OtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource ödemelerBindingSource;
        //private Yurt_OtomasyonuDataSet8TableAdapters.ÖdemelerTableAdapter ödemelerTableAdapter;
        //private Yurt_OtomasyonuDataSet17 yurt_OtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource borçlarBindingSource;
        //private Yurt_OtomasyonuDataSet17TableAdapters.BorçlarTableAdapter borçlarTableAdapter;
    }
}