using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sözlük.Entities
{
    public class Kelime
    {
        public Guid KelimeID { get; set; }
        public string KelimeIngilizce { get; set; }
        public string Aciklama { get; set; }
        public string KelimeTurkce { get; set; }
        public string Cumle { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
        public int Derece { get; set; }
       
        public override string ToString()
        {
            return KelimeIngilizce;//
        }
    }

}
