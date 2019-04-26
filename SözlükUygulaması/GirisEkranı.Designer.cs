namespace SözlükUygulaması
{
    partial class GirisEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkranı));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_girisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.txt_kullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_girisYap);
            this.panelControl1.Controls.Add(this.txt_sifre);
            this.panelControl1.Controls.Add(this.txt_kullanıcıAdı);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Location = new System.Drawing.Point(121, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(383, 380);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_girisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.Appearance.Options.UseBackColor = true;
            this.btn_girisYap.Appearance.Options.UseFont = true;
            this.btn_girisYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_girisYap.ImageOptions.SvgImage")));
            this.btn_girisYap.Location = new System.Drawing.Point(99, 287);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(195, 31);
            this.btn_girisYap.TabIndex = 2;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.EditValue = "Şifre";
            this.txt_sifre.Location = new System.Drawing.Point(99, 227);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_sifre.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sifre.Size = new System.Drawing.Size(195, 28);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.Click += new System.EventHandler(this.txt_sifre_Click);
            // 
            // txt_kullanıcıAdı
            // 
            this.txt_kullanıcıAdı.EditValue = "Kullanıcı Adı";
            this.txt_kullanıcıAdı.Location = new System.Drawing.Point(99, 169);
            this.txt_kullanıcıAdı.Name = "txt_kullanıcıAdı";
            this.txt_kullanıcıAdı.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_kullanıcıAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcıAdı.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseBackColor = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kullanıcıAdı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_kullanıcıAdı.Size = new System.Drawing.Size(195, 28);
            this.txt_kullanıcıAdı.TabIndex = 1;
            this.txt_kullanıcıAdı.Click += new System.EventHandler(this.txt_kullanıcıAdı_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SözlükUygulaması.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(146, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SözlükUygulaması.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(641, 548);
            this.Controls.Add(this.panelControl1);
            this.Name = "GirisEkranı";
            this.Text = "GirisEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_girisYap;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.TextEdit txt_kullanıcıAdı;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}