using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAutomation.Interfaces
{
    public interface IRandevuService
    {
        // Hastanın TC kimlik numarasına göre randevuları getirir.
        // Geriye randevu listesi döner.
        Task<List<Randevu>> GetRandevularByHastaAsync(string tc);

        // Tüm mevcut branşları benzersiz şekilde listeler.
        // Geriye branş isimlerinden oluşan bir liste döner.
        Task<List<string>> GetAllBranslarAsync();

        // Belirli bir branşa ait doktorları listeler.
        // Geriye doktor isimlerinden oluşan bir liste döner.
        Task<List<string>> GetDoktorlarByBransAsync(string brans);

        // Belirli bir branş ve doktora ait boş olan randevuları getirir.
        // Geriye müsait randevuların listesi döner.
        Task<List<Randevu>> GetAvailableRandevularAsync(string brans, string doktor);

        // Bir randevunun şikayet bilgilerini ve durumunu günceller.
        // Güncelleme başarılı olursa true, başarısız olursa false döner.
        Task<bool> UpdateRandevuAsync(string hastaTc, string sikayet, int randevuId);

        // Yeni bir randevu oluşturur ve veritabanına ekler.
        // Başarılı ekleme durumunda true, aksi halde false döner.
        Task<bool> CreateRandevuAsync(Randevu randevu);

        // Tüm doktorları benzersiz olarak listeler.
        // Geriye doktor isimlerinden oluşan bir liste döner.
        Task<List<string>> GetAllDoktorlarAsync();

        // Belirli bir doktorun TC kimlik numarasına göre randevuları getirir.
        // Geriye o doktora ait randevuların listesi döner.
        Task<List<Randevu>> GetRandevularByDoktorTCAsync(string doktorTC);
    }
}
