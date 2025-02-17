using HospitalAutomation.Interfaces;
using HospitalAutomation.Services;
using System;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // DI ile FormGirisler'i başlatıyoruz
            FormGirisler frg = new FormGirisler();
            frg.Show();
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHakkimizda frh = new FormHakkimizda();
            frh.Show();
        }
    }
}
