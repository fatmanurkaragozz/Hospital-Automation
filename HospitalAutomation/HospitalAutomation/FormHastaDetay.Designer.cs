using HospitalAutomation.Models;

namespace HospitalAutomation
{
    partial class FormHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRandevuAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlRaporlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlRandevuGecmisi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlBilgiDuzenle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlCikis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet10 = new HospitalAutomation.HastaneOtomasyonuDataSet10();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_RandevularTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet10TableAdapters.Table_RandevularTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(594, 108);
            this.labelTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(131, 22);
            this.labelTC.TabIndex = 2;
            this.labelTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hoşgeldiniz";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(385, 108);
            this.labelAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(86, 22);
            this.labelAdSoyad.TabIndex = 4;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonRandevuAl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.richTextBoxSikayet);
            this.groupBox2.Controls.Add(this.comboBoxDoktor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxBrans);
            this.groupBox2.Location = new System.Drawing.Point(262, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(312, 487);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Şikayet:";
            // 
            // buttonRandevuAl
            // 
            this.buttonRandevuAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRandevuAl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRandevuAl.Location = new System.Drawing.Point(76, 439);
            this.buttonRandevuAl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRandevuAl.Name = "buttonRandevuAl";
            this.buttonRandevuAl.Size = new System.Drawing.Size(148, 30);
            this.buttonRandevuAl.TabIndex = 3;
            this.buttonRandevuAl.Text = "Randevu Al";
            this.buttonRandevuAl.UseVisualStyleBackColor = false;
            this.buttonRandevuAl.Click += new System.EventHandler(this.buttonRandevuAl_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doktor:";
            // 
            // richTextBoxSikayet
            // 
            this.richTextBoxSikayet.Location = new System.Drawing.Point(22, 175);
            this.richTextBoxSikayet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxSikayet.Name = "richTextBoxSikayet";
            this.richTextBoxSikayet.Size = new System.Drawing.Size(269, 258);
            this.richTextBoxSikayet.TabIndex = 2;
            this.richTextBoxSikayet.Text = "";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(113, 92);
            this.comboBoxDoktor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(178, 30);
            this.comboBoxDoktor.TabIndex = 2;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branş:";
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(113, 45);
            this.comboBoxBrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(178, 30);
            this.comboBoxBrans.TabIndex = 0;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(945, 53);
            this.textBoxid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(147, 30);
            this.textBoxid.TabIndex = 7;
            this.textBoxid.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(1127, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(176, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            this.groupBox3.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(168, 45);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(748, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(174, 70);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            this.groupBox4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(166, 41);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(240, 713);
            this.accordionControl1.TabIndex = 9;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlRaporlar,
            this.accordionCtrlRandevuGecmisi,
            this.accordionCtrlBilgiDuzenle,
            this.accordionCtrlCikis});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "İŞLEMLER";
            // 
            // accordionCtrlRaporlar
            // 
            this.accordionCtrlRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlRaporlar.ImageOptions.Image")));
            this.accordionCtrlRaporlar.Name = "accordionCtrlRaporlar";
            this.accordionCtrlRaporlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlRaporlar.Text = "RAPORLAR";
            this.accordionCtrlRaporlar.Click += new System.EventHandler(this.accordionCtrlRaporlar_Click_1);
            // 
            // accordionCtrlRandevuGecmisi
            // 
            this.accordionCtrlRandevuGecmisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlRandevuGecmisi.ImageOptions.Image")));
            this.accordionCtrlRandevuGecmisi.Name = "accordionCtrlRandevuGecmisi";
            this.accordionCtrlRandevuGecmisi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlRandevuGecmisi.Text = "RANDEVU GEÇMİŞİ";
            this.accordionCtrlRandevuGecmisi.Click += new System.EventHandler(this.accordionCtrlRandevuGecmisi_Click);
            // 
            // accordionCtrlBilgiDuzenle
            // 
            this.accordionCtrlBilgiDuzenle.ImageOptions.Image = global::HospitalAutomation.Properties.Resources.edit_32x32;
            this.accordionCtrlBilgiDuzenle.Name = "accordionCtrlBilgiDuzenle";
            this.accordionCtrlBilgiDuzenle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlBilgiDuzenle.Text = "BİLGİ DÜZENLE";
            this.accordionCtrlBilgiDuzenle.Click += new System.EventHandler(this.accordionCtrlBilgiDuzenle_Click);
            // 
            // accordionCtrlCikis
            // 
            this.accordionCtrlCikis.ImageOptions.Image = global::HospitalAutomation.Properties.Resources.delete_32x32;
            this.accordionCtrlCikis.Name = "accordionCtrlCikis";
            this.accordionCtrlCikis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlCikis.Text = "ÇIKIŞ";
            this.accordionCtrlCikis.Click += new System.EventHandler(this.accordionCtrlCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 47);
            this.label4.TabIndex = 21;
            this.label4.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(262, 12);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(957, 458);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataSource = typeof(HospitalAutomation.Models.Randevu);
            // 
            // tableRandevularBindingSource
            // 
            this.tableRandevularBindingSource.DataMember = "Table_Randevular";
            this.tableRandevularBindingSource.DataSource = this.hastaneOtomasyonuDataSet10;
            // 
            // hastaneOtomasyonuDataSet10
            // 
            this.hastaneOtomasyonuDataSet10.DataSetName = "HastaneOtomasyonuDataSet10";
            this.hastaneOtomasyonuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(582, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 487);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Randevular";
            // 
            // table_RandevularTableAdapter
            // 
            this.table_RandevularTableAdapter.ClearBeforeFill = true;
            // 
            // FormHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1557, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHastaDetay";
            this.Text = " Hasta Detay";
            this.Load += new System.EventHandler(this.FormHastaDetay_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRandevuAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxSikayet;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxid;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlRaporlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlRandevuGecmisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HastaneOtomasyonuDataSet10 hastaneOtomasyonuDataSet10;
        private System.Windows.Forms.BindingSource tableRandevularBindingSource;
        private HastaneOtomasyonuDataSet10TableAdapters.Table_RandevularTableAdapter table_RandevularTableAdapter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlBilgiDuzenle;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlCikis;
    }
}