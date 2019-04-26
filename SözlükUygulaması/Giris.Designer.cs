namespace SözlükUygulaması
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.txt_kullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_giris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_sifre);
            this.panel1.Controls.Add(this.txt_kullanıcıAdı);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btn_giris);
            this.panel1.Location = new System.Drawing.Point(255, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 398);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SözlükUygulaması.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(140, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.EditValue = "Şifre";
            this.txt_sifre.Location = new System.Drawing.Point(79, 214);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_sifre.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("textEdit3.Properties.Appearance.Image")));
            this.txt_sifre.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sifre.Properties.Appearance.Options.UseImage = true;
            this.txt_sifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sifre.Size = new System.Drawing.Size(227, 28);
            this.txt_sifre.TabIndex = 8;
            this.txt_sifre.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // txt_kullanıcıAdı
            // 
            this.txt_kullanıcıAdı.EditValue = "Kullanıcı Adı";
            this.txt_kullanıcıAdı.Location = new System.Drawing.Point(79, 145);
            this.txt_kullanıcıAdı.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_kullanıcıAdı.Name = "txt_kullanıcıAdı";
            this.txt_kullanıcıAdı.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_kullanıcıAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcıAdı.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_kullanıcıAdı.Properties.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("textEdit2.Properties.Appearance.Image")));
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseBackColor = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseImage = true;
            this.txt_kullanıcıAdı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_kullanıcıAdı.Size = new System.Drawing.Size(227, 28);
            this.txt_kullanıcıAdı.TabIndex = 8;
            this.txt_kullanıcıAdı.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-252, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Şifre";
            // 
            // btn_giris
            // 
            this.btn_giris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_giris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_giris.Appearance.Options.UseBackColor = true;
            this.btn_giris.Appearance.Options.UseFont = true;
            this.btn_giris.Appearance.Options.UseForeColor = true;
            this.btn_giris.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_giris.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_giris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_giris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_giris.Location = new System.Drawing.Point(79, 273);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(227, 37);
            this.btn_giris.TabIndex = 1;
            this.btn_giris.Text = "Giriş Yap";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SözlükUygulaması.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(943, 667);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txt_kullanıcıAdı;
        private System.Windows.Forms.TextBox textBox3;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.SimpleButton btn_giris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

