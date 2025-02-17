namespace HospitalAutomation
{
    partial class FormRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaporlar));
            this.xpDataView1 = new DevExpress.Xpo.XPDataView(this.components);
            this.gridControlRaporlar = new DevExpress.XtraGrid.GridControl();
            this.tableRaporlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet = new HospitalAutomation.HastaneOtomasyonuDataSet();
            this.gridViewRaporlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRaporid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoktorTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaporMetni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.table_RaporlarTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSetTableAdapters.Table_RaporlarTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xpDataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRaporlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRaporlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRaporlar
            // 
            this.gridControlRaporlar.DataSource = this.tableRaporlarBindingSource;
            this.gridControlRaporlar.Location = new System.Drawing.Point(26, 103);
            this.gridControlRaporlar.MainView = this.gridViewRaporlar;
            this.gridControlRaporlar.Name = "gridControlRaporlar";
            this.gridControlRaporlar.Size = new System.Drawing.Size(1086, 569);
            this.gridControlRaporlar.TabIndex = 1;
            this.gridControlRaporlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRaporlar});
//            this.gridControlRaporlar.Click += new System.EventHandler(this.gridControlRaporlar_Click);
            // 
            // tableRaporlarBindingSource
            // 
            this.tableRaporlarBindingSource.DataMember = "Table_Raporlar";
            this.tableRaporlarBindingSource.DataSource = this.hastaneOtomasyonuDataSetBindingSource;
            // 
            // hastaneOtomasyonuDataSetBindingSource
            // 
            this.hastaneOtomasyonuDataSetBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            this.hastaneOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRaporlar
            // 
            this.gridViewRaporlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRaporid,
            this.colHastaTC,
            this.colDoktorTC,
            this.colRaporMetni,
            this.colTarih});
            this.gridViewRaporlar.DetailHeight = 377;
            this.gridViewRaporlar.GridControl = this.gridControlRaporlar;
            this.gridViewRaporlar.Name = "gridViewRaporlar";
            this.gridViewRaporlar.OptionsBehavior.Editable = false;
            this.gridViewRaporlar.OptionsFind.AlwaysVisible = true;
            this.gridViewRaporlar.OptionsFind.FindNullPrompt = "Aramak için Enter tuşuna basın... ";
            // 
            // colRaporid
            // 
            this.colRaporid.Caption = "Rapor ID";
            this.colRaporid.FieldName = "Raporid";
            this.colRaporid.Name = "colRaporid";
            this.colRaporid.OptionsColumn.AllowEdit = false;
            this.colRaporid.Visible = true;
            this.colRaporid.VisibleIndex = 0;
            this.colRaporid.Width = 52;
            // 
            // colHastaTC
            // 
            this.colHastaTC.FieldName = "HastaTC";
            this.colHastaTC.Name = "colHastaTC";
            this.colHastaTC.Visible = true;
            this.colHastaTC.VisibleIndex = 1;
            this.colHastaTC.Width = 265;
            // 
            // colDoktorTC
            // 
            this.colDoktorTC.FieldName = "DoktorTC";
            this.colDoktorTC.Name = "colDoktorTC";
            this.colDoktorTC.Visible = true;
            this.colDoktorTC.VisibleIndex = 2;
            this.colDoktorTC.Width = 265;
            // 
            // colRaporMetni
            // 
            this.colRaporMetni.FieldName = "RaporMetni";
            this.colRaporMetni.Name = "colRaporMetni";
            this.colRaporMetni.Visible = true;
            this.colRaporMetni.VisibleIndex = 3;
            this.colRaporMetni.Width = 265;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Oluşturulma Tarihi";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 4;
            this.colTarih.Width = 277;
            // 
            // table_RaporlarTableAdapter
            // 
            this.table_RaporlarTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(155, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 47);
            this.label4.TabIndex = 23;
            this.label4.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(26, 12);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // FormRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1132, 702);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gridControlRaporlar);
            this.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormRaporlar";
            this.Text = " Raporlar";
            this.Load += new System.EventHandler(this.FormRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpDataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRaporlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRaporlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPDataView xpDataView1;
        private DevExpress.XtraGrid.GridControl gridControlRaporlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRaporlar;
        private System.Windows.Forms.BindingSource hastaneOtomasyonuDataSetBindingSource;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tableRaporlarBindingSource;
        private HastaneOtomasyonuDataSetTableAdapters.Table_RaporlarTableAdapter table_RaporlarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporid;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaTC;
        private DevExpress.XtraGrid.Columns.GridColumn colDoktorTC;
        private DevExpress.XtraGrid.Columns.GridColumn colRaporMetni;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}