namespace HospitalAutomation
{
    partial class FormHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaBilgiDuzenle));
            this.buttonBilgiGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBilgiGuncelle
            // 
            this.buttonBilgiGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBilgiGuncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBilgiGuncelle.Location = new System.Drawing.Point(152, 302);
            this.buttonBilgiGuncelle.Name = "buttonBilgiGuncelle";
            this.buttonBilgiGuncelle.Size = new System.Drawing.Size(131, 31);
            this.buttonBilgiGuncelle.TabIndex = 30;
            this.buttonBilgiGuncelle.Text = "Güncelle";
            this.buttonBilgiGuncelle.UseVisualStyleBackColor = false;
            this.buttonBilgiGuncelle.Click += new System.EventHandler(this.buttonBilgiGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet:";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboCinsiyet.Location = new System.Drawing.Point(153, 255);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(132, 31);
            this.comboCinsiyet.TabIndex = 6;
            // 
            // maskedTelefonNo
            // 
            this.maskedTelefonNo.Location = new System.Drawing.Point(153, 172);
            this.maskedTelefonNo.Mask = "(999) 000-0000";
            this.maskedTelefonNo.Name = "maskedTelefonNo";
            this.maskedTelefonNo.Size = new System.Drawing.Size(130, 31);
            this.maskedTelefonNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon:";
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(152, 86);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(131, 31);
            this.textSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad:";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(152, 39);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(131, 31);
            this.textAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ad:";
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(153, 215);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(131, 31);
            this.textSifre.TabIndex = 5;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(152, 132);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(131, 31);
            this.maskedTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FormHastaBilgiDuzenle
            // 
            this.AcceptButton = this.buttonBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(353, 398);
            this.Controls.Add(this.buttonBilgiGuncelle);
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
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormHastaBilgiDuzenle";
            this.Text = " Hasta Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.FormBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBilgiGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTelefonNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}