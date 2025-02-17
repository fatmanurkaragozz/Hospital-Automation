using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;

namespace HospitalAutomation.Services
{
    public class HastaService : IHastaService
    {
        private readonly SqlBaglantisi _connection; // SQL bağlantısı için bir alan tanımlıyoruz

        public HastaService()
        {
            _connection = new SqlBaglantisi();
        }

        // Hasta bilgilerini TC ile getir
        public async Task<Hasta> GetHastaByTCAsync(string hastaTC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Hastalar WHERE HastaTC=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", hastaTC);
            Hasta hasta = null;
            SqlDataReader dr = await cmd.ExecuteReaderAsync();

            if (await dr.ReadAsync())
            {
                hasta = new Hasta
                {
                    HastaAd = dr["HastaAd"].ToString(),
                    HastaSoyad = dr["HastaSoyad"].ToString(),
                    HastaCinsiyet = dr["HastaCinsiyet"].ToString(),
                    HastaTelefon = dr["HastaTelefon"].ToString(),
                    HastaSifre = dr["HastaSifre"].ToString(),
                };
            }

            hasta.HastaTC = hastaTC;
            _connection.baglanti().Close();
            return hasta;
        }

        // Hastanın randevularını getir
        public async Task<List<DataRow>> GetHastaRandevularAsync(string hastaTC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Randevular WHERE RandevuHasta=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", hastaTC);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            await Task.Run(() => da.Fill(dt)); // Randevuları veritabanından alıyoruz
            return dt.Rows.Cast<DataRow>().ToList(); // Randevuları döndürüyoruz
        }

        // Hasta raporu kaydetme işlemi
        public async Task<bool> SaveRaporAsync(string hastaTC, string doktorTC, string raporMetni)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Raporlar (HastaTC, DoktorTC, RaporMetni, Tarih) VALUES (@p1, @p2, @p3, @p4)", _connection.baglanti());
                cmd.Parameters.AddWithValue("@p1", hastaTC);
                cmd.Parameters.AddWithValue("@p2", doktorTC);
                cmd.Parameters.AddWithValue("@p3", raporMetni);
                cmd.Parameters.AddWithValue("@p4", DateTime.Now);

                int rowsAffected = await cmd.ExecuteNonQueryAsync(); // Raporu veritabanına kaydediyoruz
                return rowsAffected > 0; // Kaydetme başarılıysa true döndürüyoruz
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rapor kaydederken hata: " + ex.Message);
                return false; // Hata durumunda false döndürüyoruz
            }
        }

        // Hastanın bilgilerini güncelle
        public async Task<bool> UpdateHastaInfoAsync(Hasta updatedHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Table_Hastalar SET HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 WHERE HastaTC=@p6",
                    _connection.baglanti());

                cmd.Parameters.AddWithValue("@p1", updatedHasta.HastaAd);
                cmd.Parameters.AddWithValue("@p2", updatedHasta.HastaSoyad);
                cmd.Parameters.AddWithValue("@p3", updatedHasta.HastaTelefon);
                cmd.Parameters.AddWithValue("@p4", updatedHasta.HastaSifre);
                cmd.Parameters.AddWithValue("@p5", updatedHasta.HastaCinsiyet);
                cmd.Parameters.AddWithValue("@p6", updatedHasta.HastaTC); // HastaTC ile güncelleme yapılacak

                int rowsAffected = await cmd.ExecuteNonQueryAsync(); // Veritabanında güncellemeyi yapıyoruz
                return rowsAffected > 0; // Güncelleme başarılıysa true döndürüyoruz
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hasta bilgilerini güncellerken hata: " + ex.Message);
                return false; // Hata durumunda false döndürüyoruz
            }
        }

        // Yeni hasta ekleme
        public async Task<bool> AddHastaAsync(Hasta newHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Table_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)",
                    _connection.baglanti());

                cmd.Parameters.AddWithValue("@p1", newHasta.HastaAd);
                cmd.Parameters.AddWithValue("@p2", newHasta.HastaSoyad);
                cmd.Parameters.AddWithValue("@p3", newHasta.HastaTC);
                cmd.Parameters.AddWithValue("@p4", newHasta.HastaTelefon);
                cmd.Parameters.AddWithValue("@p5", newHasta.HastaSifre);
                cmd.Parameters.AddWithValue("@p6", newHasta.HastaCinsiyet);

                int rowsAffected = await cmd.ExecuteNonQueryAsync(); // Kayıt işlemi
                return rowsAffected > 0; // Başarılıysa true döndür
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hasta kaydı sırasında hata: " + ex.Message);
                return false; // Hata durumunda false döndür
            }
            finally
            {
                _connection.baglanti().Close();
            }
        }

    }
}
