using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Services
{
    public class RandevuService : IRandevuService
    {
        private readonly SqlBaglantisi _connection;

        // Randevu işlemleri için gerekli olan SQL bağlantısını alır.
        public RandevuService()
        {
            _connection = new SqlBaglantisi();
        }

        // Hastanın TC kimlik numarasına göre randevuları getirir.
        // Hasta TC'sine ait tüm randevular listelenir.
        public async Task<List<Randevu>> GetRandevularByHastaAsync(string tc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Randevular WHERE HastaTC=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", tc);
            var randevular = new List<Randevu>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                randevular.Add(new Randevu
                {
                    Randevuid = Convert.ToInt32(reader["Randevuid"]),
                    RandevuTarih = reader["RandevuTarih"].ToString(),
                    RandevuSaat = reader["RandevuSaat"].ToString(),
                    RandevuBrans = reader["RandevuBrans"].ToString(),
                    RandevuDoktor = reader["RandevuDoktor"].ToString(),
                    RandevuDurum = Boolean.Parse(reader["RandevuDurum"].ToString()),
                    HastaTC = reader["HastaTC"].ToString(),
                    HastaSikayet = reader["HastaSikayet"].ToString()
                });
            }
            return randevular;
        }

        // Veritabanında yeni bir randevu oluşturur
        public async Task<bool> CreateRandevuAsync(Randevu randevu)
        {
            using (SqlConnection conn = _connection.baglanti())
            {
                // SQL sorgusu ile yeni randevu ekleme
                string query = "INSERT INTO Table_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, HastaTC, RandevuDurum) " +
                               "VALUES (@tarih, @saat, @brans, @doktor, @tc, @durum)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametreleri ekleyerek SQL komutunu hazırla
                cmd.Parameters.AddWithValue("@tarih", randevu.RandevuTarih);
                cmd.Parameters.AddWithValue("@saat", randevu.RandevuSaat);
                cmd.Parameters.AddWithValue("@brans", randevu.RandevuBrans);
                cmd.Parameters.AddWithValue("@doktor", randevu.RandevuDoktor);
                cmd.Parameters.AddWithValue("@tc", randevu.HastaTC);
                cmd.Parameters.AddWithValue("@durum", randevu.RandevuDurum);

                // SQL komutunu çalıştır ve etkilenen satır sayısını kontrol et
                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
        }

        // Randevular tablosunda mevcut olan tüm benzersiz branşları getirir.
        // Branş isimlerini bir liste halinde döner.
        public async Task<List<string>> GetAllBranslarAsync()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT RandevuBrans FROM Table_Randevular", _connection.baglanti());
            var branslar = new List<string>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                branslar.Add(reader["RandevuBrans"].ToString());
            }
            return branslar;
        }

        // Belirtilen branşa ait doktorların isimlerini getirir.
        // Bir branş için hizmet veren doktorların listesini döner.
        public async Task<List<string>> GetDoktorlarByBransAsync(string brans)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT RandevuDoktor FROM Table_Randevular WHERE RandevuBrans=@brans", _connection.baglanti());
            cmd.Parameters.AddWithValue("@brans", brans);
            var doktorlar = new List<string>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                doktorlar.Add(reader["RandevuDoktor"].ToString());
            }
            return doktorlar;
        }

        // Belirtilen branş ve doktora ait boş (mevcut) randevuları getirir.
        // Randevu Durumu (RandevuDurum) 0 olan randevular listelenir.
        public async Task<List<Randevu>> GetAvailableRandevularAsync(string brans, string doktor)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Randevular WHERE RandevuBrans=@brans AND RandevuDoktor=@doktor AND RandevuDurum=0", _connection.baglanti());
            cmd.Parameters.AddWithValue("@brans", brans);
            cmd.Parameters.AddWithValue("@doktor", doktor);
            var randevular = new List<Randevu>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                randevular.Add(new Randevu
                {
                    Randevuid = Convert.ToInt32(reader["Randevuid"]),
                    RandevuTarih = reader["RandevuTarih"].ToString(),
                    RandevuSaat = reader["RandevuSaat"].ToString(),
                    RandevuBrans = reader["RandevuBrans"].ToString(),
                    RandevuDoktor = reader["RandevuDoktor"].ToString(),
                    RandevuDurum = Boolean.Parse(reader["RandevuDurum"].ToString()),
                    HastaTC = reader["HastaTC"].ToString(),
                    HastaSikayet = reader["HastaSikayet"].ToString()
                });
            }
            return randevular;
        }

        // Hastanın şikayetini ve randevu durumunu günceller.
        // Güncelleme başarılı olursa true, başarısız olursa false döner.
        public async Task<bool> UpdateRandevuAsync(string hastaTc, string sikayet, int randevuId)
        {
            using (SqlConnection conn = _connection.baglanti())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_Randevular SET HastaSikayet=@sikayet,HastaTC=@tc, RandevuDurum=1 WHERE Randevuid=@randevuId", conn);
                cmd.Parameters.AddWithValue("@sikayet", sikayet);
                cmd.Parameters.AddWithValue("@randevuId", randevuId);
                cmd.Parameters.AddWithValue("@tc", hastaTc);
                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
        }

        // Tüm doktorları benzersiz olarak listeleyen metod
        public async Task<List<string>> GetAllDoktorlarAsync()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT RandevuDoktor FROM Table_Randevular", _connection.baglanti());
            var doktorlar = new List<string>();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                doktorlar.Add(reader["RandevuDoktor"].ToString());
            }
            return doktorlar;
        }


        public async Task<List<Randevu>> GetRandevularByDoktorTCAsync(string doktorTC)
        {
            var randevular = new List<Randevu>();
            using (SqlConnection conn = _connection.baglanti())
            {
 
                // Randevuları çekme sorgusu
                string doktorQuery = @"SELECT * FROM Table_Randevular WHERE RandevuDoktor = (SELECT CONCAT(DoktorAd, ' ', DoktorSoyad) FROM Table_Doktorlar WHERE DoktorTC = @doktorTC)";
                SqlCommand cmd = new SqlCommand(doktorQuery, conn);
                cmd.Parameters.AddWithValue("@doktorTC", doktorTC);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        randevular.Add(new Randevu
                        {
                            Randevuid = Convert.ToInt32(reader["Randevuid"]),
                            RandevuTarih = reader["RandevuTarih"].ToString(),
                            RandevuSaat = reader["RandevuSaat"].ToString(),
                            RandevuBrans = reader["RandevuBrans"].ToString(),
                            RandevuDoktor = reader["RandevuDoktor"].ToString(),
                            RandevuDurum = Convert.ToBoolean(reader["RandevuDurum"]),
                            HastaTC = reader["HastaTC"].ToString(),
                            HastaSikayet = reader["HastaSikayet"].ToString()
                        });
                    }
                }
            }
            return randevular;
        }
    }
}
