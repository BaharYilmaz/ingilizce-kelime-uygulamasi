using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sözlük.Entities;

namespace SözlükUygulaması
{
    public partial class Ogrenilmis : DevExpress.XtraEditors.XtraUserControl
    {
        private static Ogrenilmis _instance;
        public static Ogrenilmis Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ogrenilmis();
                return _instance;

            }
        }

        BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();

        public Ogrenilmis()
        {
            InitializeComponent();
        }

        private void Ogrenilmis_Load(object sender, EventArgs e)
        {

            Doldur();
        }
        private void Doldur()
        {
            List<Kelime> KListe = BLL.ListeleDurum("ogrenilmis");

            if (KListe != null && KListe.Count > 0)
            {
                listBox_Ogrenilmis.DataSource = KListe;
            }


        }

    }
}
