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
    public partial class FormHastaKayit : Form
    {

        private IHastaService hastaService;

        public FormHastaKayit()
        {
            InitializeComponent();
            hastaService = new HastaService();
            
        }

        private async void buttonKayitYap_Click(object sender, EventArgs e)
        {
            // Gerekli alanların dolu olup olmadığını kontrol et
            if (string.IsNullOrEmpty(textAd.Text) || string.IsNullOrEmpty(textSoyad.Text) ||
                string.IsNullOrEmpty(maskedTC.Text) || string.IsNullOrEmpty(maskedTelefonNo.Text) ||
                string.IsNullOrEmpty(textSifre.Text) || string.IsNullOrEmpty(comboCinsiyet.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            // Yeni hasta nesnesi oluştur
            Hasta newHasta = new Hasta
            {
                HastaAd = textAd.Text,
                HastaSoyad = textSoyad.Text,
                HastaTC = maskedTC.Text,
                HastaTelefon = maskedTelefonNo.Text,
                HastaSifre = textSifre.Text,
                HastaCinsiyet = comboCinsiyet.Text
            };

            // Servisi kullanarak hasta ekle
            bool isAdded = await hastaService.AddHastaAsync(newHasta);

            if (isAdded)
            {
                MessageBox.Show("Kaydınız başarıyla oluşturuldu. Şifreniz: " + newHasta.HastaSifre, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
