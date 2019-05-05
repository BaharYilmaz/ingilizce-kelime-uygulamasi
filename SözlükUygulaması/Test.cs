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
    public partial class Test : Form
    {
        BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
        private bool KontrolCevap { get; set; }
        private Guid ID { get; set; }
        private int i = 0;

        public Test()
        {
            InitializeComponent();

        }
        private void Test_Load(object sender, EventArgs e)
        {
            
            KelimeDoldur();
           
           
        }

        private void KelimeDoldur()
        {
            
            List<Kelime> ListeYazdir =BLL.TesteYazdir();
            i++;
            if (ListeYazdir != null && ListeYazdir.Count > 0 && i < ListeYazdir.Count)
            {
                txt_TestKelime.Text = ListeYazdir[i].KelimeIngilizce;
                ID = ListeYazdir[i].KelimeID;

                btn_testIki.Enabled = true;
                btn_testUc.Enabled = true;
                btn_testBir.Enabled = true;
                btn_testDort.Enabled = true;

                btn_testBir.Appearance.BackColor = Color.White;
                btn_testIki.Appearance.BackColor = Color.White;
                btn_testUc.Appearance.BackColor = Color.White;
                btn_testDort.Appearance.BackColor = Color.White;


                SecenekDoldur(ListeYazdir[i].KelimeTurkce);
            }

        }
        private void SecenekDoldur(string Cevap)
        {

            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> ListeDurum = BLL.ListeleDurum("test");
            Random rnd = new Random();
            int[] sayilar = new int[4];//random sayi atma
            int kucuk = 0, j = 0;
            string[] cvp = new string[4];//en küçük değerli indis alınır


            for (int i = 0; i < 4; i++)
            {
                sayilar[i] = rnd.Next(0, 200);

            }

            int[] sayi = new int[3];
            sayi[0] = rnd.Next(ListeDurum.Count / 3);
            sayi[1] = rnd.Next(ListeDurum.Count / 3, ListeDurum.Count * 2 / 3);
            sayi[2] = rnd.Next(ListeDurum.Count * 2 / 3, ListeDurum.Count);

            for (int i = 0; i < 3; i++)
            {
                if (sayilar[i] < sayilar[i + 1]) kucuk = i;
            }
            cvp[kucuk] = Cevap;

            for (int i = 0; i < 4; i++)
            {
                if (i != kucuk)
                {
                    cvp[i] = ListeDurum[sayi[j]].KelimeTurkce;
                    j++;
                }
                else continue;
            }

            btn_testBir.Text = cvp[0]; if (btn_testBir.Text == Cevap) btn_testBir.Tag = true; else btn_testBir.Tag = false;
            btn_testIki.Text = cvp[1]; if (btn_testIki.Text == Cevap) btn_testIki.Tag = true; else btn_testIki.Tag = false;
            btn_testUc.Text = cvp[2]; if (btn_testUc.Text == Cevap) btn_testUc.Tag = true; else btn_testUc.Tag = false;
            btn_testDort.Text = cvp[3]; if (btn_testDort.Text == Cevap) btn_testDort.Tag = true; else btn_testDort.Tag = false;

        }

        private void Kontrol()
        {

            if (KontrolCevap == true )
            {
               List<Kelime>ListeBasarili=BLL.ListeleDerece(4);
                for (int i = 0; i < ListeBasarili.Count; i++)
                {
                    if (ID == ListeBasarili[i].KelimeID)
                    {
                        BLL.KelimeDurumDuzenle(ID, "ogrenilmis");
                    }
                    else
                    {
                        BLL.KelimeDereceDuzenle(ID);
                        KelimeDoldur();
                    }

                }
              
            }
            else 
            {
                BLL.KelimeDurumDuzenle(ID, "ogren");
                KelimeDoldur();

            }
          
        }


        private void btn_testBir_Click_1(object sender, EventArgs e)
        {
            btn_testIki.Enabled = false;
            btn_testUc.Enabled = false;
            btn_testDort.Enabled = false;

            bool kontrol1 = (bool)btn_testBir.Tag;
            if (kontrol1 == true)
            {
                btn_testBir.Appearance.BackColor = Color.LimeGreen;
                KontrolCevap = true;
            }
            else
            {
                btn_testBir.Appearance.BackColor = Color.OrangeRed;
                KontrolCevap = false;
            }
            Kontrol();

        }

        private void btn_testIki_Click_1(object sender, EventArgs e)
        {
            btn_testBir.Enabled = false;
            btn_testUc.Enabled = false;
            btn_testDort.Enabled = false;

            bool kontrol1 = (bool)btn_testIki.Tag;
            if (kontrol1 == true)
            {
                btn_testIki.Appearance.BackColor = Color.LimeGreen;
                KontrolCevap = true;
            }
            else
            {
                btn_testIki.Appearance.BackColor = Color.OrangeRed;
                KontrolCevap = false;
            }
            Kontrol();

        }

        private void btn_testUc_Click_1(object sender, EventArgs e)
        {

            btn_testIki.Enabled = false;
            btn_testBir.Enabled = false;
            btn_testDort.Enabled = false;

            bool kontrol1 = (bool)btn_testUc.Tag;
            if (kontrol1 == true)
            {
                btn_testUc.Appearance.BackColor = Color.LimeGreen;
                KontrolCevap = true;
            }
            else
            {
                btn_testUc.Appearance.BackColor = Color.OrangeRed;
                KontrolCevap = false;
            }
            Kontrol();
        }


        private void btn_testDort_Click_1(object sender, EventArgs e)
        {
            btn_testIki.Enabled = false;
            btn_testUc.Enabled = false;
            btn_testBir.Enabled = false;

            bool kontrol1 = (bool)btn_testDort.Tag;
            if (kontrol1 == true)
            {
                btn_testDort.Appearance.BackColor = Color.LimeGreen;              
                KontrolCevap = true;
            }
            else
            {
                btn_testDort.Appearance.BackColor = Color.OrangeRed;
                KontrolCevap = false;
            }
            Kontrol();
           
        }

    }
}
