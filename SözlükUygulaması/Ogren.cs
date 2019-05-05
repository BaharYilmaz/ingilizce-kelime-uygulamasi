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
    public partial class Ogren : Form
    {
        private bool ButonDurum = false;
        int i = 0;
      
        

        public Ogren()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLL BLL=new BusinessLogicLayer.BLL();
      


        private void Ogren_Load(object sender, EventArgs e)
        {
            Doldur();
            btn_bitir.Enabled = false;
        }

        private void Doldur()
        {
            List<Kelime> liste = BLL.ListeleDurum("ogren");

            if (i == 0) btn_geri.Enabled = false;
            else btn_geri.Enabled = true;

            if (i == liste.Count) btn_ileri.Enabled = false;
            else btn_ileri.Enabled = true;

            if (ButonDurum == true) i = i - 1;
            else i++;

            if (i < liste.Count)
            {

                lbl_ogrenKelime.Text = liste[i].KelimeIngilizce;
                txt_ogrenAnlam.Text = liste[i].KelimeTurkce;
                txt_ogrenTur.Text = liste[i].Aciklama;
                txt_ogrenCumle.Text = liste[i].Cumle;



            }
            else if (liste.Count == 0) btn_bitir.Enabled = true;
            { 
                    if (ButonDurum == false) i++;
                    else if(ButonDurum == false) i--;
                    
                    
            } while (i<liste.Count);
            btn_bitir.Enabled = true;


        }
        
        private void btn_ileri_Click(object sender, EventArgs e)
        {
            Doldur();

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            ButonDurum = true;
            Doldur();
            ButonDurum = false;
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            List<Kelime> liste = BLL.ListeleDurum("ogren");

            for (int i = 0; i <liste.Count ; i++)
            {
                BLL.KelimeDurumDuzenle(liste[i].KelimeID,"test");
                BLL.KelimeDereceDuzenle(liste[i].KelimeID);
            }
            Test t = new Test();
            this.Hide();
            t.Show();


        }
    }
}
