using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using HospitalAutomation.Models;

namespace HospitalAutomation
{
    public partial class FormHastaDetay : Form
    {
        // Randevu ve Hasta servisleri için bağımlılık enjeksiyonu ile gelen referanslar
        private readonly IRandevuService randevuService;
        private readonly IHastaService hastaService;
        private BindingList<dynamic> randevularBindingList;

        // Hasta TC bilgisini tutar. Bu bilgi ile hasta detaylarına ulaşılır.
        public string hastaTC { get; set; }

        // Constructor: FormHastaDetay nesnesi oluşturulurken servisler dışarıdan alınır.
        public FormHastaDetay()
        {
            InitializeComponent();
            randevuService = new RandevuService();
            hastaService = new HastaService();

            // Randevuları listelemek için bir BindingList oluşturulur.
            randevularBindingList = new BindingList<dynamic>();
        }

        // Form yüklendiğinde hasta bilgilerini ve randevularını getirir.
        private async void FormHastaDetay_Load_1(object sender, EventArgs e)
        {
            randevularBindingList.Clear();
            FillBransComboBox();
            FillDoktorComboBox();

            try
            {
                // Hasta TC bilgisini form üzerindeki etikete yazdırır.
                labelTC.Text = hastaTC;

                // Hasta detaylarını TC bilgisine göre getirir.
                var hastaDetails = await hastaService.GetHastaByTCAsync(hastaTC);
                labelAdSoyad.Text = $"{hastaDetails.HastaAd} {hastaDetails.HastaSoyad}";

                // Hastanın randevularını getirir.
                var randevular = await randevuService.GetRandevularByHastaAsync(hastaTC);

                if (randevular == null || !randevular.Any())
                {
                    // Eğer randevu yoksa kullanıcıya bilgi verir.
                    MessageBox.Show("Randevular bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Randevular mevcutsa listeye eklenir.
                    foreach (var randevu in randevular)
                    {
                        randevularBindingList.Add(new
                        {
                            Randevu_Id = randevu.Randevuid,
                            Randevu_Branş = randevu.RandevuBrans,
                            Randevu_Durum = randevu.RandevuDurum,
                            Randevu_Doktor = randevu.RandevuDoktor,
                            Hasta_TC = randevu.HastaTC,
                            Hasta_Sikayet = randevu.HastaSikayet,
                            Randevu_Tarih = randevu.RandevuTarih,
                            Randevu_Saat = randevu.RandevuSaat,
                        });
                    }
                    // Randevular grid kontrolüne yüklenir.
                    gridControl1.DataSource = randevularBindingList;
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya bilgi verir.
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //// Doktor seçildiğinde, bu doktora ait müsait randevular getirilir.
        private async void comboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(comboBoxDoktor.Text))
                {
                    // Seçilen doktor ve branşa göre müsait randevular grid'e yüklenir.
                    var randevular = await randevuService.GetAvailableRandevularAsync(comboBoxBrans.Text, comboBoxDoktor.Text);
                    gridControl1.DataSource = randevular;
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya bilgi verir.
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Randevu geçmişi sekmesine geçiş için kullanılır.
        private void accordionCtrlRandevuGecmisi_Click(object sender, EventArgs e)
        {
            FormHastaRandevuGecmisi frg = new FormHastaRandevuGecmisi();
            frg.HastaTC = labelTC.Text; // Hasta TC bilgisi aktarılır.
            frg.Show();
        }

        // Bilgi düzenleme sekmesine geçiş için kullanılır.
        private void accordionCtrlBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FormHastaBilgiDuzenle fr = new FormHastaBilgiDuzenle();
            fr.TCNOhasta = labelTC.Text; // Hasta TC bilgisi aktarılır.
            fr.Show();
        }

        // Randevu al butonuna basıldığında, seçilen randevu alınır.
        private async void buttonRandevuAl_Click_1(object sender, EventArgs e)
        {
            try
            {
                // GridView'de seçilen randevunun ID'sini alır.
                int randevuId = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "Randevu_Id").ToString());

                // Randevu güncellenir ve hasta şikayeti kaydedilir.
                bool isSuccess = await randevuService.UpdateRandevuAsync(hastaTC, richTextBoxSikayet.Text, randevuId);
                if (isSuccess)
                {
                    // Başarılı bir şekilde randevu alındığında kullanıcı bilgilendirilir.
                    MessageBox.Show("Randevu Alındı", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hata durumunda kullanıcı bilgilendirilir.
                    MessageBox.Show("Randevu alınırken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya bilgi verir.
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Raporlar sekmesine geçiş için kullanılır.
        private void accordionCtrlRaporlar_Click_1(object sender, EventArgs e)
        {
            FormRaporlar fr = new FormRaporlar();
            fr.hastaID = labelTC.Text; // Hasta TC bilgisi aktarılır.
            fr.Show();
        }

        private async void FillBransComboBox()
        {
            comboBoxBrans.Items.Clear();
            // Branşları al ve combobox'a ekle
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

        private async void FillDoktorComboBox(string bransAd = null)
        {
            // Doktorları al ve combobox'a ekle
            comboBoxDoktor.Items.Clear();
            var doktorlar = string.IsNullOrEmpty(bransAd) ? await randevuService.GetDoktorlarByBransAsync("") : await randevuService.GetDoktorlarByBransAsync(bransAd);
            if (doktorlar.Count() > 0)
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

        private async void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Seçilen branş ve doktoru al
                string selectedBrans = comboBoxBrans.SelectedItem?.ToString();
                string selectedDoktor = comboBoxDoktor.SelectedItem?.ToString();

                // Eğer hem branş hem de doktor seçiliyse randevuları getir
                if (!string.IsNullOrEmpty(selectedBrans) && !string.IsNullOrEmpty(selectedDoktor))
                {
                    randevularBindingList.Clear();
                    // Randevu verilerini senkron olarak al
                    List<Randevu> randevular = await randevuService.GetAvailableRandevularAsync(selectedBrans, selectedDoktor);
                    if (randevular.Count()>0)
                    {
                        foreach (var randevu in randevular)
                        {
                            randevularBindingList.Add(new
                            {
                                Randevu_Id = randevu.Randevuid,
                                Randevu_Branş = randevu.RandevuBrans,
                                Randevu_Durum = randevu.RandevuDurum,
                                Randevu_Doktor = randevu.RandevuDoktor,
                                Hasta_TC = randevu.HastaTC,
                                Hasta_Sikayet = randevu.HastaSikayet,
                                Randevu_Tarih = randevu.RandevuTarih,
                                Randevu_Saat = randevu.RandevuSaat,
                            });
                        }
                        gridControl1.DataSource = randevularBindingList;
                    }
                }
                else
                {
                    // Seçim yapılmadıysa grid temizlenir
                    gridControl1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();

            if (row != null)
            {
                comboBoxBrans.Text = row["BransAd"].ToString();
                // Doktor adı ve soyadını birleştirerek ComboBox'a ekle
                string doktorAdSoyad = row["DoktorAd"].ToString() + " " + row["DoktorSoyad"].ToString();
                comboBoxDoktor.Text = doktorAdSoyad;
            }
        }

        private void accordionCtrlCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}