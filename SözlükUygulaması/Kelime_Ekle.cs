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

        private void Kelime_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();

            int returnValue = bll.KelimeEkle(txt_ekleKelime.Text, txt_ekleAnlam.Text, txt_ekleTur.Text, txt_ekleCumle.Text);
            if (returnValue > 0)
            {
                MessageBox.Show("Yeni Kayit Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Kayıt Ekleme Başarısız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_ekleKelime.Text = "";
            txt_ekleAnlam.Text = "";
            txt_ekleTur.Text = "";
            txt_ekleCumle.Text = "";
        }
    }
}
