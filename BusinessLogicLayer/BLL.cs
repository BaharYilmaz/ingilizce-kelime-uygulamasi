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
        List<Kelime> KelimeListeleDerece = new List<Kelime>();
        List<Istatistik_> ListIstatistik = new List<Istatistik_>();

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
                    KelimeID = Guid.NewGuid(),
                    KelimeIngilizce = kelimeIngilizce,
                    KelimeTurkce = kelimeTurkce,
                    Aciklama = aciklama,
                    Cumle = cumle,
                    Derece = -1

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
                while (reader.Read())
                {
                    KelimeListesi.Add(new Kelime()
                    {
                        KelimeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Cumle = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Durum = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
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
            return KelimeListesi;

        }
        public List<Kelime> ListeleDurum(string durum)
        {
            try
            {
                SqlDataReader reader = dll.KelimeListeleDurum(durum);
                while (reader.Read())
                {
                    KelimeListeleDurum.Add(new Kelime()
                    {
                        KelimeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Cumle = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),

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
            return KelimeListeleDurum;
        }
        public List<Kelime> ListeleDerece(int derece)
        {

            try
            {
                SqlDataReader reader = dll.KelimeListeleDerece(derece);
                while (reader.Read())
                {
                    KelimeListeleDerece.Add(new Kelime()
                    {
                        KelimeID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        KelimeIngilizce = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        KelimeTurkce = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Cumle = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Durum = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Tarih = reader.GetDateTime(6),
                        Derece = reader.GetInt32(7),


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
            return KelimeListeleDerece;
        }

        public int KelimeDurumDuzenle(Guid ID, string durum)
        {
            if (ID != Guid.Empty)
            {
                return dll.DurumGüncelle(new Kelime()
                {

                    KelimeID = ID,
                    Durum = durum

                });

            }
            else return -1;
        }
        public int KelimeDereceDuzenle(Guid ID, int derece)
        {
            if (ID != Guid.Empty)
            {

                return dll.DereceGüncelle(new Kelime()
                {
                    KelimeID = ID,
                    Derece = derece,
                    Tarih = DateTime.Now

                });
            }
            else return -1;
        }
        public int Sifirla()
        {
            return dll.Sifirla();
        }
        public List<Kelime> TesteYazdir()
        {
            List<Kelime> listdurum = ListeleDurum("test");
            int j = 1;
            while (j < 5)
            {
                List<Kelime> listDerece = ListeleDerece(j);
                for (int i = 0; i < listDerece.Count; i++)
                {
                    TimeSpan fark = DateTime.Now - listDerece[i].Tarih;
                    if (j == 1 && fark.Days == 1)
                    {
                        listdurum.Add(listDerece[i]);
                    }
                    else if (j == 2 && fark.Days == 7)
                    {
                        listdurum.Add(listDerece[i]);
                    }
                    else if (j == 3 && fark.Days == 30)
                    {
                        listdurum.Add(listDerece[i]);
                    }
                    else if (j == 4 && fark.Days == 180)
                    {
                        listdurum.Add(listDerece[i]);
                    }
                    else continue;
                }
                j++;
            }
            return listdurum;

        }
        public List<Istatistik_> IstatistikYazdir()
        {
            try
            {
                SqlDataReader reader = dll.IstatistikYazdir();
                while (reader.Read())
                {
                    ListIstatistik.Add(new Istatistik_()
                    {
                        Ay = reader.GetInt32(0),
                        KelimeSayisi = reader.GetInt32(1)
               
                    });
                  
                }
                reader.Close();

            }
            catch (Exception) { throw; }
            finally { dll.BaglantiAyarla(); }
            return ListIstatistik;

        }
        
    }
}
