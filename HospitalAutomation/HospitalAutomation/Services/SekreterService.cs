using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalAutomation.Services
{
    public class SekreterService : ISekreterService
    {
        private readonly SqlBaglantisi _connection;

        public SekreterService()
        {
            _connection = new SqlBaglantisi();
        }

        public Task<bool> AddAnnouncementAsync(string duyuruMesaji)
        {
            throw new NotImplementedException();
        }

        // Tüm sekreterleri listeleme
        public async Task<List<Sekreter>> GetAllSekreterlerAsync()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Sekreter", _connection.baglanti());
            var sekreterler = new List<Sekreter>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                sekreterler.Add(new Sekreter
                {
                    Sekreterid = Convert.ToInt32(reader["Sekreterid"]),
                    SekreterAdSoyad = reader["SekreterAdSoyad"].ToString(),
                    SekreterTC = reader["SekreterTC"].ToString(),
                    SekreterSifre = reader["SekreterSifre"].ToString()
                });
            }
            return sekreterler;
        }

        // Belirli bir sekreterin bilgilerini alma
        public async Task<Sekreter> GetSekreterByTCAsync(string sekreterTC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Sekreter WHERE SekreterTC=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", sekreterTC);
            Sekreter sekreter = null;
            SqlDataReader dr = await cmd.ExecuteReaderAsync();

            if (await dr.ReadAsync())
            {
                sekreter = new Sekreter
                {
                    Sekreterid = Convert.ToInt32(dr["Sekreterid"]),
                    SekreterAdSoyad = dr["SekreterAdSoyad"].ToString(),
                    SekreterTC = dr["SekreterTC"].ToString(),
                    SekreterSifre = dr["SekreterSifre"].ToString()
                };
            }
            sekreter.SekreterTC = sekreterTC;
            _connection.baglanti().Close();
            return sekreter;
        }

        // Sekreter bilgilerini güncelleme
        public async Task<bool> UpdateSekreterAsync(Sekreter sekreter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_Sekreter SET SekreterAdSoyad=@adSoyad, SekreterSifre=@sifre WHERE SekreterTC=@tc", _connection.baglanti());
                cmd.Parameters.AddWithValue("@adSoyad", sekreter.SekreterAdSoyad);
                cmd.Parameters.AddWithValue("@sifre", sekreter.SekreterSifre);
                cmd.Parameters.AddWithValue("@tc", sekreter.SekreterTC);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                _connection.baglanti().Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating sekreter: " + ex.Message);
                return false;
            }
        }

        // Sekreter silme
        public async Task<bool> DeleteSekreterAsync(string tc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Table_Sekreter WHERE SekreterTC=@p1", _connection.baglanti());
                cmd.Parameters.AddWithValue("@p1", tc);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                _connection.baglanti().Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting sekreter: " + ex.Message);
                return false;
            }
        }

        // Sekreterin duyuruları getirme
        public async Task<List<string>> GetAllDuyurularAsync()
        {
            SqlCommand cmd = new SqlCommand("SELECT DuyuruMesaji FROM Table_Duyurular", _connection.baglanti());
            var duyurular = new List<string>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                duyurular.Add(reader["DuyuruMesaji"].ToString());
            }
            return duyurular;
        }

    }
}
