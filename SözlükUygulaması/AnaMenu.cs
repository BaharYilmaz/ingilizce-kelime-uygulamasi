using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class AnaMenu : Form
    {
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbn_kelimeSec;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_kelimeSec;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbn_ogren;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbn_test;
        private DevExpress.XtraBars.BarButtonItem btn_test;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbn_ogrenilen;
        private DevExpress.XtraBars.BarButtonItem btn_ögrenilmis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbn_kelimeEkle;
        private DevExpress.XtraBars.BarButtonItem btn_kelimeEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbnCtrl_anaMenu;
        private DevExpress.XtraBars.BarButtonItem btn_kelimeOgren;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btn_ogren;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;


        KelimeSec KS;
        Ogren O;
        Test T;
        OgrenilenKelimeler OK;
        KelimeEkle KE;
        Yardım Y;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Yardım;
        public bool kontrol;


        public AnaMenu()
        {
            InitializeComponent();
            this.kontrol = GirisEkranı.Kontrol;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbn_kelimeSec = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_kelimeSec = new DevExpress.XtraBars.BarButtonItem();
            this.rbn_ogren = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_kelimeOgren = new DevExpress.XtraBars.BarButtonItem();
            this.rbn_test = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_test = new DevExpress.XtraBars.BarButtonItem();
            this.rbn_ogrenilen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_ögrenilmis = new DevExpress.XtraBars.BarButtonItem();
            this.rbn_kelimeEkle = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_kelimeEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.rbnCtrl_anaMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ogren = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_Yardım = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbnCtrl_anaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbn_kelimeSec,
            this.rbn_ogren,
            this.rbn_test,
            this.rbn_ogrenilen,
            this.rbn_kelimeEkle,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // rbn_kelimeSec
            // 
            this.rbn_kelimeSec.ItemLinks.Add(this.barButtonItem1);
            this.rbn_kelimeSec.ItemLinks.Add(this.btn_kelimeSec);
            this.rbn_kelimeSec.Name = "rbn_kelimeSec";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_kelimeSec
            // 
            this.btn_kelimeSec.Caption = "KELİME SEÇ";
            this.btn_kelimeSec.Id = 2;
            this.btn_kelimeSec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kelimeSec.ImageOptions.SvgImage")));
            this.btn_kelimeSec.Name = "btn_kelimeSec";
            this.btn_kelimeSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_kelimeSec_ItemClick);
            // 
            // rbn_ogren
            // 
            this.rbn_ogren.ItemLinks.Add(this.btn_kelimeOgren);
            this.rbn_ogren.Name = "rbn_ogren";
            // 
            // btn_kelimeOgren
            // 
            this.btn_kelimeOgren.Caption = "KELİME ÖĞREN";
            this.btn_kelimeOgren.Id = 9;
            this.btn_kelimeOgren.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kelimeOgren.ImageOptions.SvgImage")));
            this.btn_kelimeOgren.Name = "btn_kelimeOgren";
            this.btn_kelimeOgren.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_kelimeOgren_ItemClick);
            // 
            // rbn_test
            // 
            this.rbn_test.ItemLinks.Add(this.btn_test);
            this.rbn_test.Name = "rbn_test";
            // 
            // btn_test
            // 
            this.btn_test.Caption = "TEST ET";
            this.btn_test.Id = 4;
            this.btn_test.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_test.ImageOptions.Image")));
            this.btn_test.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_test.ImageOptions.LargeImage")));
            this.btn_test.Name = "btn_test";
            this.btn_test.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_test_ItemClick);
            // 
            // rbn_ogrenilen
            // 
            this.rbn_ogrenilen.ItemLinks.Add(this.btn_ögrenilmis);
            this.rbn_ogrenilen.Name = "rbn_ogrenilen";
            // 
            // btn_ögrenilmis
            // 
            this.btn_ögrenilmis.Caption = "ÖĞRENİLMİŞ KELİMELER";
            this.btn_ögrenilmis.Id = 5;
            this.btn_ögrenilmis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ögrenilmis.ImageOptions.Image")));
            this.btn_ögrenilmis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ögrenilmis.ImageOptions.LargeImage")));
            this.btn_ögrenilmis.Name = "btn_ögrenilmis";
            this.btn_ögrenilmis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ögrenilmis_ItemClick);
            // 
            // rbn_kelimeEkle
            // 
            this.rbn_kelimeEkle.ItemLinks.Add(this.btn_kelimeEkle);
            this.rbn_kelimeEkle.Name = "rbn_kelimeEkle";
            // 
            // btn_kelimeEkle
            // 
            this.btn_kelimeEkle.Caption = "KELİME EKLE";
            this.btn_kelimeEkle.Id = 6;
            this.btn_kelimeEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kelimeEkle.ImageOptions.SvgImage")));
            this.btn_kelimeEkle.Name = "btn_kelimeEkle";
            this.btn_kelimeEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_kelimeEkle_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // rbnCtrl_anaMenu
            // 
            this.rbnCtrl_anaMenu.ExpandCollapseItem.Id = 0;
            this.rbnCtrl_anaMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnCtrl_anaMenu.ExpandCollapseItem,
            this.barButtonItem1,
            this.btn_kelimeSec,
            this.btn_test,
            this.btn_ögrenilmis,
            this.btn_kelimeEkle,
            this.barButtonItem2,
            this.btn_kelimeOgren,
            this.btn_Yardım});
            this.rbnCtrl_anaMenu.Location = new System.Drawing.Point(0, 0);
            this.rbnCtrl_anaMenu.MaxItemId = 11;
            this.rbnCtrl_anaMenu.Name = "rbnCtrl_anaMenu";
            this.rbnCtrl_anaMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rbnCtrl_anaMenu.Size = new System.Drawing.Size(852, 176);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btn_ogren
            // 
            this.btn_ogren.Caption = "KELİME ÖĞREN";
            this.btn_ogren.Id = 3;
            this.btn_ogren.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogren.ImageOptions.Image")));
            this.btn_ogren.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ogren.ImageOptions.LargeImage")));
            this.btn_ogren.Name = "btn_ogren";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "KELİME ÖĞREN";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Yardım);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btn_Yardım
            // 
            this.btn_Yardım.Caption = "YARDIM";
            this.btn_Yardım.Id = 10;
            this.btn_Yardım.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.btn_Yardım.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btn_Yardım.Name = "btn_Yardım";
            // 
            // AnaMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.rbnCtrl_anaMenu);
            this.IsMdiContainer = true;
            this.Name = "AnaMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbnCtrl_anaMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_kelimeSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KS==null)
            {
                KS = new KelimeSec();//
                KS.MdiParent = this;
                KS.FormClosed += KS_FormClosed;
                KS.Show();

            }
            else
                KS.Activate();
        }

        private void KS_FormClosed(object sender, FormClosedEventArgs e)
        {
            KS = null;  
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
                btn_kelimeSec.Enabled = true;
                btn_kelimeOgren.Enabled = false;
                btn_test.Enabled = true;
                btn_ögrenilmis.Enabled = true;
                btn_kelimeEkle.Enabled = true;
            
            
        }

        private void btn_kelimeOgren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (O == null)
            {
                O = new Ogren();//
                O.MdiParent = this;
                O.FormClosed += O_FormClosed; 
                O.Show();

            }
            else
                O.Activate();
        }

        private void O_FormClosed(object sender, FormClosedEventArgs e)
        {
            O = null;
        }

        private void btn_test_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (T == null)
            {
                T = new Test();
                T.MdiParent = this;
                T.FormClosed += T_FormClosed;
                T.Show();

            }
            else
                T.Activate();
        }

        private void T_FormClosed(object sender, FormClosedEventArgs e)
        {
            T = null;
        }

        private void btn_ögrenilmis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OK == null)
            {
                OK = new OgrenilenKelimeler();
                OK.MdiParent = this;
                OK.FormClosed += OK_FormClosed;
                OK.Show();

            }
            else
                OK.Activate();
        }

        private void OK_FormClosed(object sender, FormClosedEventArgs e)
        {
            OK = null;
        }

        private void btn_kelimeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KE == null)
            {
                KE = new KelimeEkle();
                KE.MdiParent = this;
                KE.FormClosed += KE_FormClosed;
                KE.Show();

            }
            else
                KE.Activate();
        }

        private void KE_FormClosed(object sender, FormClosedEventArgs e)
        {
            KE = null;
        }

        private void btn_Yardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Y==null)
            {
                Y=new Yardım();
                Y.MdiParent = this;
                Y.FormClosed += Y_FormClosed;
                Y.Show();
            }
        }

        private void Y_FormClosed(object sender, FormClosedEventArgs e)
        {
            Y = null;
        }
    }
}
