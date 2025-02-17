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
    public partial class FormSekreterDetay : Form
    {
        // Sekreter ve randevu servislerini temsil eden değişkenler tanımlandı.
        private readonly ISekreterService sekreterService;
        private readonly IRandevuService randevuService;

        // Sekreterin TC kimlik numarasını saklayan bir özellik tanımlandı.
        public string sekreterTC { get; set; }

        // Yapıcı metot: Form ilk yüklendiğinde çalışır ve servis nesnelerini başlatır.
        public FormSekreterDetay()
        {
            InitializeComponent(); // Form bileşenlerini başlatır.

            // Servis sınıfları örnekleniyor.
            sekreterService = new SekreterService();
            randevuService = new RandevuService();
        }

        // Form yüklendiğinde çalışan asenkron metod.
        private async void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            try
            {
                // Sekreter TC numarası etikete atanıyor.
                labelTC.Text = sekreterTC;

                // Sekreterin kimlik numarasına göre bilgileri veri tabanından çekiliyor.
                var sekreterDetails = await sekreterService.GetSekreterByTCAsync(sekreterTC);

                // Sekreterin adı soyadı etikete yazdırılıyor.
                labelAdSoyad.Text = $"{sekreterDetails.SekreterAdSoyad}";
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya mesaj kutusu ile hata mesajı gösterilir.
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Hatanın yukarıya fırlatılması sağlanır.
            }
        }

        // Doktor Paneli butonuna tıklandığında çalışır ve doktor panelini açar.
        private void accordionCtrlDoktorPnl_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli drp = new FormDoktorPaneli();
            drp.Show();
        }

        // Branş Paneli butonuna tıklandığında çalışır ve branş panelini açar.
        private void accordionCtrlBransPnl_Click(object sender, EventArgs e)
        {
            FormBransPaneli frm = new FormBransPaneli();
            frm.Show();
        }

        // Randevu Listesi butonuna tıklandığında çalışır ve randevu listesini açar.
        private void accordionCtrlRandevuLst_Click(object sender, EventArgs e)
        {
            FormRandevuListesi frl = new FormRandevuListesi();
            frl.Show();
        }

        // Duyurular butonuna tıklandığında çalışır ve duyurular penceresini açar.
        private void accordionCtrlDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular frd = new FormDuyurular();
            frd.Show();
        }

        // Sekreter duyuru oluşturma butonuna tıklandığında çalışır ve ilgili formu açar.
        private void accordionCtrlDuyuruOlusturma_Click(object sender, EventArgs e)
        {
            FormSekreterDuyuruOlusturma frdo = new FormSekreterDuyuruOlusturma();
            frdo.Show();
        }

        // Sekreter randevu oluşturma butonuna tıklandığında çalışır ve ilgili formu açar.
        private void accordionCtrlRandevuOlusturma_Click(object sender, EventArgs e)
        {
            FormSekreterRandevuOlusturma frro = new FormSekreterRandevuOlusturma();
            frro.Show();
        }

        // Çıkış butonuna tıklandığında çalışır ve uygulamayı kapatır.
        private void accordionCtrlCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
