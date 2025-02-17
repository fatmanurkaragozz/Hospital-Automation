using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class FormHakkimizda : Form
    {
        public FormHakkimizda()
        {
            InitializeComponent();
        }

        private void FormHakkimizda_Load(object sender, EventArgs e)
        {
            Label lblHakkimizda = new Label();
            lblHakkimizda.Text = "Seçkin kadromuzla, sağlık alanında fark yaratmaya devam ediyoruz. Modern teknolojiyi ve bilimsel yaklaşımları bir araya getirerek, her hastamız için en yüksek kalitede sağlık hizmeti sunmayı amaçlıyoruz. İnsana ve insan sağlığına verdiğimiz değeri, güvenilir hizmet anlayışımızla birleştirerek, hasta memnuniyetini her zaman ön planda tutuyoruz.\n\n" +
                                "Uzman doktorlarımız, deneyimli sağlık personelimiz ve güler yüzlü ekibimizle; teşhis, tedavi ve bakım süreçlerinde yanınızda olmaktan gurur duyuyoruz. Sadece fiziksel iyileşmeyi değil, aynı zamanda ruhsal ve duygusal sağlığı da gözeterek, her bireye özel yaklaşımlar sunuyoruz.\n\n" +
                                "Misyonumuz, hastalarımızın sağlığını iyileştirmekle kalmayıp, yaşam kalitelerini de artırmaktır. Bu doğrultuda, etik değerlere bağlı kalarak ve sürekli gelişimi hedefleyerek, toplum sağlığına katkıda bulunmaya devam ediyoruz.\n\n" +
                                "Sizlere hizmet etmekten mutluluk duyuyor ve sağlık dolu bir yaşam için birlikte yürümeye davet ediyoruz...\n\nTüm Haklar Saklıdır.";

            lblHakkimizda.AutoSize = false; // Otomatik boyutlandırmayı kapat
            lblHakkimizda.Size = new Size(600, 400); // Uygun boyutları belirle
            lblHakkimizda.Location = new Point(80, 100); // Konumu ayarla
            lblHakkimizda.TextAlign = ContentAlignment.TopLeft; // Yazıyı sola hizala
            lblHakkimizda.Font = new Font("Arial", 12); // Yazı tipini ayarla
            lblHakkimizda.BorderStyle = BorderStyle.FixedSingle; // İsteğe bağlı çerçeve ekleyebilirsin

            this.Controls.Add(lblHakkimizda); // Label'i forma ekle
        }
    }




}
