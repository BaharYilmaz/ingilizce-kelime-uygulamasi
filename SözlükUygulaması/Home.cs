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
        public Home()
        {
            InitializeComponent();
        }

        private void _container_Click(object sender, EventArgs e)
        {

        }

        private void ace_giris_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Login.Instance))
            {
                _container.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }
            Login.Instance.BringToFront();
        }

        private void ace_cikis_Click(object sender, EventArgs e)
        {

        }

        private void ace_kelimeSec_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Kelime_Sec.Instance))
            {
                _container.Controls.Add(Kelime_Sec.Instance);
                Kelime_Sec.Instance.Dock = DockStyle.Fill;
                Kelime_Sec.Instance.BringToFront();
            }
            Kelime_Sec.Instance.BringToFront();

        }

        private void ace_ogren_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Ogren_.Instance))
            {
                _container.Controls.Add(Ogren_.Instance);
                Ogren_.Instance.Dock = DockStyle.Fill;
                Ogren_.Instance.BringToFront();
            }
            Ogren_.Instance.BringToFront();
        }

        private void ace_test_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Test_.Instance))
            {
                _container.Controls.Add(Test_.Instance);
                Test_.Instance.Dock = DockStyle.Fill;
                Test_.Instance.BringToFront();
            }
            Test_.Instance.BringToFront();


        }

        private void ace_ogrenilen_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Ogrenilmis.Instance))
            {
                _container.Controls.Add(Ogrenilmis.Instance);
                Ogrenilmis.Instance.Dock = DockStyle.Fill;
                Ogrenilmis.Instance.BringToFront();
            }
            Ogrenilmis.Instance.BringToFront();

        }

        private void ace_kelimeEkle_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Kelime_Ekle.Instance))
            {
                _container.Controls.Add(Kelime_Ekle.Instance);
                Kelime_Ekle.Instance.Dock = DockStyle.Fill;
                Kelime_Ekle.Instance.BringToFront();
            }
            Kelime_Ekle.Instance.BringToFront();
        }

        private void ace_yardim_Click(object sender, EventArgs e)
        {
            if (!_container.Controls.Contains(Help.Instance))
            {
                _container.Controls.Add(Help.Instance);
                Help.Instance.Dock = DockStyle.Fill;
                Help.Instance.BringToFront();
            }
            Help.Instance.BringToFront();
        }
    }
}
