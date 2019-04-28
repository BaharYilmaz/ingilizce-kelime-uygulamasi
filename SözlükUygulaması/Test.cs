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

        private void btn_testUc_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void KeliemDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();



            List<Kelime> ListeDurum = BLL.ListeleDurum("test");

            if (ListeDurum!=null&&ListeDurum.Count>0) 
            { int i =0;
                //for (int i = 0; i < ListeDurum.Count; i++)
                do
                {
                    txt_TestKelime.Text = ListeDurum[i].KelimeIngilizce; ///
                    btn_testBir.Text = ListeDurum[i].KelimeTurkce;
                    SecenekDoldur(ListeDurum[i].KelimeTurkce);
                    i++;
                } while (i< ListeDurum.Count);

            }

        }
        private void SecenekDoldur(string Cevap)
        {

            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();


            List<Kelime> ListeDurum = BLL.ListeleDurum("test");

            for (; ; )
            {
                /////

                Random rnd = new Random();

                int sayi = rnd.Next(ListeDurum.Count / 3);
                int sayi2 = rnd.Next(ListeDurum.Count / 3, (ListeDurum.Count) * (2 / 3));
                int sayi3 = rnd.Next(ListeDurum.Count * (2 / 3), ListeDurum.Count);

                if (Cevap != ListeDurum[sayi].ToString() && Cevap != ListeDurum[sayi2].ToString() && Cevap != ListeDurum[sayi3].ToString())
                {
                    if (ListeDurum != null && ListeDurum.Count > 0)
                    {


                        btn_testIki.Text = ListeDurum[sayi].KelimeTurkce;
                        btn_testUc.Text = ListeDurum[sayi2].KelimeTurkce;
                        btn_testDort.Text = ListeDurum[sayi3].KelimeTurkce;
                        break;

                    }
                   
                }
                
                
            }

        }
           
    }
}
