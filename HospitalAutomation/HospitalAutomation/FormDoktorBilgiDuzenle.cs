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
using HospitalAutomation.Models;
using HospitalAutomation.Services;

namespace HospitalAutomation
{
    public partial class FormDoktorBilgiDuzenle : Form
    {
        private IDoktorService doktorService;
        private Doktor doktor;
        public string TCNOdoktor { get; set; }

        // Consturctor
        public FormDoktorBilgiDuzenle()
        {
            InitializeComponent();
            doktorService = new DoktorService();
        }

        //  Form açıldığında tetiklenir (event handler)
        private async void FormDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            // TC kimlik numarasına göre doktor bilgilerini veritabanından asenkron olarak çeker.
            doktor = await doktorService.GetDoktorByTCAsync(TCNOdoktor);

            // Çekilen bilgileri form üzerindeki kutulara yazdır
            ViewDoktorInfo();
        }

        // Doktor bilgilerini text'lerde görüntülüyoruz
        private void ViewDoktorInfo()
        {
            textAd.Text = doktor.DoktorAd;
            textSoyad.Text = doktor.DoktorSoyad;
            comboBrans.Text = doktor.DoktorBrans;
            maskedTC.Text = doktor.DoktorTC;
            textSifre.Text = doktor.DoktorSifre;
        }

        private void buttonBilgiGuncelle_Click(object sender, EventArgs e)
        {
            UpdateDoktorInfo();
        }

        // Doktor bilgilerini güncelliyoruz
        private async void UpdateDoktorInfo()
        {
            try
            {
                if (CheckDoktorValues())
                {
                    doktor.DoktorAd = textAd.Text;
                    doktor.DoktorSoyad = textSoyad.Text;
                    doktor.DoktorTC = maskedTC.Text;
                    doktor.DoktorSifre = textSifre.Text;
                    doktor.DoktorBrans = comboBrans.Text;
                    if(await doktorService.UpdateDoktorAsync(doktor))
                        MessageBox.Show("Bilgileriniz güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        // Doktor tüm bilgilerini eksiksiz girmiş mi kontrol ediyoruz
        private bool CheckDoktorValues()
        {
            if (string.IsNullOrEmpty(textAd.Text) ||
                 string.IsNullOrEmpty(textSoyad.Text) ||
                 string.IsNullOrEmpty(maskedTC.Text) ||
                 string.IsNullOrEmpty(textSifre.Text) ||
                 string.IsNullOrEmpty(comboBrans.Text))
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
