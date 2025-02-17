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
    public partial class FormDuyurular : Form
    {
        private IDuyuruService duyuruService;
        public FormDuyurular()
        {
            InitializeComponent();
            duyuruService = new DuyuruService();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FormDuyurular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneOtomasyonuDataSet6.Table_Duyurular' table. You can move, or remove it, as needed.
            this.table_DuyurularTableAdapter.Fill(this.hastaneOtomasyonuDataSet6.Table_Duyurular);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Duyurular", bgl.baglanti());
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
    }
}
