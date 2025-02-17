using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Interfaces
{
    public interface ISekreterService
    {
        // Yeni bir duyuru ekler
        Task<bool> AddAnnouncementAsync(string duyuruMesaji);

        // Tüm sekreterlerin listesini getirir
        Task<List<Sekreter>> GetAllSekreterlerAsync();

        // Belirli bir sekreteri TC numarasına göre getirir
        Task<Sekreter> GetSekreterByTCAsync(string tc);

        // Sekreter bilgilerini günceller
        Task<bool> UpdateSekreterAsync(Sekreter sekreter);

        // Sekreteri TC numarasına göre siler
        Task<bool> DeleteSekreterAsync(string tc);

        // Tüm duyuruları getirir
        Task<List<string>> GetAllDuyurularAsync();
    }
}
