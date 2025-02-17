namespace HospitalAutomation
{
    partial class FormHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaKayit));
            this.textSifre = new System.Windows.Forms.TextBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(190, 188);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(131, 31);
            this.textSifre.TabIndex = 5;
//            this.textSifre.TextChanged += new System.EventHandler(this.textSifre_TextChanged);
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(191, 105);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(131, 31);
            this.maskedTC.TabIndex = 3;
  //          this.maskedTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTC_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
    //        this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
      //      this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(189, 12);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(131, 31);
            this.textAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(189, 59);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(131, 31);
            this.textSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // maskedTelefonNo
            // 
            this.maskedTelefonNo.Location = new System.Drawing.Point(190, 145);
            this.maskedTelefonNo.Mask = "(999) 000-0000";
            this.maskedTelefonNo.Name = "maskedTelefonNo";
            this.maskedTelefonNo.Size = new System.Drawing.Size(130, 31);
            this.maskedTelefonNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon:";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboCinsiyet.Location = new System.Drawing.Point(189, 228);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(132, 31);
            this.comboCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // buttonKayitYap
            // 
            this.buttonKayitYap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonKayitYap.Location = new System.Drawing.Point(189, 275);
            this.buttonKayitYap.Name = "buttonKayitYap";
            this.buttonKayitYap.Size = new System.Drawing.Size(131, 31);
            this.buttonKayitYap.TabIndex = 17;
            this.buttonKayitYap.Text = "Kayıt Yap";
            this.buttonKayitYap.UseVisualStyleBackColor = false;
            this.buttonKayitYap.Click += new System.EventHandler(this.buttonKayitYap_Click);
            // 
            // FormHastaKayit
            // 
            this.AcceptButton = this.buttonKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.buttonKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.maskedTelefonNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.maskedTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormHastaKayit";
            this.Text = " Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTelefonNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKayitYap;
    }
}