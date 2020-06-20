namespace Yurt_Otomasyonu
{
    partial class OdaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odalarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            //this.yurt_OtomasyonuDataSet2 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet2();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtDataSet1 = new Yurt_Otomasyonu.YurtDataSet1();
            this.odalarTableAdapter = new Yurt_Otomasyonu.YurtDataSet1TableAdapters.OdalarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            //this.yurt_OtomasyonuDataSet = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet();
            this.odalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.odalarTableAdapter1 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSetTableAdapters.OdalarTableAdapter();
            //this.yurt_OtomasyonuDataSet1 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet1();
            this.odalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            //this.odalarTableAdapter2 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet1TableAdapters.OdalarTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            //this.odalarTableAdapter3 = new Yurt_Otomasyonu.Yurt_OtomasyonuDataSet2TableAdapters.OdalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource3)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtDataSet1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 188);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odalarBindingSource3
            // 
            this.odalarBindingSource3.DataMember = "Odalar";
            //this.odalarBindingSource3.DataSource = this.yurt_OtomasyonuDataSet2;
            // 
            // yurt_OtomasyonuDataSet2
            // 
            //this.yurt_OtomasyonuDataSet2.DataSetName = "Yurt_OtomasyonuDataSet2";
            //this.yurt_OtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.yurtDataSet1;
            // 
            // yurtDataSet1
            // 
            this.yurtDataSet1.DataSetName = "YurtDataSet1";
            this.yurtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(29, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(205, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(389, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sil";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Oda No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kapasite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mevcut Kişi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(254, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Oda Ücreti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(238, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Oda Özellikleri:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(321, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 119);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // yurt_OtomasyonuDataSet
            // 
            //this.yurt_OtomasyonuDataSet.DataSetName = "Yurt_OtomasyonuDataSet";
            //this.yurt_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource1
            // 
            this.odalarBindingSource1.DataMember = "Odalar";
            //this.odalarBindingSource1.DataSource = this.yurt_OtomasyonuDataSet;
            // 
            // odalarTableAdapter1
            // 
            //this.odalarTableAdapter1.ClearBeforeFill = true;
            // 
            // yurt_OtomasyonuDataSet1
            // 
            //this.yurt_OtomasyonuDataSet1.DataSetName = "Yurt_OtomasyonuDataSet1";
            //this.yurt_OtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource2
            // 
            this.odalarBindingSource2.DataMember = "Odalar";
            //this.odalarBindingSource2.DataSource = this.yurt_OtomasyonuDataSet1;
            // 
            // odalarTableAdapter2
            // 
            //this.odalarTableAdapter2.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "2400",
            "2500",
            "2600",
            "2700",
            "2800",
            "2900",
            "3000",
            "3100",
            "3200",
            "3300",
            "3400",
            "3500"});
            this.comboBox2.Location = new System.Drawing.Point(321, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // odalarTableAdapter3
            // 
            //this.odalarTableAdapter3.ClearBeforeFill = true;
            // 
            // OdaIslemleri
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 428);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaIslemleri";
            this.Text = "Oda İşlemleri";
            this.Load += new System.EventHandler(this.TümOdalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource3)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtDataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.yurt_OtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtDataSet1 yurtDataSet1;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private YurtDataSet1TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        //private Yurt_OtomasyonuDataSet yurt_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource1;
        //private Yurt_OtomasyonuDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter1;
        //private Yurt_OtomasyonuDataSet1 yurt_OtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource odalarBindingSource2;
        //private Yurt_OtomasyonuDataSet1TableAdapters.OdalarTableAdapter odalarTableAdapter2;
        private System.Windows.Forms.ComboBox comboBox2;
        //private Yurt_OtomasyonuDataSet2 yurt_OtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource odalarBindingSource3;
        //private Yurt_OtomasyonuDataSet2TableAdapters.OdalarTableAdapter odalarTableAdapter3;
    }
}