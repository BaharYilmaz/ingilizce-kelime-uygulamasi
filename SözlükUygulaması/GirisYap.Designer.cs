namespace SözlükUygulaması
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_girisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.txt_kullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_girisYap);
            this.panel1.Controls.Add(this.txt_sifre);
            this.panel1.Controls.Add(this.txt_kullanıcıAdı);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(122, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 406);
            this.panel1.TabIndex = 4;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_girisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.Appearance.Options.UseBackColor = true;
            this.btn_girisYap.Appearance.Options.UseFont = true;
            this.btn_girisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_girisYap.ImageOptions.Image")));
            this.btn_girisYap.Location = new System.Drawing.Point(104, 331);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(195, 43);
            this.btn_girisYap.TabIndex = 7;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.EditValue = "Şifre";
            this.txt_sifre.Location = new System.Drawing.Point(104, 271);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_sifre.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sifre.Size = new System.Drawing.Size(195, 28);
            this.txt_sifre.TabIndex = 6;
            this.txt_sifre.Click += new System.EventHandler(this.txt_sifre_Click);
            // 
            // txt_kullanıcıAdı
            // 
            this.txt_kullanıcıAdı.EditValue = "Kullanıcı Adı";
            this.txt_kullanıcıAdı.EnterMoveNextControl = true;
            this.txt_kullanıcıAdı.Location = new System.Drawing.Point(104, 213);
            this.txt_kullanıcıAdı.Name = "txt_kullanıcıAdı";
            this.txt_kullanıcıAdı.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_kullanıcıAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanıcıAdı.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseBackColor = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanıcıAdı.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kullanıcıAdı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_kullanıcıAdı.Size = new System.Drawing.Size(195, 28);
            this.txt_kullanıcıAdı.TabIndex = 5;
            this.txt_kullanıcıAdı.Click += new System.EventHandler(this.txt_kullanıcıAdı_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GirisYap
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 488);
            this.Controls.Add(this.panel1);
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_girisYap;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.TextEdit txt_kullanıcıAdı;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}