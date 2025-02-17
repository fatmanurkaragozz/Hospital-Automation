using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;
using HospitalAutomation.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FormDoktorPaneli : Form
    {
        private readonly IDoktorService doktorService;
        private readonly IBransService bransService;

        public FormDoktorPaneli()
        {
            InitializeComponent();
            doktorService = new DoktorService();
            bransService = new BransService();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet11.Table_Doktorlar' table. You can move, or remove it, as needed.
            this.table_DoktorlarTableAdapter1.Fill(this.hastaneOtomasyonuDataSet11.Table_Doktorlar);

            // Doktorlar tablosunu doldur
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            gridControlDoktorlar.DataSource = dt1;

            // Branşları combobox'a ekle
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private async void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kontrolleri çağır
                if (!CheckValues()) return;

                Doktor doktor = new Doktor
                {
                    DoktorAd = textBoxAd.Text,
                    DoktorSoyad = textBoxSoyad.Text,
                    DoktorBrans = comboBoxBrans.Text,
                    DoktorTC = maskedTextBoxTC.Text,
                    DoktorSifre = textBoxSifre.Text
                };

                bool result = await doktorService.AddDoktorAsync(doktor);
                if (result)
                {
                    MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Veriyi tekrar yükleyin ya da formu güncelleyin
                }
                else
                {
                    MessageBox.Show("Doktor eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Kontrolleri çağır
                if (!CheckValues()) return;

                bool result = await doktorService.DeleteDoktorAsync(maskedTextBoxTC.Text);
                if (result)
                {
                    MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Veriyi tekrar yükleyin ya da formu güncelleyin
                }
                else
                {
                    MessageBox.Show("Doktor silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kontrolleri çağır
                if (!CheckValues()) return;

                Doktor doktor = new Doktor
                {
                    DoktorAd = textBoxAd.Text,
                    DoktorSoyad = textBoxSoyad.Text,
                    DoktorBrans = comboBoxBrans.Text,
                    DoktorSifre = textBoxSifre.Text,
                    DoktorTC = maskedTextBoxTC.Text
                };

                bool result = await doktorService.UpdateDoktorAsync(doktor);
                if (result)
                {
                    MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Veriyi tekrar yükleyin ya da formu güncelleyin
                }
                else
                {
                    MessageBox.Show("Doktor güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kontrolleri yapan metot
        private bool CheckValues()
        {
            // Tüm alanları doldurduğunuzdan emin olun
            if (string.IsNullOrWhiteSpace(textBoxAd.Text) || string.IsNullOrWhiteSpace(textBoxSoyad.Text) ||
                string.IsNullOrWhiteSpace(comboBoxBrans.Text) || string.IsNullOrWhiteSpace(maskedTextBoxTC.Text) ||
                string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // TC'nin 11 karakter olup olmadığını kontrol et
            if (maskedTextBoxTC.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // TC'nin sadece rakamlardan oluştuğuna emin ol
            if (!long.TryParse(maskedTextBoxTC.Text, out _))
            {
                MessageBox.Show("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void gridViewDoktorlar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridViewDoktorlar.GetFocusedDataRow(); // Seçili satırın verisini al

            if(row != null)
            {
                textBoxAd.Text = row["DoktorAd"].ToString();
                textBoxSoyad.Text = row["DoktorSoyad"].ToString();
                comboBoxBrans.Text = row["DoktorBrans"].ToString();
                maskedTextBoxTC.Text = row["DoktorTC"].ToString();
                textBoxSifre.Text = row["DoktorSifre"].ToString();
            }
        }
    }
}
