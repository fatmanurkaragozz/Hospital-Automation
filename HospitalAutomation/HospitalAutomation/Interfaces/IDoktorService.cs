using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using HospitalAutomation.Models;

namespace HospitalAutomation.Interfaces
{
    // Doktor servisinin temel metodlarını tanımlayan arayüz
    public interface IDoktorService
    {
        // Doktorun bilgilerini TC ile getir
        Task<Doktor> GetDoktorByTCAsync(string doktorTC);

        // Doktorun randevularını getir
        Task<List<DataRow>> GetDoktorRandevularAsync(string doktorAdSoyad);

        // Rapor kaydetme işlemi
        Task<bool> SaveRaporAsync(string hastaTC, string doktorTC, string raporMetni);

        // Doktorun bilgilerini güncelleme
        Task<bool> UpdateDoktorAsync(Doktor doktor);

        // Yeni doktor ekleme metodu
        Task<bool> AddDoktorAsync(Doktor doktor);

        // Doktor silme metodu
        Task<bool> DeleteDoktorAsync(string doktorTC);

    }
}
