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
    // partial kullanılmasının nedeni, sınıfın farklı dosyalara bölünerek tanımlanabilmesini sağlamaktır
    // Formun tasarımına ait dosya (FormBilgiDuzenle.Designer.cs) ve formun mantığına (event handling gibi) 
    // ait dosya (FormBilgiDuzenle.cs) aynı sınıfı paylaşır.

    public partial class FormHastaBilgiDuzenle : Form
    {
        private IHastaService hastaService; // hastaService, IHastaService arayüzünü implemente eden servis sınıfını temsil eder
        private Hasta hasta;  // Hasta modelinden hasta nesnesi oluşturduk, hasta bilgileri burada saklanır
        public string TCNOhasta { get; set; } // Dışarıdan TC Kimlik No'yu alacak olan bir özellik (property).

        // Consturctor (Yapıcı Metot)
        public FormHastaBilgiDuzenle()
        {
            InitializeComponent(); // Form üzerindeki tüm kontrolleri (textbox, button) başlatır.
            hastaService = new HastaService(); // HastaService sınıfından bir nesne türetir.
        }

        // Form açıldığında tetiklenir (event handler).
        private async void FormBilgiDuzenle_Load(object sender, EventArgs e)
        {
            // TC kimlik numarasına göre hasta bilgilerini veritabanından asenkron olarak çeker.
            hasta = await hastaService.GetHastaByTCAsync(TCNOhasta);

            // Çekilen bilgileri form üzerindeki kutulara yansıtır
            ViewHastaInfo();

        }

        // Hasta bilgilerini güncelliyoruz
        private void buttonBilgiGuncelle_Click(object sender, EventArgs e)
        {
            // Hasta bilgilerini güncelleyen metodu çağırır.
            UpdateHastaInfo();
        }

        // Hasta bilgilerini text'lerde görüntülüyoruz
        private void ViewHastaInfo()
        {
            textAd.Text = hasta.HastaAd;
            textSoyad.Text = hasta.HastaSoyad;
            maskedTC.Text = hasta.HastaTC;
            maskedTelefonNo.Text = hasta.HastaTelefon;
            textSifre.Text = hasta.HastaSifre;
            comboCinsiyet.Text = hasta.HastaCinsiyet;
        }

        // Hasta bilgilerini güncelliyoruz
        private async void UpdateHastaInfo()
        {
            try
            {
                // TC numarasının 11 haneli olup olmadığını kontrol et
                if (maskedTC.Text.Length != 11)
                {
                    MessageBox.Show("TC numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Telefon numarasının 10 haneli olup olmadığını ve doğru formatta olup olmadığını kontrol et
                string telefonNumarasi = maskedTelefonNo.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                if (telefonNumarasi.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(maskedTelefonNo.Text, @"^\(\d{3}\) \d{3}-\d{4}$"))
                {
                    MessageBox.Show("Telefon numarasını doğru formatta giriniz. Format: (999) 000-0000", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CheckHastaValues())
                {
                    hasta.HastaAd = textAd.Text;
                    hasta.HastaSoyad = textSoyad.Text;
                    hasta.HastaTC = maskedTC.Text;
                    hasta.HastaTelefon = maskedTelefonNo.Text;
                    hasta.HastaSifre = textSifre.Text;
                    hasta.HastaCinsiyet = comboCinsiyet.Text;
                    if (await hastaService.UpdateHastaInfoAsync(hasta))
                        MessageBox.Show("Bilgileriniz güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }

        }

        // Hasta tüm bilgilerini eksiksiz girmiş mi kontrol ediyoruz
        private bool CheckHastaValues()
        {
            if (string.IsNullOrEmpty(textAd.Text) ||
                string.IsNullOrEmpty(textSoyad.Text) ||
                string.IsNullOrEmpty(maskedTC.Text) ||
                string.IsNullOrEmpty(maskedTelefonNo.Text) ||
                string.IsNullOrEmpty(textSifre.Text) ||
                string.IsNullOrEmpty(comboCinsiyet.Text))
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
