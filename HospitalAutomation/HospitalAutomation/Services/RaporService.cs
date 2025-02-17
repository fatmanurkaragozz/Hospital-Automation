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
    public class RaporService : IRaporService
    {
        private readonly SqlBaglantisi _connection;

        public RaporService()
        {
            _connection = new SqlBaglantisi(); // Veri tabanı bağlantısı başlatılır
        }

        // Yeni bir rapor ekler
        public bool AddRapor(Rapor rapor)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Table_Raporlar (HastaTC, DoktorTC, RaporMetni, Tarih) VALUES (@HastaTC, @DoktorTC, @RaporMetni, @Tarih)", _connection.baglanti()))
                {
                    // Parametreler eklenir
                    command.Parameters.AddWithValue("@HastaTC", rapor.HastaTC);
                    command.Parameters.AddWithValue("@DoktorTC", rapor.DoktorTC);
                    command.Parameters.AddWithValue("@RaporMetni", rapor.RaporMetni);
                    command.Parameters.AddWithValue("@Tarih", rapor.Tarih);

                    // Sorgu çalıştırılır
                    command.ExecuteNonQuery();
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata oluşursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }

        // Bir hastanın tüm raporlarını alır
        public List<Rapor> GetRaporlarByHastaTC(string hastaTC)
        {
            List<Rapor> raporlar = new List<Rapor>(); // Raporları tutacak liste
            try
            {
                // Hasta TC'ye göre raporlar çekilir
                SqlCommand command = new SqlCommand("SELECT Raporid, HastaTC, DoktorTC, RaporMetni, Tarih FROM Table_Raporlar WHERE HastaTC = @HastaTC", _connection.baglanti());
                command.Parameters.AddWithValue("@HastaTC", hastaTC);
                SqlDataReader reader = command.ExecuteReader();

                // Raporları listeye ekler
                while (reader.Read())
                {
                    raporlar.Add(new Rapor
                    {
                        Raporid = Convert.ToInt32(reader["Raporid"]),
                        HastaTC = reader["HastaTC"].ToString(),
                        DoktorTC = reader["DoktorTC"].ToString(),
                        RaporMetni = reader["RaporMetni"].ToString(),
                        Tarih = Convert.ToDateTime(reader["Tarih"])
                    });
                }
            }
            catch (Exception)
            {
                return null; // Hata oluşursa null döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }

            return raporlar; // Raporlar listesini döner
        }

        // Raporu günceller
        public bool UpdateRapor(Rapor rapor)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE Table_Raporlar SET RaporMetni = @RaporMetni, Tarih = @Tarih WHERE Raporid = @Raporid", _connection.baglanti()))
                {
                    // Güncellenmek istenen raporun bilgileri eklenir
                    command.Parameters.AddWithValue("@RaporMetni", rapor.RaporMetni);
                    command.Parameters.AddWithValue("@Tarih", rapor.Tarih);
                    command.Parameters.AddWithValue("@Raporid", rapor.Raporid);

                    // Sorgu çalıştırılır
                    command.ExecuteNonQuery();
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata oluşursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }

        // Raporu siler
        public bool DeleteRapor(int raporid)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Table_Raporlar WHERE Raporid = @Raporid", _connection.baglanti()))
                {
                    // Silinmek istenen raporun id'si eklenir
                    command.Parameters.AddWithValue("@Raporid", raporid);

                    // Sorgu çalıştırılır
                    command.ExecuteNonQuery();
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata oluşursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }
    }
}
