using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sözlük.Entities
{
    public class Test:Kelime
    {
        public Guid TestID { get; set; }
        public DateTime Tarih { get; set; }
        public int Derece { get; set; }
    }
}
