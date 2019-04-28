using Sözlük.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class OgrenilenKelimeler : Form
    {
        BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();

        public OgrenilenKelimeler()
        {
            InitializeComponent();
        }

        private void OgrenilenKelimeler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            List<Kelime> KListe = BLL.ListeleDurum("ogrenilmis");

            if (KListe!=null  && KListe.Count>0)
            {
                listBox_Ogrenilmis.DataSource = KListe;
            }

           
        }
    }
}
