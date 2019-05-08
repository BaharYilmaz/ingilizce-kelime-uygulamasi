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
    public partial class Login : DevExpress.XtraEditors.XtraUserControl
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;

            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static bool Kontrol { get; set; }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (txt_kullanıcıAdı.Text == "a" && txt_sifre.Text == "a")
            {
                Kontrol = true;
                Home h = new Home();
                this.Hide();
                h.Show();


            }
            else
            {
                Kontrol = false;
                MessageBox.Show("Lütfen doğru kullanıcı adı veya şifre giriniz.");
                txt_kullanıcıAdı.Text = "";
                txt_sifre.Text = "";
            }
        }

        private void txt_kullanıcıAdı_Click(object sender, EventArgs e)
        {
            txt_kullanıcıAdı.Text = "";

        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = "";

        }
    }
}
