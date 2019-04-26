using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int KelimeEkle(string kelimeIngilizce, string kelimeTurkce, string aciklama, string cumle)
        {
            if (!string.IsNullOrEmpty(kelimeIngilizce) && !string.IsNullOrEmpty(kelimeTurkce) && !string.IsNullOrEmpty(aciklama) && !string.IsNullOrEmpty(cumle))
            {
                return dll.KelimeEkle(new Sözlük.Entities.Kelime()//yeni nesne oluşturulur burada
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
    }
}
