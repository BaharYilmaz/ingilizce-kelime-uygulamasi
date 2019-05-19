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
    public partial class Kelime_Ekle : DevExpress.XtraEditors.XtraUserControl
    {
        private static Kelime_Ekle _instance;
        public static Kelime_Ekle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kelime_Ekle();
                return _instance;

            }
        }
        public Kelime_Ekle()
        {
            InitializeComponent();
        }
        private Boolean durum=false;
      

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Kelime> KelimeListe = bll.KelimeListele();

            
            if (KelimeListe != null )
            {
                for (int i = 0; i < KelimeListe.Count; i++)
                {
                    if (KelimeListe[i].KelimeIngilizce == txt_ekleKelime.Text)
                    {
                        durum = true;
                        break;
                    }
                    
                    
                }

            }

            if (durum == false)
            {
                
                bll.KelimeEkle(txt_ekleKelime.Text, txt_ekleAnlam.Text, txt_ekleTur.Text, txt_ekleCumle.Text);
                MessageBox.Show("Yeni Kayit Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ekleKelime.Text = "";
                txt_ekleAnlam.Text = "";
                txt_ekleTur.Text = "";
                txt_ekleCumle.Text = "";
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme Başarısız. Aynı Kelimeden Bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ekleKelime.Text = "";
                txt_ekleAnlam.Text = "";
                txt_ekleTur.Text = "";
                txt_ekleCumle.Text = "";
                durum = false;
            }
        }
    }
}
