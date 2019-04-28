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
            
            do
            {
                if(i==0)  btn_geri.Enabled = false;
                if (i == liste.Count) btn_ileri.Enabled = false;

                lbl_ogrenKelime.Text = liste[i].KelimeIngilizce;
                txt_ogrenAnlam.Text = liste[i].KelimeTurkce;
                txt_ogrenTur.Text = liste[i].Aciklama;
                txt_ogrenCumle.Text = liste[i].Cumle;

                    if (ButonDurum == false) i++;
                    else if(ButonDurum == false) i--;
                    
            } while (i<liste.Count);
            btn_bitir.Enabled = true;

        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            ButonDurum = false;

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            ButonDurum = true;
        }
    }
}
