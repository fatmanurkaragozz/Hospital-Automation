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

namespace HospitalAutomation
{
    public partial class FormHastaRandevuGecmisi : Form
    {
        // IRandevuService arayüzüne dayalı randevu servisi nesnesi
        private readonly IRandevuService randevuService;

        // Hastanın TC kimlik numarasını tutan özellik
        public string HastaTC { get; set; }

        // Form constructor'ı
        public FormHastaRandevuGecmisi()
        {
            InitializeComponent();
            // Randevu servisini başlat
            randevuService = new RandevuService();
        }

        // Form yüklendiğinde çalışacak olan asenkron metod
        private async void FormHastaRandevuGeçmişi_Load(object sender, EventArgs e)
        {
            try
            {
                // Hasta TC'sine göre randevuları almak için randevu servisini çağırıyoruz
                var randevular = await randevuService.GetRandevularByHastaAsync(HastaTC);

                // Alınan randevuları gridControl2 kontrolüne veri kaynağı olarak bağlıyoruz
                gridControl2.DataSource = randevular;
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya mesaj ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
