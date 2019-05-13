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
    public partial class LogOut : DevExpress.XtraEditors.XtraUserControl
    {
        private static LogOut _instance;
        public static LogOut Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LogOut();
                return _instance;

            }
        }
        DialogResult sonuc;

        public LogOut()
        {
            InitializeComponent();
        }

        private void LogOut_Load(object sender, EventArgs e)
        {

        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {

            if (txt_sifre.Text == "a")
            {
                sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.No)
                {
                    txt_sifre.Text = "";
                }
                if (sonuc == DialogResult.Yes)
                {
                   
                    this.Close();
                    Application.Exit();
                    
                }
            }
            else
            {

                MessageBox.Show("       Yanlış şifre girdiniz.      ");
                txt_sifre.Text = "";
            }
        }

        private void Close()
        {
            this.Hide();
        }

        private void txt_sifre_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = "";
        }

        
    }
}
