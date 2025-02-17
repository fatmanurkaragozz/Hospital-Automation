using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public class Randevu
    {
        public int Randevuid { get; set; }
        public string RandevuTarih { get; set; }
        public string RandevuSaat { get; set; }
        public string RandevuBrans { get; set; }
        public string RandevuDoktor { get; set; }
        public bool RandevuDurum { get; set; }
        public string HastaTC { get; set; }
        public string HastaSikayet { get; set; }
    }
}
