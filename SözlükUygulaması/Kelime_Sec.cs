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
using SözlükUygulaması;

namespace SözlükUygulaması
{
    public partial class Kelime_Sec : DevExpress.XtraEditors.XtraUserControl
    {
        private static Kelime_Sec _instance;
        public static Kelime_Sec Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kelime_Sec();
                return _instance;

            }
        }
        public Kelime_Sec()
        {
            InitializeComponent();
            pnl_sec.Enabled = true;

        }

        private void Kelime_Sec_Load(object sender, EventArgs e)
        {
            ListeDoldur();
            btn_secBiliyorum.Enabled = false;
            btn_secOgren.Enabled = false;

        }
        private void ListeDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> KelimeListesi = BLL.ListeleDurum("NULL");
            if (KelimeListesi != null && KelimeListesi.Count > 9)
            {
                for (int i = 0; i < 10; i++)
                {
                   
                   listBox_sec.Items.Add(KelimeListesi[i]);
                }

            }
            else if (KelimeListesi != null && KelimeListesi.Count > 0)
            {
                foreach (Kelime item in KelimeListesi)
                {
                    listBox_sec.Items.Add(item);
                }
            }
        }
        
        private void listBox_sec_Click_1(object sender, EventArgs e)
        {
            btn_secOgren.Enabled = true;
            btn_secBiliyorum.Enabled = true;
        }

        private void btn_secBiliyorum_Click_1(object sender, EventArgs e)
        {
            int j = 0;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KelimeID;
            BLL.KelimeDurumDuzenle(KelimeID, "test");
            BLL.KelimeDereceDuzenle(KelimeID, 0);
            listBox_sec.Items.Remove(listBox_sec.SelectedItem);
            j++;

            if (listBox_sec.ItemCount == 0)
            {
                pnl_sec.Enabled = false;

            }
        }

        private void btn_secOgren_Click_1(object sender, EventArgs e)
        {

            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KelimeID;
            BLL.KelimeDurumDuzenle(KelimeID, "ogren");
            listBox_sec.Items.Remove(listBox_sec.SelectedItem);

            if (listBox_sec.ItemCount == 0)
            {
                pnl_sec.Enabled = false;
                KelimeOgren ogr = KelimeOgren.Instance;
                ogr.BringToFront();
                ogr.Show();
            }

        }

    }
}
