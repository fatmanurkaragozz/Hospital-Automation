namespace HospitalAutomation
{
    partial class FormDoktorPaneli
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorPaneli));
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.gridControlDoktorlar = new DevExpress.XtraGrid.GridControl();
            this.tableDoktorlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet11 = new HospitalAutomation.HastaneOtomasyonuDataSet11();
            this.gridViewDoktorlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDoktorid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorBrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet3 = new HospitalAutomation.HastaneOtomasyonuDataSet3();
            this.table_DoktorlarTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet3TableAdapters.Table_DoktorlarTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_DoktorlarTableAdapter1 = new HospitalAutomation.HastaneOtomasyonuDataSet11TableAdapters.Table_DoktorlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(98, 32);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(144, 27);
            this.textBoxAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ad:";
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(98, 131);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(144, 27);
            this.comboBoxBrans.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Branş:";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(98, 176);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(144, 27);
            this.maskedTextBoxTC.TabIndex = 4;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "TC:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(98, 77);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(144, 27);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Soyad:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(98, 224);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(144, 27);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifre:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEkle.Location = new System.Drawing.Point(98, 274);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(73, 36);
            this.buttonEkle.TabIndex = 19;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSil.Location = new System.Drawing.Point(172, 274);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(70, 36);
            this.buttonSil.TabIndex = 21;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonGuncelle.Location = new System.Drawing.Point(98, 316);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(144, 36);
            this.buttonGuncelle.TabIndex = 22;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // gridControlDoktorlar
            // 
            this.gridControlDoktorlar.DataSource = this.tableDoktorlarBindingSource1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlDoktorlar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlDoktorlar.Location = new System.Drawing.Point(352, 122);
            this.gridControlDoktorlar.MainView = this.gridViewDoktorlar;
            this.gridControlDoktorlar.Name = "gridControlDoktorlar";
            this.gridControlDoktorlar.Size = new System.Drawing.Size(738, 357);
            this.gridControlDoktorlar.TabIndex = 23;
            this.gridControlDoktorlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDoktorlar});
            // 
            // tableDoktorlarBindingSource1
            // 
            this.tableDoktorlarBindingSource1.DataMember = "Table_Doktorlar";
            this.tableDoktorlarBindingSource1.DataSource = this.hastaneOtomasyonuDataSet11;
            // 
            // hastaneOtomasyonuDataSet11
            // 
            this.hastaneOtomasyonuDataSet11.DataSetName = "HastaneOtomasyonuDataSet11";
            this.hastaneOtomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDoktorlar
            // 
            this.gridViewDoktorlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDoktorid,
            this.colDoktorAd,
            this.colDoktorSoyad,
            this.colDoktorBrans,
            this.colDoktorTC,
            this.colDoktorSifre});
            this.gridViewDoktorlar.GridControl = this.gridControlDoktorlar;
            this.gridViewDoktorlar.Name = "gridViewDoktorlar";
            this.gridViewDoktorlar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDoktorlar_FocusedRowChanged);
            // 
            // colDoktorid
            // 
            this.colDoktorid.FieldName = "Doktorid";
            this.colDoktorid.Name = "colDoktorid";
            this.colDoktorid.Visible = true;
            this.colDoktorid.VisibleIndex = 0;
            this.colDoktorid.Width = 54;
            // 
            // colDoktorAd
            // 
            this.colDoktorAd.FieldName = "DoktorAd";
            this.colDoktorAd.Name = "colDoktorAd";
            this.colDoktorAd.Visible = true;
            this.colDoktorAd.VisibleIndex = 1;
            this.colDoktorAd.Width = 123;
            // 
            // colDoktorSoyad
            // 
            this.colDoktorSoyad.FieldName = "DoktorSoyad";
            this.colDoktorSoyad.Name = "colDoktorSoyad";
            this.colDoktorSoyad.Visible = true;
            this.colDoktorSoyad.VisibleIndex = 2;
            this.colDoktorSoyad.Width = 123;
            // 
            // colDoktorBrans
            // 
            this.colDoktorBrans.FieldName = "DoktorBrans";
            this.colDoktorBrans.Name = "colDoktorBrans";
            this.colDoktorBrans.Visible = true;
            this.colDoktorBrans.VisibleIndex = 3;
            this.colDoktorBrans.Width = 123;
            // 
            // colDoktorTC
            // 
            this.colDoktorTC.FieldName = "DoktorTC";
            this.colDoktorTC.Name = "colDoktorTC";
            this.colDoktorTC.Visible = true;
            this.colDoktorTC.VisibleIndex = 4;
            this.colDoktorTC.Width = 123;
            // 
            // colDoktorSifre
            // 
            this.colDoktorSifre.FieldName = "DoktorSifre";
            this.colDoktorSifre.Name = "colDoktorSifre";
            this.colDoktorSifre.Visible = true;
            this.colDoktorSifre.VisibleIndex = 5;
            this.colDoktorSifre.Width = 129;
            // 
            // tableDoktorlarBindingSource
            // 
            this.tableDoktorlarBindingSource.DataMember = "Table_Doktorlar";
            this.tableDoktorlarBindingSource.DataSource = this.hastaneOtomasyonuDataSet3;
            // 
            // hastaneOtomasyonuDataSet3
            // 
            this.hastaneOtomasyonuDataSet3.DataSetName = "HastaneOtomasyonuDataSet3";
            this.hastaneOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_DoktorlarTableAdapter
            // 
            this.table_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 47);
            this.label3.TabIndex = 25;
            this.label3.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(45, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.comboBoxBrans);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSifre);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(45, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 366);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // table_DoktorlarTableAdapter1
            // 
            this.table_DoktorlarTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1102, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gridControlDoktorlar);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormDoktorPaneli";
            this.Text = " Doktor Paneli";
            this.Load += new System.EventHandler(this.FormDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private DevExpress.XtraGrid.GridControl gridControlDoktorlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoktorlar;
        private HastaneOtomasyonuDataSet3 hastaneOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource tableDoktorlarBindingSource;
        private HastaneOtomasyonuDataSet3TableAdapters.Table_DoktorlarTableAdapter table_DoktorlarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorid;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorAd;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorBrans;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorTC;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private HastaneOtomasyonuDataSet11 hastaneOtomasyonuDataSet11;
        private System.Windows.Forms.BindingSource tableDoktorlarBindingSource1;
        private HastaneOtomasyonuDataSet11TableAdapters.Table_DoktorlarTableAdapter table_DoktorlarTableAdapter1;
    }
}