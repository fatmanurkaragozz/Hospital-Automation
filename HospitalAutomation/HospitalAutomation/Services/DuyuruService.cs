using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;

namespace HospitalAutomation.Services
{
    public class DuyuruService : IDuyuruService

    {
        private readonly SqlBaglantisi _connection;

        public DuyuruService()
        {
            _connection = new SqlBaglantisi(); // Veritabanı bağlantısını başlatır
        }

        // Yeni bir duyuru ekler
        public bool AddDuyuru(Duyuru duyuru)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Table_Duyurular (Duyuru) VALUES (@DuyuruMetni)", _connection.baglanti()))
                {
                    // Kullanıcıdan alınan duyuru metnini SQL komutuna ekler
                    command.Parameters.AddWithValue("@DuyuruMetni", duyuru.DuyuruMetni);
                    command.ExecuteNonQuery(); // Veritabanına sorguyu işler
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata olursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }

        // Tüm duyuruları alır
        public List<Duyuru> GetAllDuyurular()
        {
            List<Duyuru> duyurular = new List<Duyuru>(); // Duyuruları tutacak liste
            try
            {
                // Veri tabanından tüm duyuruları çeker
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Duyuruid, Duyuru FROM Table_Duyurular", _connection.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // Verileri DataTable'a doldurur

                // DataTable'dan duyuruları alıp listeye ekler
                foreach (DataRow row in dataTable.Rows)
                {
                    duyurular.Add(new Duyuru
                    {
                        Duyuruid = Convert.ToInt32(row["Duyuruid"]), // Duyuru id'si
                        DuyuruMetni = row["Duyuru"].ToString() // Duyuru metni
                    });
                }
            }
            catch (Exception)
            {
                return null; // Hata olursa null döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }

            return duyurular; // Duyurular listesini döner
        }

        // Verilen id'ye göre bir duyuru getirir
        public Duyuru GetDuyuruById(int duyuruId)
        {
            Duyuru duyuru = null; // Duyuruyu tutacak değişken
            try
            {
                // Verilen id'ye göre duyuruyu çeker
                SqlCommand command = new SqlCommand("SELECT Duyuruid, Duyuru FROM Table_Duyurular WHERE Duyuruid = @Duyuruid", _connection.baglanti());
                command.Parameters.AddWithValue("@Duyuruid", duyuruId);
                SqlDataReader reader = command.ExecuteReader();

                // Eğer veri bulunursa, duyuru bilgisini alır
                if (reader.Read())
                {
                    duyuru = new Duyuru
                    {
                        Duyuruid = Convert.ToInt32(reader["Duyuruid"]), // Duyuru id'si
                        DuyuruMetni = reader["Duyuru"].ToString() // Duyuru metni
                    };
                }
            }
            catch (Exception)
            {
                return null; // Hata olursa null döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }

            return duyuru; // Duyuruyu döner
        }

        // Bir duyuruyu günceller
        public bool UpdateDuyuru(Duyuru duyuru)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE Table_Duyurular SET Duyuru = @DuyuruMetni WHERE Duyuruid = @Duyuruid", _connection.baglanti()))
                {
                    // Güncellenmesi istenen duyurunun id'si ve metni eklenir
                    command.Parameters.AddWithValue("@DuyuruMetni", duyuru.DuyuruMetni);
                    command.Parameters.AddWithValue("@Duyuruid", duyuru.Duyuruid);
                    command.ExecuteNonQuery(); // Veritabanına sorguyu işler
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata olursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }

        // Bir duyuruyu siler
        public bool DeleteDuyuru(int duyuruId)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Table_Duyurular WHERE Duyuruid = @Duyuruid", _connection.baglanti()))
                {
                    // Silinecek duyurunun id'sini ekler
                    command.Parameters.AddWithValue("@Duyuruid", duyuruId);
                    command.ExecuteNonQuery(); // Veritabanına sorguyu işler
                    return true; // Başarılı ise true döner
                }
            }
            catch (Exception)
            {
                return false; // Hata olursa false döner
            }
            finally
            {
                _connection.baglanti().Close(); // Bağlantıyı kapatır
            }
        }
    }
}
