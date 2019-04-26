using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
           // txt_sifre.PasswordChar = '*';
           
        }
        public static bool Kontrol { get; set; }
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (txt_kullanıcıAdı.Text=="a"&&txt_sifre.Text=="a")
            {
                Kontrol = false;
                AnaMenu anaMenu = new AnaMenu();
                this.Hide();
                anaMenu.Show();


            }
            else
            {
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