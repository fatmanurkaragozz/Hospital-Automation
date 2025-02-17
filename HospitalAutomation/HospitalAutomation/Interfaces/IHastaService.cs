using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAutomation.Models;

namespace HospitalAutomation.Interfaces
{
    public interface IHastaService
    {
        // Hasta bilgilerini TC'ye göre asenkron olarak alır
        Task<Hasta> GetHastaByTCAsync(string hastaTC);

        // Hastanın randevularını TC'ye göre asenkron olarak alır
        Task<List<System.Data.DataRow>> GetHastaRandevularAsync(string hastaTC);

        // Hastanın raporunu asenkron olarak kaydeder
        Task<bool> SaveRaporAsync(string hastaTC, string doktorTC, string raporMetni);
        
        // Hastanın bilgilerini güncelle
        Task<bool> UpdateHastaInfoAsync(Hasta updatedHasta);

        // Yeni Hasta ekle
        Task<bool> AddHastaAsync(Hasta newHasta);
    }
}
