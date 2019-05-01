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
            int[] cvp = new int[4];
            int kucuk = 0, j = 0;
            string[] cevp = new string[4];


            for (int i = 0; i < 4; i++)
            {
                cvp[i] = rnd.Next(0, 200);

            }

            int[] sayi = new int[3];
            sayi[0] = rnd.Next(ListeDurum.Count / 3);
            sayi[1] = rnd.Next(ListeDurum.Count / 3, ListeDurum.Count * 2 / 3);
            sayi[2] = rnd.Next(ListeDurum.Count * 2 / 3, ListeDurum.Count);

            for (int i = 0; i < 3; i++)
            {
                if (cvp[i] < cvp[i + 1]) kucuk = i;
            }
            cevp[kucuk] = Cevap;

            for (int i = 0; i < 4; i++)
            {
                if (i != kucuk)
                {
                    cevp[i] = ListeDurum[sayi[j]].KelimeTurkce;
                    j++;
                }
                else continue;
            }

            btn_testBir.Text = cevp[0];
            btn_testIki.Text = cevp[1];
            btn_testUc.Text = cevp[2];
            btn_testDort.Text = cevp[3];

        }

    }
}
