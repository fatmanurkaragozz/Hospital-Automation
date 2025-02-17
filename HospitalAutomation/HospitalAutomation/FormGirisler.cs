using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using Microsoft.Extensions.DependencyInjection;  // DI için gerekli namespace


namespace HospitalAutomation
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();

        }

        // Hasta Giriş paneline yönlendirme kısmı
        private void hastabutton_Click(object sender, EventArgs e)
        {
            FormHastaGiris fr = new FormHastaGiris();  // DI ile FormHastaGiris'i başlatıyoruz
            fr.Show();
            this.Hide();
        }

        // Doktor Giriş paneline yönlendirme kısmı
        private void Doktorbutton_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr2 = new FormDoktorGiris();
            fr2.Show();
            this.Hide();
        }

        // Sekreter Giriş paneline yönlendirme kısmı
        private void Sekreterbutton_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr3 = new FormSekreterGiris();
            fr3.Show();
            this.Hide();
        }
    }
}
