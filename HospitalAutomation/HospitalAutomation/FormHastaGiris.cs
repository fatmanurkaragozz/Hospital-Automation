using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using Microsoft.Extensions.DependencyInjection; // DI için gerekli namespace

namespace HospitalAutomation
{
    public partial class FormHastaGiris : Form
    {
        private readonly IHastaService hastaService;
        private SqlBaglantisi sqlBaglantisi;

        public FormHastaGiris()
        {
            InitializeComponent();
            hastaService = new HastaService();
            sqlBaglantisi = new SqlBaglantisi();
        }

        private void linkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit fr = new FormHastaKayit();
            fr.Show();
            this.Hide();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", sqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTC.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                // Bağımlılık enjeksiyonu ile servisleri alıyoruz
                FormHastaDetay fr = new FormHastaDetay();  // Bağımlılıkları geçiyoruz
                fr.hastaTC = maskedTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre ");
            }

            sqlBaglantisi.baglanti().Close();
        }
    }
}
