using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Models
{
    public class Duyuru
    {
        public int Duyuruid { get; set; }

        //[Column("Duyuru")]
        public string DuyuruMetni { get; set; }
    }
}
