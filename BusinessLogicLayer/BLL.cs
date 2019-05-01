using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sözlük.Entities;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;
        List<Kelime> KelimeListesi = new List<Kelime>();
        List<Kelime> KelimeListeleDurum = new List<Kelime>();
        List<Test> ListeTestDerece = new List<Test>();
        List<Test> TestListele = new List<Test>();

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int KelimeEkle(string kelimeIngilizce, string kelimeTurkce, string aciklama, string cumle)
        {
            if (!string.IsNullOrEmpty(kelimeIngilizce) && !string.IsNullOrEmpty(kelimeTurkce) && !string.IsNullOrEmpty(aciklama) && !string.IsNullOrEmpty(cumle))
            {
                return dll.KelimeEkle(new Kelime()//yeni nesne oluşturulur burada
                {
                    KeliemeID = Guid.NewGuid(),
                    KelimeIngilizce = kelimeIngilizce,
                    KelimeTurkce = kelimeTurkce,
                    Aciklama = aciklama,
                    Cumle = cumle

                });

            }
            else
                return -1;
        }

        public List<Kelime> KelimeListele()
        { 
            try
            {
                SqlDataReader reader = dll.KelimeListele();
                while(reader.Read())
                {
                    KelimeListesi.Add(new Kelime()
                    {   KeliemeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Cumle = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Durum = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    });
                }reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dll.BaglantiAyarla();
            }return KelimeListesi;

        }
        public List<Kelime> ListeleDurum(string durum)
        {
            try
            {
                SqlDataReader reader = dll.KelimeListeleDurum(durum);
                while(reader.Read())
                {
                    KelimeListeleDurum.Add(new Kelime()
                    {
                        KeliemeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Aciklama= reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Cumle= reader.IsDBNull(4) ? string.Empty : reader.GetString(4),

                    });
                }reader.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dll.BaglantiAyarla();
            }return KelimeListeleDurum;
        }
        public int KelimeDurumDuzenle(Guid ID, string durum)
        {
            if (ID != Guid.Empty)
            {
                return dll.DurumGüncelle(new Kelime()
                {
                    KeliemeID = ID,
                    Durum = durum

                });
            }
            else return -1;
        }
        public int TestDurumuEkle(Guid Id)
        {
            if (Id != Guid.Empty)
            {
                return dll.TestDurumuEkle(new Test()
                {
                    TestID = Id,
                    Tarih = DateTime.Now,
                    Derece = 0

                });

            }
            else return -1;
        }
        public int TestDurumuDuzenle(Guid Id)
        {
            if (Id != Guid.Empty)
            {
                return dll.TestDurumuDuzenle(new Test()
                {
                    TestID = Id,
                    Tarih = DateTime.Now


                });

            }
            else return -1;
        }
        public List<Test> TestDereceListe(int derece)
        {
            try
            {
                SqlDataReader reader = dll.TestDereceListe(derece);
                while (reader.Read())
                {
                    ListeTestDerece.Add(new Sözlük.Entities.Test()
                    {
                        KeliemeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                       
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return ListeTestDerece;

        }
        public List<Test> ListeleTest()
        {
            try
            {
                SqlDataReader reader = dll.TestListele();
                while (reader.Read())
                {
                    TestListele.Add(new Test()
                    {
                        KeliemeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Derece = reader.GetInt32(3),
                        
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return TestListele;


        }
    }
}
