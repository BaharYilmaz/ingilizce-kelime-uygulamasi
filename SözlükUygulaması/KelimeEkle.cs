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
    public partial class KelimeEkle : Form
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }

        private void KelimeEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();

            int returnValue = bll.KelimeEkle(txt_ekleKelime.Text, txt_ekleAnlam.Text, txt_ekleTur.Text, txt_ekleCumle.Text);
            if (returnValue>0)
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
