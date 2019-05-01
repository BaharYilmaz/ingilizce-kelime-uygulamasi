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

        public Test()
        {
            InitializeComponent();

        }

        private void Test_Load(object sender, EventArgs e)
        {
            KeliemDoldur();
        }
        
        private void KeliemDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> ListeDurum = BLL.ListeleDurum("test");

            if (ListeDurum != null && ListeDurum.Count > 0)
            {
                int i = 0;
                do
                {
                    txt_TestKelime.Text = ListeDurum[i].KelimeIngilizce;
                    SecenekDoldur(ListeDurum[i].KelimeTurkce);
                    i++;
                } while (i < ListeDurum.Count);

            }

        }
        private void SecenekDoldur(string Cevap)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> ListeDurum = BLL.ListeleDurum("test");

            Random rnd = new Random();

            int sayi = rnd.Next(ListeDurum.Count / 3);
            int sayi2 = rnd.Next(ListeDurum.Count / 3, ListeDurum.Count * 2 / 3);
            int sayi3 = rnd.Next(ListeDurum.Count * 2 / 3, ListeDurum.Count);


            string[] cevaplar = new string[4] { ListeDurum[sayi].KelimeTurkce, ListeDurum[sayi2].KelimeTurkce, ListeDurum[sayi3].KelimeTurkce, Cevap };

            int[] sayilar = new int[4];
            int eleman;
            Random random = new Random();

            
            int i = 0;
            while (i < 4)
            {
                eleman = random.Next(0, 3);
                int yoksa = Array.IndexOf(sayilar, eleman);
                if (yoksa == -1)
                {
                    sayilar[i] = eleman;
                    
                    i++;
                }
            }

            while (ListeDurum.Count > 0 && ListeDurum != null)
            {
                btn_testBir.Text = cevaplar[sayilar[0]];
                btn_testIki.Text = cevaplar[sayilar[1]];
                btn_testUc.Text = cevaplar[sayilar[2]];
                btn_testDort.Text = cevaplar[sayilar[3]];
            }

        }

    }
}
