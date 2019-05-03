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
            List<Kelime> KelimeListesi = BLL.ListeleDurum("NULL");
            if (KelimeListesi != null && KelimeListesi.Count > 9)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox_sec.Items.Add(KelimeListesi[i]);
                }                
                
            }
            else if(KelimeListesi != null&& KelimeListesi.Count > 0)
            {
                foreach (Kelime item in KelimeListesi)
                {
                    listBox_sec.Items.Add(item);

                }
            }

        }
       
        private void btn_secBiliyorum_Click(object sender, EventArgs e)
        {
            int j = 0;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KelimeID;
            BLL.KelimeDurumDuzenle(KelimeID, "test");
            BLL.KelimeDereceDuzenle(KelimeID);
            listBox_sec.Items.Remove(listBox_sec.SelectedItem);
            j++;

            if (listBox_sec.ItemCount == 0) //listenin10danAzOlmasıHesaplanmadı
            {
                if (j < 10)
                {
                    Ogren ogr = new Ogren();
                    this.Hide();
                    ogr.Show();
                }
                else
                {
                    Test test = new Test();
                    this.Hide();
                    test.Show();
                }
            }

        }

        private void btn_secOgren_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            Guid KelimeID = ((Kelime)listBox_sec.SelectedItem).KelimeID;
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
