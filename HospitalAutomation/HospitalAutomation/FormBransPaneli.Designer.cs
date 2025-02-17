namespace HospitalAutomation
{
    partial class FormBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBransPaneli));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxBransAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBransid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControlBranslar = new DevExpress.XtraGrid.GridControl();
            this.tableBranslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet4 = new HospitalAutomation.HastaneOtomasyonuDataSet4();
            this.gridViewBranslar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBransid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBransAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.table_BranslarTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet4TableAdapters.Table_BranslarTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBranslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBranslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonGuncelle.Location = new System.Drawing.Point(100, 187);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(144, 36);
            this.buttonGuncelle.TabIndex = 36;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSil.Location = new System.Drawing.Point(174, 145);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(70, 36);
            this.buttonSil.TabIndex = 35;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEkle.Location = new System.Drawing.Point(100, 145);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(73, 36);
            this.buttonEkle.TabIndex = 33;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxBransAd
            // 
            this.textBoxBransAd.Location = new System.Drawing.Point(100, 91);
            this.textBoxBransAd.Name = "textBoxBransAd";
            this.textBoxBransAd.Size = new System.Drawing.Size(144, 27);
            this.textBoxBransAd.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Branş Ad:";
            // 
            // textBoxBransid
            // 
            this.textBoxBransid.Location = new System.Drawing.Point(100, 46);
            this.textBoxBransid.Name = "textBoxBransid";
            this.textBoxBransid.Size = new System.Drawing.Size(144, 27);
            this.textBoxBransid.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Branş id:";
            // 
            // gridControlBranslar
            // 
            this.gridControlBranslar.DataSource = this.tableBranslarBindingSource;
            this.gridControlBranslar.Location = new System.Drawing.Point(353, 137);
            this.gridControlBranslar.MainView = this.gridViewBranslar;
            this.gridControlBranslar.Name = "gridControlBranslar";
            this.gridControlBranslar.Size = new System.Drawing.Size(414, 250);
            this.gridControlBranslar.TabIndex = 37;
            this.gridControlBranslar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBranslar});
            // 
            // tableBranslarBindingSource
            // 
            this.tableBranslarBindingSource.DataMember = "Table_Branslar";
            this.tableBranslarBindingSource.DataSource = this.hastaneOtomasyonuDataSet4;
            // 
            // hastaneOtomasyonuDataSet4
            // 
            this.hastaneOtomasyonuDataSet4.DataSetName = "HastaneOtomasyonuDataSet4";
            this.hastaneOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBranslar
            // 
            this.gridViewBranslar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBransid,
            this.colBransAd});
            this.gridViewBranslar.GridControl = this.gridControlBranslar;
            this.gridViewBranslar.Name = "gridViewBranslar";
            this.gridViewBranslar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBranslar_FocusedRowChanged);
            // 
            // colBransid
            // 
            this.colBransid.FieldName = "Bransid";
            this.colBransid.Name = "colBransid";
            this.colBransid.Visible = true;
            this.colBransid.VisibleIndex = 0;
            // 
            // colBransAd
            // 
            this.colBransAd.FieldName = "BransAd";
            this.colBransAd.Name = "colBransAd";
            this.colBransAd.Visible = true;
            this.colBransAd.VisibleIndex = 1;
            // 
            // table_BranslarTableAdapter
            // 
            this.table_BranslarTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 39;
            this.label2.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxBransid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.textBoxBransAd);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(22, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 263);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // FormBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(846, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gridControlBranslar);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormBransPaneli";
            this.Text = " Branş Paneli";
            this.Load += new System.EventHandler(this.FormBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBranslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBranslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxBransAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBransid;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControlBranslar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBranslar;
        private HastaneOtomasyonuDataSet4 hastaneOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource tableBranslarBindingSource;
        private HastaneOtomasyonuDataSet4TableAdapters.Table_BranslarTableAdapter table_BranslarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBransid;
        private DevExpress.XtraGrid.Columns.GridColumn colBransAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}