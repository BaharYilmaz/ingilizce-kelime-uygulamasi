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
        string[] aylar = new string[12] {"Ocak","Subat","Mart","Nisan","Mayis","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık" };
        

        private void Istatistik_Load(object sender, EventArgs e)
        {
            _Istatistik();
            this.lbl_bilgi.Location = new System.Drawing.Point(200, 350);
            this.lbl_bilgi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Tüm İlerlemeyi Sıfırlamak İstediğinizden Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
                bll.Sifirla();
                _Istatistik();

            }
        }
        private void _Istatistik()
        {
            int i = 0, j = 1;
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Istatistik_> listChart = bll.IstatistikYazdir();
            if (listChart.Count == 0)
            {
                lbl_bilgi.Text = "Henüz öğrenilmiş bir kelime yok";
            }

            while (listChart.Count > 0 && i < listChart.Count)
            {
                if (listChart[i].Ay == j)
                {
                    chart_Istatistik.Series["Kelime"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(aylar[j - 1], listChart[i].KelimeSayisi));
                    i++; j = 1;
                }
                else j++;
                lbl_bilgi.Text = "Öğrenilmiş kelimelerin istatiksel grafiği";
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
