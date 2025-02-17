using System;
using System.Collections.Generic;
using HospitalAutomation.Models;

namespace HospitalAutomation.Interfaces
{
    // Rapor servisi için metodları içeren arayüz
    public interface IRaporService
    {
        // Yeni bir rapor ekler
        bool AddRapor(Rapor rapor);

        // Hasta TC'ye göre raporları alır
        List<Rapor> GetRaporlarByHastaTC(string hastaTC);

        // Bir raporu günceller
        bool UpdateRapor(Rapor rapor);

        // Bir raporu siler
        bool DeleteRapor(int raporid);
    }
}
