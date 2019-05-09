using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SözlükUygulaması
{
    public partial class GirisYap : DevExpress.XtraEditors.XtraForm
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void txt_kullanıcıAdı_Click(object sender, EventArgs e)
        {
            txt_kullanıcıAdı.Text = "";
        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = "";
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (txt_kullanıcıAdı.Text == "a" && txt_sifre.Text == "a")
            {
                Home h = new Home();
                this.Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Lütfen doğru kullanıcı adı veya şifre giriniz.");
                txt_kullanıcıAdı.Text = "";
                txt_sifre.Text = "";
            }
        }
    }
}