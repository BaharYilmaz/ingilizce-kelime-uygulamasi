using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sözlük.Entities;


namespace SözlükUygulaması
{
    public partial class KelimeSec : Form
    {
        public KelimeSec()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void KelimeSec_Load(object sender, EventArgs e)
        {

            ListeDoldur();
        }
        private void ListeDoldur()
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Kelime> KelimeListesi = BLL.KelimeListele();

        }
    }
}
