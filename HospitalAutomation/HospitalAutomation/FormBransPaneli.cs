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
    // partial kullanılmasının nedeni, sınıfın farklı dosyalara bölünerek tanımlanabilmesini sağlamaktır.
    // Formun tasarımına ait dosya (FormBransPaneli.Designer.cs) ve formun mantığına (event handling gibi) 
    // ait dosya (FormBransPaneli.cs) aynı sınıfı paylaşır.

    public partial class FormBransPaneli : Form
    {
        private IBransService bransService; // Branş işlemleri için servis katmanı
        private Brans brans; // Brans modelinden bir nesne oluşturuldu

        // Constructor: Form başlatıldığında çalışır.
        public FormBransPaneli()
        {
            InitializeComponent(); // Formun kontrollerini başlatır
            brans = new Brans();
            bransService = new BransService();  // Brans servisinden bir nesne oluşturuldu
        }


        // SqlBaglantisi bgl = new SqlBaglantisi();

        // Form yüklendiğinde çalışan event
        private void FormBransPaneli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet4.Table_Branslar' table. You can move, or remove it, as needed.
            //this.table_BranslarTableAdapter.Fill(this.hastaneOtomasyonuDataSet4.Table_Branslar);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Branslar", bgl.baglanti());
            //da.Fill(dt);
            //gridControlBranslar.DataSource = dt;

            // Form yüklendiğinde tüm branşları listeleyen kod
            gridControlBranslar.DataSource = bransService.GetAllBranches();
            gridViewBranslar.FocusedRowChanged += gridViewBranslar_FocusedRowChanged;

        }

        // Yeni branş ekleme butonuna tıklandığında çalışır
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                brans.Bransid = int.Parse(textBoxBransid.Text); // Brans ID değerini alır
                brans.BransAd = textBoxBransAd.Text; // Brans Ad değerini alır
                bransService.AddBranch(brans); // Brans servisine ekler
                MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Kullanıcıya hata mesajı gösterir
                MessageBox.Show("Lütfen geçerli değerler giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Grid üzerindeki satır değiştiğinde tetiklenir, seçili satırdaki verileri forma yansıtır
        private void gridViewBranslar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int selectedRowHandle = gridViewBranslar.FocusedRowHandle;

            if (selectedRowHandle >= 0)
            {
                // Seçili satırdaki bilgileri formdaki kutulara yansıtır
                textBoxBransid.Text = gridViewBranslar.GetRowCellValue(selectedRowHandle, "Bransid")?.ToString();
                textBoxBransAd.Text = gridViewBranslar.GetRowCellValue(selectedRowHandle, "BransAd")?.ToString();
            }
            else
            {
                textBoxBransid.Text = "";
                textBoxBransAd.Text = "";
            }
        }

        // Branş silme butonuna tıklandığında çalışır
        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (bransService.DeleteBranch(int.Parse(textBoxBransid.Text)))
                    MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Branş bilgilerini güncelleme butonu
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans
            {
                Bransid = int.Parse(textBoxBransid.Text),
                BransAd = textBoxBransAd.Text
            };

            try
            {
                if (bransService.UpdateBranch(brans))
                    MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
