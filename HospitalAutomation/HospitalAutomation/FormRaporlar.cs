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

namespace HospitalAutomation
{
    public partial class FormRaporlar : Form
    {
        // Hastanın kimliğini tutan özellik (hastaID, form açıldığında kullanılacak)
        public string hastaID;

        // Form constructor'ı
        public FormRaporlar()
        {
            // Form bileşenlerini başlatan metodu çağırır
            InitializeComponent();
        }

        // Form yüklendiğinde çalışacak olan metod
        private void FormRaporlar_Load(object sender, EventArgs e)
        {
            // HastaID'ye göre raporları veritabanından alıp, ilgili tabloyu dolduruyor
            // table_RaporlarTableAdapter.FillByHastaTC metodu, Hasta TC'sine göre raporları getiren bir sorgu çalıştırır
            // Bu metod hastaneOtomasyonuDataSet'e ait Table_Raporlar tablosuna veri ekler.
            this.table_RaporlarTableAdapter.FillByHastaTC(this.hastaneOtomasyonuDataSet.Table_Raporlar, hastaID);
        }
    }
}
