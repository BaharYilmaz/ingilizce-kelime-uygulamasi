namespace SözlükUygulaması
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ace_profil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_giris = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_cikis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_kelimeSec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_ogren = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_test = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_ogrenilen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_kelimeEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_yardim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // _container
            // 
            this._container.Dock = System.Windows.Forms.DockStyle.Fill;
            this._container.Location = new System.Drawing.Point(0, 30);
            this._container.Name = "_container";
            this._container.Size = new System.Drawing.Size(936, 683);
            this._container.TabIndex = 3;
            this._container.Click += new System.EventHandler(this._container_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_profil,
            this.accordionControlElement2,
            this.ace_yardim});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.Size = new System.Drawing.Size(200, 683);
            this.accordionControl1.TabIndex = 4;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ace_profil
            // 
            this.ace_profil.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_giris,
            this.ace_cikis});
            this.ace_profil.Expanded = true;
            this.ace_profil.Name = "ace_profil";
            this.ace_profil.Text = "PROFİL";
            // 
            // ace_giris
            // 
            this.ace_giris.Name = "ace_giris";
            this.ace_giris.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_giris.Text = "Giriş Yap";
            this.ace_giris.Click += new System.EventHandler(this.ace_giris_Click);
            // 
            // ace_cikis
            // 
            this.ace_cikis.Name = "ace_cikis";
            this.ace_cikis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_cikis.Text = "Çıkış Yap";
            this.ace_cikis.Click += new System.EventHandler(this.ace_cikis_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_kelimeSec,
            this.ace_ogren,
            this.ace_test,
            this.ace_ogrenilen,
            this.ace_kelimeEkle});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "ANA MENU";
            // 
            // ace_kelimeSec
            // 
            this.ace_kelimeSec.Name = "ace_kelimeSec";
            this.ace_kelimeSec.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_kelimeSec.Text = "Kelime Sec";
            this.ace_kelimeSec.Click += new System.EventHandler(this.ace_kelimeSec_Click);
            // 
            // ace_ogren
            // 
            this.ace_ogren.Name = "ace_ogren";
            this.ace_ogren.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_ogren.Text = "Ogren";
            this.ace_ogren.Click += new System.EventHandler(this.ace_ogren_Click);
            // 
            // ace_test
            // 
            this.ace_test.Name = "ace_test";
            this.ace_test.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_test.Text = "Test";
            this.ace_test.Click += new System.EventHandler(this.ace_test_Click);
            // 
            // ace_ogrenilen
            // 
            this.ace_ogrenilen.Name = "ace_ogrenilen";
            this.ace_ogrenilen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_ogrenilen.Text = "Ogrenilmis Kelimeler";
            this.ace_ogrenilen.Click += new System.EventHandler(this.ace_ogrenilen_Click);
            // 
            // ace_kelimeEkle
            // 
            this.ace_kelimeEkle.Name = "ace_kelimeEkle";
            this.ace_kelimeEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_kelimeEkle.Text = "Kelime Ekle";
            this.ace_kelimeEkle.Click += new System.EventHandler(this.ace_kelimeEkle_Click);
            // 
            // ace_yardim
            // 
            this.ace_yardim.Name = "ace_yardim";
            this.ace_yardim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_yardim.Text = "YARDIM";
            this.ace_yardim.Click += new System.EventHandler(this.ace_yardim_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(936, 30);
            this.fluentDesignFormControl1.TabIndex = 5;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 713);
            this.ControlContainer = this._container;
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this._container);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Home";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer _container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_profil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_giris;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_cikis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_kelimeSec;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_ogren;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_test;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_ogrenilen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_kelimeEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_yardim;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
    }
}