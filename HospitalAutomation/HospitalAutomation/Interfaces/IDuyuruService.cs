using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Interfaces
{
    interface IDuyuruService
    {
        // Yeni bir duyuru ekler
        bool AddDuyuru(Duyuru duyuru);

        // Tüm duyuruları alır
        List<Duyuru> GetAllDuyurular();

        // Verilen id'ye göre bir duyuru getirir
        Duyuru GetDuyuruById(int duyuruId);

        // Bir duyuruyu günceller
        bool UpdateDuyuru(Duyuru duyuru);

        // Bir duyuruyu siler
        bool DeleteDuyuru(int duyuruId);

    }
}
