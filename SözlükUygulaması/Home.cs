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
        DialogResult sonuc;
        public bool kontrol;

        public Home()
        {
            InitializeComponent();
        }

        private void ace_cikis_Click(object sender, EventArgs e)
        {
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {

                this.Close();
                Application.Exit();

            }
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
        

        private void ace_Istatistik_Click(object sender, EventArgs e)
        {
            if (!pnl_home.Controls.Contains(Istatistik.Instance))
            {
                pnl_home.Controls.Add(Istatistik.Instance);
                Istatistik.Instance.Dock = DockStyle.Fill;
                Istatistik.Instance.BringToFront();
            }
            Istatistik.Instance.BringToFront();
           

        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
    }
}
