namespace HospitalAutomation
{
    partial class FormSekreterRandevuOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterRandevuOlusturma));
            this.gridCtrlBranslar = new DevExpress.XtraGrid.GridControl();
            this.tableBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet1 = new HospitalAutomation.HastaneOtomasyonuDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBransid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBransAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCtrlDoktorlar = new DevExpress.XtraGrid.GridControl();
            this.tableDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet2 = new HospitalAutomation.HastaneOtomasyonuDataSet2();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDoktorid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorBrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.table_BranslarTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet1TableAdapters.Table_BranslarTableAdapter();
            this.table_DoktorlarTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet2TableAdapters.Table_DoktorlarTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxtarih = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlBranslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrlBranslar
            // 
            this.gridCtrlBranslar.DataSource = this.tableBranslarBindingSource;
            this.gridCtrlBranslar.Location = new System.Drawing.Point(497, 107);
            this.gridCtrlBranslar.MainView = this.gridView1;
            this.gridCtrlBranslar.Name = "gridCtrlBranslar";
            this.gridCtrlBranslar.Size = new System.Drawing.Size(591, 237);
            this.gridCtrlBranslar.TabIndex = 0;
            this.gridCtrlBranslar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tableBranslarBindingSource
            // 
            this.tableBranslarBindingSource.DataMember = "Table_Branslar";
            this.tableBranslarBindingSource.DataSource = this.hastaneOtomasyonuDataSet1;
            // 
            // hastaneOtomasyonuDataSet1
            // 
            this.hastaneOtomasyonuDataSet1.DataSetName = "HastaneOtomasyonuDataSet1";
            this.hastaneOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBransid,
            this.colBransAd});
            this.gridView1.GridControl = this.gridCtrlBranslar;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colBransid
            // 
            this.colBransid.FieldName = "Bransid";
            this.colBransid.Name = "colBransid";
            this.colBransid.Visible = true;
            this.colBransid.VisibleIndex = 0;
            this.colBransid.Width = 60;
            // 
            // colBransAd
            // 
            this.colBransAd.FieldName = "BransAd";
            this.colBransAd.Name = "colBransAd";
            this.colBransAd.Visible = true;
            this.colBransAd.VisibleIndex = 1;
            this.colBransAd.Width = 513;
            // 
            // gridCtrlDoktorlar
            // 
            this.gridCtrlDoktorlar.DataSource = this.tableDoktorlarBindingSource;
            this.gridCtrlDoktorlar.Location = new System.Drawing.Point(497, 362);
            this.gridCtrlDoktorlar.MainView = this.gridView2;
            this.gridCtrlDoktorlar.Name = "gridCtrlDoktorlar";
            this.gridCtrlDoktorlar.Size = new System.Drawing.Size(591, 276);
            this.gridCtrlDoktorlar.TabIndex = 1;
            this.gridCtrlDoktorlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tableDoktorlarBindingSource
            // 
            this.tableDoktorlarBindingSource.DataMember = "Table_Doktorlar";
            this.tableDoktorlarBindingSource.DataSource = this.hastaneOtomasyonuDataSet2;
            // 
            // hastaneOtomasyonuDataSet2
            // 
            this.hastaneOtomasyonuDataSet2.DataSetName = "HastaneOtomasyonuDataSet2";
            this.hastaneOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDoktorid,
            this.colDoktorAd,
            this.colDoktorSoyad,
            this.colDoktorBrans,
            this.colDoktorTC,
            this.colDoktorSifre});
            this.gridView2.GridControl = this.gridCtrlDoktorlar;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colDoktorid
            // 
            this.colDoktorid.FieldName = "Doktorid";
            this.colDoktorid.Name = "colDoktorid";
            this.colDoktorid.Visible = true;
            this.colDoktorid.VisibleIndex = 0;
            this.colDoktorid.Width = 59;
            // 
            // colDoktorAd
            // 
            this.colDoktorAd.FieldName = "DoktorAd";
            this.colDoktorAd.Name = "colDoktorAd";
            this.colDoktorAd.Visible = true;
            this.colDoktorAd.VisibleIndex = 1;
            this.colDoktorAd.Width = 170;
            // 
            // colDoktorSoyad
            // 
            this.colDoktorSoyad.FieldName = "DoktorSoyad";
            this.colDoktorSoyad.Name = "colDoktorSoyad";
            this.colDoktorSoyad.Visible = true;
            this.colDoktorSoyad.VisibleIndex = 2;
            this.colDoktorSoyad.Width = 170;
            // 
            // colDoktorBrans
            // 
            this.colDoktorBrans.FieldName = "DoktorBrans";
            this.colDoktorBrans.Name = "colDoktorBrans";
            this.colDoktorBrans.Visible = true;
            this.colDoktorBrans.VisibleIndex = 3;
            this.colDoktorBrans.Width = 174;
            // 
            // colDoktorTC
            // 
            this.colDoktorTC.FieldName = "DoktorTC";
            this.colDoktorTC.Name = "colDoktorTC";
            // 
            // colDoktorSifre
            // 
            this.colDoktorSifre.FieldName = "DoktorSifre";
            this.colDoktorSifre.Name = "colDoktorSifre";
            // 
            // table_BranslarTableAdapter
            // 
            this.table_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // table_DoktorlarTableAdapter
            // 
            this.table_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKaydet);
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.maskedTextBoxTC);
            this.groupBox3.Controls.Add(this.comboBoxDoktor);
            this.groupBox3.Controls.Add(this.comboBoxBrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxtarih);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(98, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 388);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Oluşturma";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(121, 323);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(161, 30);
            this.buttonKaydet.TabIndex = 14;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(121, 279);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(78, 23);
            this.checkBoxDurum.TabIndex = 13;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(121, 233);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(161, 27);
            this.maskedTextBoxTC.TabIndex = 12;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(121, 185);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(161, 27);
            this.comboBoxDoktor.TabIndex = 11;
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(121, 136);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(161, 27);
            this.comboBoxBrans.TabIndex = 10;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(121, 92);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(161, 27);
            this.maskedTextBoxSaat.TabIndex = 9;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxtarih
            // 
            this.maskedTextBoxtarih.Location = new System.Drawing.Point(121, 51);
            this.maskedTextBoxtarih.Mask = "00/00/0000";
            this.maskedTextBoxtarih.Name = "maskedTextBoxtarih";
            this.maskedTextBoxtarih.Size = new System.Drawing.Size(161, 27);
            this.maskedTextBoxtarih.TabIndex = 7;
            this.maskedTextBoxtarih.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 21;
            this.label2.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(38, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // FormSekreterRandevuOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1147, 678);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridCtrlDoktorlar);
            this.Controls.Add(this.gridCtrlBranslar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSekreterRandevuOlusturma";
            this.Text = " Randevu Oluşturma";
            this.Load += new System.EventHandler(this.FormSekreterRandevuOlusturma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlBranslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlBranslar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridCtrlDoktorlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private HastaneOtomasyonuDataSet1 hastaneOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tableBranslarBindingSource;
        private HastaneOtomasyonuDataSet1TableAdapters.Table_BranslarTableAdapter table_BranslarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBransid;
        private DevExpress.XtraGrid.Columns.GridColumn colBransAd;
        private HastaneOtomasyonuDataSet2 hastaneOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource tableDoktorlarBindingSource;
        private HastaneOtomasyonuDataSet2TableAdapters.Table_DoktorlarTableAdapter table_DoktorlarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorid;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorAd;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorBrans;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorTC;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorSifre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}