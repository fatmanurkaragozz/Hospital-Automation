using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;
using System.Windows.Forms;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using HospitalAutomation.Models;

namespace HospitalAutomation
{
    public partial class FormDoktorDetay : Form
    {
        // Doktor, Randevu ve Rapor servisleri için bağımlılık enjeksiyonu ile gelen referanslar
        private readonly IDoktorService doktorService;
        private readonly IRandevuService randevuService;
        private readonly IRaporService raporService;

        private BindingList<dynamic> randevularBindingList;

        public string doktorTC { get; set; }
        public string doktorAdSoyad { get; set; }

        // Constructor
        public FormDoktorDetay()
        {
            InitializeComponent();
            doktorService = new DoktorService();
            randevuService = new RandevuService();
            raporService = new RaporService();

            // Randevuları listelemek için BindingList oluşturulur.
            randevularBindingList = new BindingList<dynamic>();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        

        private async void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            randevularBindingList.Clear();

            try
            {
                // Doktor TC bilgisini form üzerindeki etikete yazdırır
                labelTC.Text = doktorTC;

                // Doktor detaylarını TC bilgisine göre getirir
                var doktorDetails = await doktorService.GetDoktorByTCAsync(doktorTC);

                doktorAdSoyad = $"{doktorDetails.DoktorAd} {doktorDetails.DoktorSoyad}";
                labelAdSoyad.Text = doktorAdSoyad;

                // Doktorun randevularını getirir
                var randevular = await randevuService.GetRandevularByDoktorTCAsync(doktorTC);

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
                            Randevu_Tarih = randevu.RandevuTarih,
                            Randevu_Saat = randevu.RandevuSaat,
                            Randevu_Branş = randevu.RandevuBrans,
                            Randevu_Doktor = randevu.RandevuDoktor,
                            Randevu_Durum = randevu.RandevuDurum,
                            Hasta_TC = randevu.HastaTC,
                            Hasta_Sikayet = randevu.HastaSikayet,
                            
                        });
                    }
                    // Randevular grid kontrolüne yüklenir.
                    gridControl2.DataSource = randevularBindingList;
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya bilgi verir.
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // GridControl ile GridView'ın FocusedRowChanged olayını bağla
            gridView2.FocusedRowChanged += gridView2_FocusedRowChanged_1;
        }
       
        private void ButtonRaporuGonder_Click(object sender, EventArgs e)
        {
            // gridView1 üzerinde seçilen satırın verisine erişin
            string hastaTC = gridView2.GetFocusedRowCellDisplayText("Hasta_TC"); // Seçilen satırı alır
            if (!string.IsNullOrEmpty(hastaTC))
            { // "HastaTC" sütunundan veri al

                // Raporu kaydet
                SqlCommand komut = new SqlCommand("INSERT INTO Table_Raporlar (HastaTC, DoktorTC, RaporMetni, Tarih) VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", hastaTC);
                komut.Parameters.AddWithValue("@p2", labelTC.Text);
                komut.Parameters.AddWithValue("@p3", richTextBoxRapor.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Rapor başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // RichTextBox'ı temizle
                richTextBoxRapor.Clear();
            }
            else
            {
                MessageBox.Show("Bu randevu herhangi bir hasta tarafından alınmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void accordionCtrlBilgiDuzen_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDuzenle frd = new FormDoktorBilgiDuzenle();
            frd.TCNOdoktor = labelTC.Text;
            frd.Show();
        }

        private void accordionCtrlDuyuru_Click(object sender, EventArgs e)
        {
            FormDuyurular frd = new FormDuyurular();
            frd.Show();
        }

        private void accordionCtrlCikiss_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView2_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
        {
            // Seçilen satırdaki şikayet bilgisini al
            string sikayet = gridView2.GetFocusedRowCellDisplayText("Hasta_Sikayet"); // Seçili satırın verisini alır

            if (!string.IsNullOrEmpty(sikayet))
                richTextBoxSikayet.Text = sikayet;
            else
                richTextBoxSikayet.Text = sikayet;
        }
    }
}
