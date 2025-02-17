using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public class Rapor
    {
        public int Raporid { get; set; }
        public string HastaTC { get; set; }
        public string DoktorTC { get; set; }
        public string RaporMetni { get; set; }
        public DateTime Tarih { get; set; }
    }
}
