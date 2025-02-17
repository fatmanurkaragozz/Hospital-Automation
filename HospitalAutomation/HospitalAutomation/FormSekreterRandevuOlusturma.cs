using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using HospitalAutomation.Models;


namespace HospitalAutomation
{
    public partial class FormSekreterRandevuOlusturma : Form
    {
        private readonly IRandevuService randevuService; // Randevu işlemlerini yönetmek için servis sınıf

        public FormSekreterRandevuOlusturma()
        {
            InitializeComponent(); // Form elemanlarını başlat
            randevuService = new RandevuService(); // Randevu servisini başlat
        }

        private void FormSekreterRandevuOlusturma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet2.Table_Doktorlar' table. You can move, or remove it, as needed.
            this.table_DoktorlarTableAdapter.Fill(this.hastaneOtomasyonuDataSet2.Table_Doktorlar);
            // TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet1.Table_Branslar' table. You can move, or remove it, as needed.
            this.table_BranslarTableAdapter.Fill(this.hastaneOtomasyonuDataSet1.Table_Branslar);

            // GridView satır değişim olaylarını dinliyoruz
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView2.FocusedRowChanged += gridView2_FocusedRowChanged;

            // Branş ve doktorları comboboxlara doldur
            FillBransComboBox();
            // Başlangıçta doktorları listele (tüm doktorlar)
            FillDoktorComboBox();
        }

        private async void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı girişlerinden randevu nesnesi oluştur
                var randevu = new Randevu
                {
                    RandevuTarih = maskedTextBoxtarih.Text,
                    RandevuSaat = maskedTextBoxSaat.Text,
                    RandevuBrans = comboBoxBrans.SelectedItem?.ToString(),
                    RandevuDoktor = comboBoxDoktor.SelectedItem?.ToString(),
                    HastaTC = maskedTextBoxTC.Text,
                    RandevuDurum = checkBoxDurum.Checked
                };

                // Randevuyu veritabanına ekle
                bool isCreated = await randevuService.CreateRandevuAsync(randevu);

                if (isCreated)
                {
                    MessageBox.Show("Randevu başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm(); // Formu sıfırla
                }
                else
                {
                    MessageBox.Show("Randevu oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Formu sıfırlayan metod
        private void ResetForm()
        {
            maskedTextBoxtarih.Clear(); // Tarih sıfırla
            maskedTextBoxSaat.Clear(); // Saat sıfırla
            comboBoxBrans.SelectedIndex = -1; // Branş sıfırla
            comboBoxDoktor.SelectedIndex = -1; // Doktor sıfırla
            maskedTextBoxTC.Clear(); // TC sıfırla
            checkBoxDurum.Checked = false; // Durum sıfırla
        }

        // Branşları comboboxa ekleyen metod
        private async void FillBransComboBox()
        {
            comboBoxBrans.Items.Clear();
            
            var branslar = await randevuService.GetAllBranslarAsync();

            if (branslar.Count() > 0)
            {
                comboBoxBrans.Enabled = true;
                foreach (var brans in branslar)
                {
                    comboBoxBrans.Items.Add(brans);
                }
                comboBoxBrans.SelectedIndex = 0; // İlk öğeyi seçer
            }
            else
            {
                comboBoxBrans.Text = "Kayıtlı branş bulunmamaktadır!";
                comboBoxBrans.Enabled = false;
            }
        }

        // Seçilen branşa göre doktorları comboboxa ekleyen metod
        private async void FillDoktorComboBox(string bransAd = null)
        {
            // Doktorları al ve combobox'a ekle
            comboBoxDoktor.Items.Clear();

            var doktorlar = string.IsNullOrEmpty(bransAd) ? await randevuService.GetDoktorlarByBransAsync("") : await randevuService.GetDoktorlarByBransAsync(bransAd);

            if (doktorlar.Count()>0)
            {
                comboBoxDoktor.Enabled = true;

                foreach (var doktor in doktorlar)
                {
                    comboBoxDoktor.Items.Add(doktor);
                }
                comboBoxDoktor.SelectedIndex = 0; // İlk öğeyi seçer
            }
            else
            {
                comboBoxDoktor.Text = "Seçilen branşta doktor bulunmamaktadır!";
                comboBoxDoktor.Enabled = false;
            }

        }


        // Branş seçiminde GridView2 olayını dinleyen metod
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Seçilen satırdaki doktor ad soyad ve branş bilgisini al
            var row = gridView2.GetFocusedDataRow(); // Seçili satırın verisini alır

            if (row != null)
            {
                comboBoxBrans.Text = row["DoktorBrans"].ToString();

                // Doktor adı ve soyadını birleştirerek ComboBox'a ekle
                string doktorAdSoyad = row["DoktorAd"].ToString() + " " + row["DoktorSoyad"].ToString();
                comboBoxDoktor.Text = doktorAdSoyad;
            }
        }

        // Branş GridView1 için satır değişikliğini dinleyen metod
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row != null)
            {
                comboBoxBrans.Text = row["BransAd"].ToString();
            }
        }

        // Kullanıcı branş seçtiğinde doktor listesini günceller
        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen branşı al
            string selectedBrans = comboBoxBrans.SelectedItem?.ToString();

            // Eğer branş seçiliyse, o branşa ait doktorları göster
            if (!string.IsNullOrEmpty(selectedBrans))
            {
                FillDoktorComboBox(selectedBrans);
            }
            else
            {
                // Branş seçili değilse, tüm doktorları listele
                FillDoktorComboBox();
            }
        }
    }
}
