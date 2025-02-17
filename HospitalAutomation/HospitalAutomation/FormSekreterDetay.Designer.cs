namespace HospitalAutomation
{
    partial class FormSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDetay));
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlDoktorPnl = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlBransPnl = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlRandevuLst = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlDuyurular = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlDuyuruOlusturma = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlRandevuOlusturma = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.accordionCtrlCikis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(388, 115);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(86, 22);
            this.labelAdSoyad.TabIndex = 3;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTC.Location = new System.Drawing.Point(343, 150);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(120, 21);
            this.labelTC.TabIndex = 1;
            this.labelTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(242, 713);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionCtrlDuyuruOlusturma,
            this.accordionCtrlRandevuOlusturma,
            this.accordionCtrlCikis});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "İŞLEMLER";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlDoktorPnl,
            this.accordionCtrlBransPnl,
            this.accordionCtrlRandevuLst,
            this.accordionCtrlDuyurular});
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "HIZLI ERİŞİM";
            // 
            // accordionCtrlDoktorPnl
            // 
            this.accordionCtrlDoktorPnl.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionCtrlDoktorPnl.Name = "accordionCtrlDoktorPnl";
            this.accordionCtrlDoktorPnl.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlDoktorPnl.Text = "Doktor Paneli";
            this.accordionCtrlDoktorPnl.Click += new System.EventHandler(this.accordionCtrlDoktorPnl_Click);
            // 
            // accordionCtrlBransPnl
            // 
            this.accordionCtrlBransPnl.Name = "accordionCtrlBransPnl";
            this.accordionCtrlBransPnl.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlBransPnl.Text = "Branş Paneli";
            this.accordionCtrlBransPnl.Click += new System.EventHandler(this.accordionCtrlBransPnl_Click);
            // 
            // accordionCtrlRandevuLst
            // 
            this.accordionCtrlRandevuLst.Name = "accordionCtrlRandevuLst";
            this.accordionCtrlRandevuLst.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlRandevuLst.Text = "Randevu Liste";
            this.accordionCtrlRandevuLst.Click += new System.EventHandler(this.accordionCtrlRandevuLst_Click);
            // 
            // accordionCtrlDuyurular
            // 
            this.accordionCtrlDuyurular.Name = "accordionCtrlDuyurular";
            this.accordionCtrlDuyurular.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlDuyurular.Text = "Duyurular";
            this.accordionCtrlDuyurular.Click += new System.EventHandler(this.accordionCtrlDuyurular_Click);
            // 
            // accordionCtrlDuyuruOlusturma
            // 
            this.accordionCtrlDuyuruOlusturma.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionCtrlDuyuruOlusturma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlDuyuruOlusturma.ImageOptions.Image")));
            this.accordionCtrlDuyuruOlusturma.Name = "accordionCtrlDuyuruOlusturma";
            this.accordionCtrlDuyuruOlusturma.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlDuyuruOlusturma.Text = "DUYURU OLUŞTURMA";
            this.accordionCtrlDuyuruOlusturma.Click += new System.EventHandler(this.accordionCtrlDuyuruOlusturma_Click);
            // 
            // accordionCtrlRandevuOlusturma
            // 
            this.accordionCtrlRandevuOlusturma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlRandevuOlusturma.ImageOptions.Image")));
            this.accordionCtrlRandevuOlusturma.Name = "accordionCtrlRandevuOlusturma";
            this.accordionCtrlRandevuOlusturma.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlRandevuOlusturma.Text = "RANDEVU OLUŞTURMA";
            this.accordionCtrlRandevuOlusturma.Click += new System.EventHandler(this.accordionCtrlRandevuOlusturma_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(260, 106);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 40);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Hoşgeldiniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 19;
            this.label2.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(261, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // accordionCtrlCikis
            // 
            this.accordionCtrlCikis.ImageOptions.Image = global::HospitalAutomation.Properties.Resources.delete_32x32;
            this.accordionCtrlCikis.Name = "accordionCtrlCikis";
            this.accordionCtrlCikis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlCikis.Text = "ÇIKIŞ";
            this.accordionCtrlCikis.Click += new System.EventHandler(this.accordionCtrlCikis_Click);
            // 
            // FormSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1557, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accordionControl1);
            this.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormSekreterDetay";
            this.Text = " Sekreter Detay Ekranı";
            this.Load += new System.EventHandler(this.FormSekreterDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlDoktorPnl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlBransPnl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlRandevuLst;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlDuyurular;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlDuyuruOlusturma;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlRandevuOlusturma;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlCikis;
    }
}