using System;
using System.Data.SqlClient;

namespace HospitalAutomation
{
    // SqlBaglantisi sınıfı, veritabanı bağlantısı yönetimi sağlar
    public class SqlBaglantisi
    {
        // baglanti yöntemi, veritabanı bağlantısını açar ve SqlConnection nesnesini döndürür
        public SqlConnection baglanti()
        {
            // SqlConnection nesnesini başlatıyoruz
            SqlConnection baglan = null;
            try
            {
                // Bağlantı dizesi: SQL Server bağlantı bilgilerini içerir
                // Data Source kısmı, SQL Server'ın adresini belirtir (bu örnekte yerel bir instance kullanılmıştır)
                // Initial Catalog, kullanılacak veritabanının adıdır (HastaneOtomasyonu)
                // Integrated Security=True, Windows kimlik doğrulaması kullanıldığını belirtir
                baglan = new SqlConnection("Data Source=FATMANUR\\SQLEXPRESS;Initial Catalog=HastaneOtomasyonu;Integrated Security=True");

                // Veritabanı bağlantısını açıyoruz
                baglan.Open();

                // Bağlantı başarılı olduğunda, kullanıcıya bilgi veriyoruz
                Console.WriteLine("Veritabanı bağlantısı başarılı.");
            }
            catch (SqlException ex)
            {
                // Bağlantı sırasında bir hata oluşursa, hata mesajını ekrana yazdırıyoruz
                Console.WriteLine("Veritabanı bağlantı hatası: " + ex.Message);

                // Hata oluştuğunda, hatayı tekrar fırlatıyoruz (yukarı katmanların hatayı işleyebilmesi için)
                throw;
            }
            // Başarılı bağlantı sağlandıysa, SqlConnection nesnesini döndürüyoruz
            return baglan;
        }

        // BaglantiKapat yöntemi, veritabanı bağlantısını güvenli bir şekilde kapatır
        public void BaglantiKapat(SqlConnection baglan)
        {
            try
            {
                // Eğer bağlantı açık ise ve SqlConnection nesnesi null değilse
                if (baglan != null && baglan.State == System.Data.ConnectionState.Open)
                {
                    // Bağlantıyı kapatıyoruz
                    baglan.Close();
                    // Bağlantı kapatıldığında, kullanıcıya bilgi veriyoruz
                    Console.WriteLine("Veritabanı bağlantısı kapatıldı.");
                }
            }
            catch (SqlException ex)
            {
                // Bağlantıyı kapatırken bir hata oluşursa, hata mesajını ekrana yazdırıyoruz
                Console.WriteLine("Bağlantı kapatma hatası: " + ex.Message);
            }
        }
    }
}
