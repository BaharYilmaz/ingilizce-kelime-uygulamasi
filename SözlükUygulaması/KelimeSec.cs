using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sözlük.Entities;


namespace SözlükUygulaması
{
    public partial class KelimeSec : Form
    {

        public KelimeSec()
        {
            InitializeComponent();
        }


        private void KelimeSec_Load(object sender, EventArgs e)
        {
            ListeDoldur();
            btn_secBiliyorum.Enabled = false;
            btn_secOgren.Enabled = false;


        }
        private void ListeDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> KelimeListesi = BLL.KelimeListele();
            if (KelimeListesi != null && KelimeListesi.Count > 0)
            {
                foreach (Kelime k in KelimeListesi)
                {
                    listBox_sec.Items.Add(k);

                }
            }

        }
       
        private void btn_secBiliyorum_Click(object sender, EventArgs e)
        {

            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KeliemeID;
            BLL.KelimeDurumDuzenle(KelimeID, "test");
            listBox_sec.Items.Remove(listBox_sec.SelectedItem);

      

            if (listBox_sec.ItemCount==0)
            {
                Ogren ogr = new Ogren();
                this.Hide();
                ogr.Show();
            }


        }

        private void btn_secOgren_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KeliemeID;
            BLL.KelimeDurumDuzenle(KelimeID, "ogren");
            listBox_sec.Items.Remove(listBox_sec.SelectedItem);
           
            if (listBox_sec.ItemCount == 0)
            {
                Ogren ogr = new Ogren();
                this.Hide();
                ogr.Show();
            }



        }

        private void listBox_sec_Click(object sender, EventArgs e)
        {
            btn_secOgren.Enabled = true;
            btn_secBiliyorum.Enabled = true;
           
        }
    }
}
