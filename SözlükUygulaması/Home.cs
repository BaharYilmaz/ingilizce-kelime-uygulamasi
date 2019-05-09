using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;

            }
        }

        public bool kontrol;

        public Home()
        {
            InitializeComponent();
            this.kontrol = Login.Kontrol;

        }
       
        private void _container_Click(object sender, EventArgs e)
        {
            
        }

        private void ace_giris_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Login.Instance))
            {
                pnl_home.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }
            Login.Instance.BringToFront();
        }

        private void ace_cikis_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(LogOut.Instance))
            {
                pnl_home.Controls.Add(LogOut.Instance);
                LogOut.Instance.Dock = DockStyle.Fill;
                LogOut.Instance.BringToFront();
            }
            LogOut.Instance.BringToFront();
        }

        private void ace_kelimeSec_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Kelime_Sec.Instance))
            {
                pnl_home.Controls.Add(Kelime_Sec.Instance);
                Kelime_Sec.Instance.Dock = DockStyle.Fill;
                Kelime_Sec.Instance.BringToFront();
            }
            Kelime_Sec.Instance.BringToFront();

        }

        private void ace_ogren_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(KelimeOgren.Instance))
            {
                pnl_home.Controls.Add(KelimeOgren.Instance);
                KelimeOgren.Instance.Dock = DockStyle.Fill;
                KelimeOgren.Instance.BringToFront();
            }
            KelimeOgren.Instance.BringToFront();
        }

        private void ace_test_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Test_.Instance))
            {
                pnl_home.Controls.Add(Test_.Instance);
                Test_.Instance.Dock = DockStyle.Fill;
                Test_.Instance.BringToFront();
            }
            Test_.Instance.BringToFront();
        }

        private void ace_ogrenilen_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Ogrenilmis.Instance))
            {
                pnl_home.Controls.Add(Ogrenilmis.Instance);
                Ogrenilmis.Instance.Dock = DockStyle.Fill;
                Ogrenilmis.Instance.BringToFront();
            }
            Ogrenilmis.Instance.BringToFront();

        }

        private void ace_kelimeEkle_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Kelime_Ekle.Instance))
            {
                pnl_home.Controls.Add(Kelime_Ekle.Instance);
                Kelime_Ekle.Instance.Dock = DockStyle.Fill;
                Kelime_Ekle.Instance.BringToFront();
            }
            Kelime_Ekle.Instance.BringToFront();
        }

        private void ace_yardim_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Help.Instance))
            {
                pnl_home.Controls.Add(Help.Instance);
                Help.Instance.Dock = DockStyle.Fill;
                Help.Instance.BringToFront();
            }
            Help.Instance.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                ace_giris.Enabled = true;
                ace_cikis.Enabled = false;
                ace_Istatistik.Enabled = false;
                ace_AnaMenu.Enabled = true;
                ace_kelimeSec.Enabled = false;
                ace_kelimeEkle.Enabled = false;
                ace_ogren.Enabled = false;
                ace_test.Enabled = false;
                ace_ogrenilen.Enabled = false;
            }
            else
            {
                ace_giris.Enabled = false;
                ace_cikis.Enabled = true;
                ace_Istatistik.Enabled = true;
                ace_AnaMenu.Enabled = true;
                ace_kelimeSec.Enabled = true;
                ace_kelimeEkle.Enabled = true;
                ace_ogren.Enabled = true;
                ace_test.Enabled = true;
                ace_ogrenilen.Enabled = true;
            }
        }
      
        private void pnl_home_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
