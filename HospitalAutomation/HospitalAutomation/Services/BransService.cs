using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HospitalAutomation.Interfaces;
using HospitalAutomation.Models;

namespace HospitalAutomation.Services
{
    public class BransService : IBransService
    {
        private readonly SqlBaglantisi _connection;

        public BransService()
        {
            _connection = new SqlBaglantisi(); // Veri tabanı bağlantısını başlatır
        }

        // Yeni bir branş ekler
        public bool AddBranch(Brans branch)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Table_Branslar (BransAd) VALUES (@BransAd)", _connection.baglanti()))
                {
                    // Kullanıcıdan alınan BransAd değerini SQL komutuna ekler
                    command.Parameters.AddWithValue("@BransAd", branch.BransAd);
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

        // Var olan bir branşı günceller
        public bool UpdateBranch(Brans branch)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE Table_Branslar SET BransAd = @BransAd WHERE Bransid = @Bransid", _connection.baglanti()))
                {
                    // Güncellenmesi istenen branşın adı ve id'sini SQL komutuna ekler
                    command.Parameters.AddWithValue("@BransAd", branch.BransAd);
                    command.Parameters.AddWithValue("@Bransid", branch.Bransid);
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

        // Belirtilen id'ye göre bir branşı siler
        public bool DeleteBranch(int branchId)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Table_Branslar WHERE Bransid = @Bransid", _connection.baglanti()))
                {
                    // Silinecek branşın id'sini SQL komutuna ekler
                    command.Parameters.AddWithValue("@Bransid", branchId);
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

        // Tüm branşları alır
        public List<Brans> GetAllBranches()
        {
            List<Brans> branches = new List<Brans>(); // Branşları tutacak liste
            try
            {
                // Veri tabanından tüm branşları çeker
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Bransid, BransAd FROM Table_Branslar", _connection.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // Verileri DataTable'a doldurur

                // DataTable'dan branşları alıp listeye ekler
                foreach (DataRow row in dataTable.Rows)
                {
                    branches.Add(new Brans
                    {
                        Bransid = Convert.ToInt32(row["Bransid"]), // Bransid değeri
                        BransAd = row["BransAd"].ToString() // BransAd değeri
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

            return branches; // Branşlar listesini döner
        }

        // Verilen id'ye göre belirli bir branşı alır
        public Brans GetBranchById(int branchId)
        {
            Brans branch = null; // Branşı tutacak değişken
            try
            {
                // Verilen id'ye göre branşı çeker
                SqlCommand command = new SqlCommand("SELECT Bransid, BransAd FROM Table_Branslar WHERE Bransid = @Bransid", _connection.baglanti());
                command.Parameters.AddWithValue("@Bransid", branchId);
                SqlDataReader reader = command.ExecuteReader();

                // Eğer veri bulunursa, branş bilgilerini alır
                if (reader.Read())
                {
                    branch = new Brans
                    {
                        Bransid = Convert.ToInt32(reader["Bransid"]), // Bransid
                        BransAd = reader["BransAd"].ToString() // BransAd
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

            return branch; // Branşı döner
        }
    }
}
