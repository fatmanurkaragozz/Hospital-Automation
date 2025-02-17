namespace HospitalAutomation
{
    partial class FormRandevuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandevuListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet5 = new HospitalAutomation.HastaneOtomasyonuDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRandevuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuBrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuDoktor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRandevuDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaSikayet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.table_RandevularTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet5TableAdapters.Table_RandevularTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tableRandevularBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1113, 495);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tableRandevularBindingSource
            // 
            this.tableRandevularBindingSource.DataMember = "Table_Randevular";
            this.tableRandevularBindingSource.DataSource = this.hastaneOtomasyonuDataSet5;
            // 
            // hastaneOtomasyonuDataSet5
            // 
            this.hastaneOtomasyonuDataSet5.DataSetName = "HastaneOtomasyonuDataSet5";
            this.hastaneOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colRandevuid
            // 
            this.colRandevuid.FieldName = "Randevuid";
            this.colRandevuid.Name = "colRandevuid";
            this.colRandevuid.Visible = true;
            this.colRandevuid.VisibleIndex = 0;
            this.colRandevuid.Width = 69;
            // 
            // colRandevuTarih
            // 
            this.colRandevuTarih.FieldName = "RandevuTarih";
            this.colRandevuTarih.Name = "colRandevuTarih";
            this.colRandevuTarih.Visible = true;
            this.colRandevuTarih.VisibleIndex = 1;
            this.colRandevuTarih.Width = 142;
            // 
            // colRandevuSaat
            // 
            this.colRandevuSaat.FieldName = "RandevuSaat";
            this.colRandevuSaat.Name = "colRandevuSaat";
            this.colRandevuSaat.Visible = true;
            this.colRandevuSaat.VisibleIndex = 2;
            this.colRandevuSaat.Width = 142;
            // 
            // colRandevuBrans
            // 
            this.colRandevuBrans.FieldName = "RandevuBrans";
            this.colRandevuBrans.Name = "colRandevuBrans";
            this.colRandevuBrans.Visible = true;
            this.colRandevuBrans.VisibleIndex = 3;
            this.colRandevuBrans.Width = 142;
            // 
            // colRandevuDoktor
            // 
            this.colRandevuDoktor.FieldName = "RandevuDoktor";
            this.colRandevuDoktor.Name = "colRandevuDoktor";
            this.colRandevuDoktor.Visible = true;
            this.colRandevuDoktor.VisibleIndex = 4;
            this.colRandevuDoktor.Width = 142;
            // 
            // colRandevuDurum
            // 
            this.colRandevuDurum.FieldName = "RandevuDurum";
            this.colRandevuDurum.Name = "colRandevuDurum";
            this.colRandevuDurum.Visible = true;
            this.colRandevuDurum.VisibleIndex = 5;
            this.colRandevuDurum.Width = 142;
            // 
            // colHastaTC
            // 
            this.colHastaTC.FieldName = "HastaTC";
            this.colHastaTC.Name = "colHastaTC";
            this.colHastaTC.Visible = true;
            this.colHastaTC.VisibleIndex = 6;
            this.colHastaTC.Width = 142;
            // 
            // colHastaSikayet
            // 
            this.colHastaSikayet.FieldName = "HastaSikayet";
            this.colHastaSikayet.Name = "colHastaSikayet";
            this.colHastaSikayet.Visible = true;
            this.colHastaSikayet.VisibleIndex = 7;
            this.colHastaSikayet.Width = 174;
            // 
            // table_RandevularTableAdapter
            // 
            this.table_RandevularTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 21;
            this.label2.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // FormRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1137, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormRandevuListesi";
            this.Text = " Randevu Listesi";
            this.Load += new System.EventHandler(this.FormRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRandevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HastaneOtomasyonuDataSet5 hastaneOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource tableRandevularBindingSource;
        private HastaneOtomasyonuDataSet5TableAdapters.Table_RandevularTableAdapter table_RandevularTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuid;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuBrans;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuDoktor;
        private DevExpress.XtraGrid.Columns.GridColumn colRandevuDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaTC;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaSikayet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}