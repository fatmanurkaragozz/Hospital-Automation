namespace HospitalAutomation
{
    partial class FormDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuyurular));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hastaneOtomasyonuDataSet6 = new HospitalAutomation.HastaneOtomasyonuDataSet6();
            this.tableDuyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_DuyurularTableAdapter = new HospitalAutomation.HastaneOtomasyonuDataSet6TableAdapters.Table_DuyurularTableAdapter();
            this.colDuyuruid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuyuru = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDuyurularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 21;
            this.label2.Text = "DEVA HASTANESİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tableDuyurularBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 97);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(781, 353);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDuyuruid,
            this.colDuyuru});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // hastaneOtomasyonuDataSet6
            // 
            this.hastaneOtomasyonuDataSet6.DataSetName = "HastaneOtomasyonuDataSet6";
            this.hastaneOtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDuyurularBindingSource
            // 
            this.tableDuyurularBindingSource.DataMember = "Table_Duyurular";
            this.tableDuyurularBindingSource.DataSource = this.hastaneOtomasyonuDataSet6;
            // 
            // table_DuyurularTableAdapter
            // 
            this.table_DuyurularTableAdapter.ClearBeforeFill = true;
            // 
            // colDuyuruid
            // 
            this.colDuyuruid.FieldName = "Duyuruid";
            this.colDuyuruid.Name = "colDuyuruid";
            this.colDuyuruid.Visible = true;
            this.colDuyuruid.VisibleIndex = 0;
            this.colDuyuruid.Width = 63;
            // 
            // colDuyuru
            // 
            this.colDuyuru.FieldName = "Duyuru";
            this.colDuyuru.Name = "colDuyuru";
            this.colDuyuru.Visible = true;
            this.colDuyuru.VisibleIndex = 1;
            this.colDuyuru.Width = 700;
            // 
            // FormDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormDuyurular";
            this.Text = " Duyurular";
            this.Load += new System.EventHandler(this.FormDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDuyurularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HastaneOtomasyonuDataSet6 hastaneOtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource tableDuyurularBindingSource;
        private HastaneOtomasyonuDataSet6TableAdapters.Table_DuyurularTableAdapter table_DuyurularTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDuyuruid;
        private DevExpress.XtraGrid.Columns.GridColumn colDuyuru;
    }
}