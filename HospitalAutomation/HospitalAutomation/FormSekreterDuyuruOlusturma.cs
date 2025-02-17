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
    public partial class FormSekreterDuyuruOlusturma : Form
    {
        // IDuyuruService arayüzüne bağımlılık ekleniyor. Bağımlılık enjekte ediliyor.
        private readonly IDuyuruService duyuruService;

        // Formun yapıcı metodu, bileşenleri başlatır ve servis örneğini oluşturur.
        public FormSekreterDuyuruOlusturma()
        {
            InitializeComponent();
            // Duyuru servisi başlatılıyor. Bağımlılık burada manuel olarak atanıyor.
            duyuruService = new DuyuruService();
        }

        // 'Oluştur' butonuna tıklanıldığında çalışan olay metodu.
        private void simpleBtnOlustur_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan duyuru metnini alıyoruz ve değişkene atıyoruz.
            string duyuruMetni = richTextBoxDuyuru.Text;

            // Kullanıcı duyuru metnini boş bırakmışsa uyarı veriyoruz.
            if (string.IsNullOrEmpty(duyuruMetni))
            {
                MessageBox.Show("Lütfen duyuru metnini girin.");
                return; // Metin boşsa işlem sonlandırılıyor.
            }

            // Yeni bir duyuru nesnesi oluşturuluyor ve metin atanıyor.
            Duyuru yeniDuyuru = new Duyuru
            {
                DuyuruMetni = duyuruMetni
            };

            // Duyuru servisini kullanarak yeni duyuruyu veritabanına ekliyoruz.
            bool sonuc = duyuruService.AddDuyuru(yeniDuyuru);

            // Duyuru eklenme işlemi başarılıysa bilgilendirme mesajı gösteriliyor.
            if (sonuc)
            {
                MessageBox.Show("Duyuru başarıyla oluşturuldu.");
            }
            else
            {
                // Başarısız olursa hata mesajı gösteriliyor.
                MessageBox.Show("Duyuru oluşturulurken bir hata oluştu.");
            }
        }
    }
}
