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
    public partial class FormRandevuListesi : Form
    {
        private readonly IRandevuService randevuService;

        public FormRandevuListesi()
        {
            InitializeComponent();
            randevuService = new RandevuService();
        }

        private void FormRandevuListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet5.Table_Randevular' table. You can move, or remove it, as needed.
            this.table_RandevularTableAdapter.Fill(this.hastaneOtomasyonuDataSet5.Table_Randevular);
        }
    }
}
