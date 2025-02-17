using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HospitalAutomation.Models;
using System.Linq;
using HospitalAutomation.Interfaces;

namespace HospitalAutomation.Services
{
    public class DoktorService: IDoktorService
    {
        private readonly SqlBaglantisi _connection;

        public DoktorService()
        {
            _connection = new SqlBaglantisi();
        }

        

        // Doktorun bilgilerini TC ile getir
        public async Task<Doktor> GetDoktorByTCAsync(string doktorTC)
        {
            SqlCommand cmd = new SqlCommand("SELECT DoktorAd, DoktorSoyad, DoktorBrans, DoktorSifre FROM Table_Doktorlar WHERE DoktorTC=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", doktorTC);
            Doktor doktor = null;
            SqlDataReader dr = await cmd.ExecuteReaderAsync();

            if (await dr.ReadAsync())
            {
                doktor = new Doktor
                {
                    DoktorAd = dr["DoktorAd"].ToString(),
                    DoktorSoyad = dr["DoktorSoyad"].ToString(),
                    DoktorBrans = dr["DoktorBrans"].ToString(),
                    DoktorSifre = dr["DoktorSifre"].ToString(),
                    DoktorTC = doktorTC
                };
            }

            _connection.baglanti().Close();
            return doktor;
        }

        // Doktorun randevularını getir
        public async Task<List<DataRow>> GetDoktorRandevularAsync(string doktorTC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Randevular WHERE RandevuDoktor=@p1", _connection.baglanti());
            cmd.Parameters.AddWithValue("@p1", doktorTC);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            await Task.Run(() => da.Fill(dt)); // Randevuları veritabanından alıyoruz
            return dt.Rows.Cast<DataRow>().ToList(); // Randevuları döndürüyoruz
        }

        // Rapor kaydetme işlemi
        public async Task<bool> SaveRaporAsync(string hastaTC, string doktorTC, string raporMetni)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Raporlar (HastaTC, DoktorTC, RaporMetni, Tarih) VALUES (@p1, @p2, @p3, @p4)", _connection.baglanti());
                cmd.Parameters.AddWithValue("@p1", hastaTC);
                cmd.Parameters.AddWithValue("@p2", doktorTC);
                cmd.Parameters.AddWithValue("@p3", raporMetni);
                cmd.Parameters.AddWithValue("@p4", DateTime.Now);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rapor kaydederken hata: " + ex.Message);
                return false;
            }
        }

        // Doktorun bilgilerini güncelleme
        public async Task<bool> UpdateDoktorAsync(Doktor doktor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_Doktorlar SET DoktorAd=@ad, DoktorSoyad=@soyad, DoktorBrans=@brans, DoktorSifre=@sifre WHERE DoktorTC=@tc", _connection.baglanti());
                cmd.Parameters.AddWithValue("@ad", doktor.DoktorAd);
                cmd.Parameters.AddWithValue("@soyad", doktor.DoktorSoyad);
                cmd.Parameters.AddWithValue("@brans", doktor.DoktorBrans);
                cmd.Parameters.AddWithValue("@sifre", doktor.DoktorSifre);
                cmd.Parameters.AddWithValue("@tc", doktor.DoktorTC);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doktor bilgileri güncellenirken hata: " + ex.Message);
                return false;
            }
        }

        // Yeni doktor ekleme metodu
        public async Task<bool> AddDoktorAsync(Doktor doktor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Table_Doktorlar (DoktorTC, DoktorAd, DoktorSoyad, DoktorBrans, DoktorSifre) VALUES (@tc, @ad, @soyad, @brans, @sifre)", _connection.baglanti());
                cmd.Parameters.AddWithValue("@tc", doktor.DoktorTC);
                cmd.Parameters.AddWithValue("@ad", doktor.DoktorAd);
                cmd.Parameters.AddWithValue("@soyad", doktor.DoktorSoyad);
                cmd.Parameters.AddWithValue("@brans", doktor.DoktorBrans);
                cmd.Parameters.AddWithValue("@sifre", doktor.DoktorSifre);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doktor eklerken hata: " + ex.Message);
                return false;
            }
        }

        // Doktor silme metodu
        public async Task<bool> DeleteDoktorAsync(string doktorTC)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Table_Doktorlar WHERE DoktorTC=@tc", _connection.baglanti());
            cmd.Parameters.AddWithValue("@tc", doktorTC);

            int rowsAffected = await cmd.ExecuteNonQueryAsync();
            _connection.baglanti().Close();
            return rowsAffected > 0;
        }
    }
}
