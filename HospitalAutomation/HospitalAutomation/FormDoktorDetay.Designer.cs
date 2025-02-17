namespace HospitalAutomation
{
    partial class FormDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxRapor = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRandevuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuBrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuDoktor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaSikayet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonRaporuGonder = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlBilgiDuzen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlDuyuru = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlCikiss = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.hastaneOtomasyonuDataSet7 = new HospitalAutomation.HastaneOtomasyonuDataSet7();
            this.tableRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_RandevularTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet7TableAdapters.Table_RandevularTableAdapter();
            this.tableRandevularBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet8 = new HospitalAutomation.HastaneOtomasyonuDataSet8();
            this.table_RandevularTableAdapter1 = new HospitalAutomation.HastaneOtomasyonuDataSet8TableAdapters.Table_RandevularTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(623, 101);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(131, 22);
            this.labelTC.TabIndex = 2;
            this.labelTC.Text = "00000000000";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(377, 101);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(86, 22);
            this.labelAdSoyad.TabIndex = 4;
            this.labelAdSoyad.Text = "Null Null";
//            this.labelAdSoyad.Click += new System.EventHandler(this.labelAdSoyad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxSikayet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(256, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 345);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBoxSikayet
            // 
            this.richTextBoxSikayet.Location = new System.Drawing.Point(7, 51);
            this.richTextBoxSikayet.Name = "richTextBoxSikayet";
            this.richTextBoxSikayet.Size = new System.Drawing.Size(374, 316);
            this.richTextBoxSikayet.TabIndex = 3;
            this.richTextBoxSikayet.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şikayet:";
            // 
            // richTextBoxRapor
            // 
            this.richTextBoxRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRapor.Location = new System.Drawing.Point(3, 26);
            this.richTextBoxRapor.Name = "richTextBoxRapor";
            this.richTextBoxRapor.Size = new System.Drawing.Size(872, 259);
            this.richTextBoxRapor.TabIndex = 1;
            this.richTextBoxRapor.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxRapor);
            this.groupBox5.Controls.Add(this.gridControl1);
            this.groupBox5.Location = new System.Drawing.Point(671, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(878, 288);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapor Yazma";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(167, -124);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(707, 75);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRandevuid,
            this.colRandevuTarih,
            this.colRandevuSaat,
            this.colRandevuBrans,
            this.colRandevuDoktor,
            this.colRandevuDurum,
            this.colHastaTC,
            this.colHastaSikayet});
            this.gridView1.DetailHeight = 335;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colRandevuid
            // 
            this.colRandevuid.FieldName = "Randevuid";
            this.colRandevuid.MinWidth = 22;
            this.colRandevuid.Name = "colRandevuid";
            this.colRandevuid.Visible = true;
            this.colRandevuid.VisibleIndex = 0;
            this.colRandevuid.Width = 77;
            // 
            // colRandevuTarih
            // 
            this.colRandevuTarih.FieldName = "RandevuTarih";
            this.colRandevuTarih.MinWidth = 22;
            this.colRandevuTarih.Name = "colRandevuTarih";
            this.colRandevuTarih.Visible = true;
            this.colRandevuTarih.VisibleIndex = 1;
            this.colRandevuTarih.Width = 161;
            // 
            // colRandevuSaat
            // 
            this.colRandevuSaat.FieldName = "RandevuSaat";
            this.colRandevuSaat.MinWidth = 22;
            this.colRandevuSaat.Name = "colRandevuSaat";
            this.colRandevuSaat.Visible = true;
            this.colRandevuSaat.VisibleIndex = 2;
            this.colRandevuSaat.Width = 161;
            // 
            // colRandevuBrans
            // 
            this.colRandevuBrans.FieldName = "RandevuBrans";
            this.colRandevuBrans.MinWidth = 22;
            this.colRandevuBrans.Name = "colRandevuBrans";
            this.colRandevuBrans.Visible = true;
            this.colRandevuBrans.VisibleIndex = 3;
            this.colRandevuBrans.Width = 161;
            // 
            // colRandevuDoktor
            // 
            this.colRandevuDoktor.FieldName = "RandevuDoktor";
            this.colRandevuDoktor.MinWidth = 22;
            this.colRandevuDoktor.Name = "colRandevuDoktor";
            this.colRandevuDoktor.Visible = true;
            this.colRandevuDoktor.VisibleIndex = 4;
            this.colRandevuDoktor.Width = 161;
            // 
            // colRandevuDurum
            // 
            this.colRandevuDurum.FieldName = "RandevuDurum";
            this.colRandevuDurum.MinWidth = 22;
            this.colRandevuDurum.Name = "colRandevuDurum";
            this.colRandevuDurum.Visible = true;
            this.colRandevuDurum.VisibleIndex = 5;
            this.colRandevuDurum.Width = 161;
            // 
            // colHastaTC
            // 
            this.colHastaTC.FieldName = "HastaTC";
            this.colHastaTC.MinWidth = 22;
            this.colHastaTC.Name = "colHastaTC";
            this.colHastaTC.Visible = true;
            this.colHastaTC.VisibleIndex = 6;
            this.colHastaTC.Width = 161;
            // 
            // colHastaSikayet
            // 
            this.colHastaSikayet.FieldName = "HastaSikayet";
            this.colHastaSikayet.MinWidth = 22;
            this.colHastaSikayet.Name = "colHastaSikayet";
            this.colHastaSikayet.Visible = true;
            this.colHastaSikayet.VisibleIndex = 7;
            this.colHastaSikayet.Width = 178;
            // 
            // ButtonRaporuGonder
            // 
            this.ButtonRaporuGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ButtonRaporuGonder.Location = new System.Drawing.Point(674, 656);
            this.ButtonRaporuGonder.Name = "ButtonRaporuGonder";
            this.ButtonRaporuGonder.Size = new System.Drawing.Size(878, 29);
            this.ButtonRaporuGonder.TabIndex = 2;
            this.ButtonRaporuGonder.Text = "Raporu Gönder";
            this.ButtonRaporuGonder.Click += new System.EventHandler(this.ButtonRaporuGonder_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // popupMenu2
            // 
            this.popupMenu2.Name = "popupMenu2";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlSeparator1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(222, 711);
            this.accordionControl1.TabIndex = 6;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlBilgiDuzen,
            this.accordionCtrlDuyuru,
            this.accordionCtrlCikiss});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "İŞLEMLER";
            // 
            // accordionCtrlBilgiDuzen
            // 
            this.accordionCtrlBilgiDuzen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlBilgiDuzen.ImageOptions.Image")));
            this.accordionCtrlBilgiDuzen.Name = "accordionCtrlBilgiDuzen";
            this.accordionCtrlBilgiDuzen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlBilgiDuzen.Text = "BİLGİ DÜZENLE";
            this.accordionCtrlBilgiDuzen.Click += new System.EventHandler(this.accordionCtrlBilgiDuzen_Click);
            // 
            // accordionCtrlDuyuru
            // 
            this.accordionCtrlDuyuru.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlDuyuru.ImageOptions.Image")));
            this.accordionCtrlDuyuru.Name = "accordionCtrlDuyuru";
            this.accordionCtrlDuyuru.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlDuyuru.Text = "DUYURULAR";
            this.accordionCtrlDuyuru.Click += new System.EventHandler(this.accordionCtrlDuyuru_Click);
            // 
            // accordionCtrlCikiss
            // 
            this.accordionCtrlCikiss.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlCikiss.ImageOptions.Image")));
            this.accordionCtrlCikiss.Name = "accordionCtrlCikiss";
            this.accordionCtrlCikiss.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlCikiss.Text = "ÇIKIŞ";
            this.accordionCtrlCikiss.Click += new System.EventHandler(this.accordionCtrlCikiss_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // hastaneOtomasyonuDataSet7
            // 
            this.hastaneOtomasyonuDataSet7.DataSetName = "HastaneOtomasyonuDataSet7";
            this.hastaneOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableRandevularBindingSource
            // 
            this.tableRandevularBindingSource.DataMember = "Table_Randevular";
            this.tableRandevularBindingSource.DataSource = this.hastaneOtomasyonuDataSet7;
            // 
            // table_RandevularTableAdapter
            // 
            this.table_RandevularTableAdapter.ClearBeforeFill = true;
            // 
            // tableRandevularBindingSource1
            // 
            this.tableRandevularBindingSource1.DataMember = "Table_Randevular";
            this.tableRandevularBindingSource1.DataSource = this.hastaneOtomasyonuDataSet8;
            // 
            // hastaneOtomasyonuDataSet8
            // 
            this.hastaneOtomasyonuDataSet8.DataSetName = "HastaneOtomasyonuDataSet8";
            this.hastaneOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_RandevularTableAdapter1
            // 
            this.table_RandevularTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hoşgeldiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 47);
            this.label3.TabIndex = 21;
            this.label3.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(249, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(249, 134);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1281, 200);
            this.gridControl2.TabIndex = 22;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged_1);
            // 
            // FormDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1557, 713);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.ButtonRaporuGonder);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormDoktorDetay";
            this.Text = " Doktor Detay";
            this.Load += new System.EventHandler(this.FormDoktorDetay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxSikayet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxRapor;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.SimpleButton ButtonRaporuGonder;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private HastaneOtomasyonuDataSet7 hastaneOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource tableRandevularBindingSource;
        private HastaneOtomasyonuDataSet7TableAdapters.Table_RandevularTableAdapter table_RandevularTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HastaneOtomasyonuDataSet8 hastaneOtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource tableRandevularBindingSource1;
        private HastaneOtomasyonuDataSet8TableAdapters.Table_RandevularTableAdapter table_RandevularTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuid;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuBrans;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuDoktor;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaTC;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaSikayet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlBilgiDuzen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlDuyuru;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlCikiss;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}