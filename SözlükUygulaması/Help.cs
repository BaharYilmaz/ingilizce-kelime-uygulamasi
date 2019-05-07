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
    public partial class Help : DevExpress.XtraEditors.XtraUserControl
    {
        private static Help _instance;
        public static Help Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Help();
                return _instance;

            }
        }
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
