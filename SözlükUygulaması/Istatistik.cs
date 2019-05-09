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
    public partial class Istatistik : DevExpress.XtraEditors.XtraUserControl
    {
        private static Istatistik _instance;
        public static Istatistik Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Istatistik();
                return _instance;

            }
        }
       

        public Istatistik()
        {
            InitializeComponent();
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Istatistik_> listChart = bll.IstatistikYazdir();
            if (listChart.Count>0)
            {
                chart_Istatistik.Series["Series 1"].Points.AddPoint(Convert.ToInt32(listChart[0].Ay), int.Parse(listChart[1].KelimeSayisi.ToString()));
                lbl_bilgi.Text = "Öğrenilmiş kelimelerin istatiksel grafiği";
            }
            else
            {
                lbl_bilgi.Text = "Henüz öğrenilmiş bir kelime yok";
            }

        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Tüm İlerlemeyi Sıfırlamak İstediğinizden Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
                bll.Sifirla();
            
            }
        }
    }
}
