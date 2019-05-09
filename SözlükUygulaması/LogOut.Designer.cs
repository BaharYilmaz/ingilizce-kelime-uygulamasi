namespace SözlükUygulaması
{
    partial class LogOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cikisYap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_cikisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikisYap.Appearance.Options.UseBackColor = true;
            this.btn_cikisYap.Appearance.Options.UseFont = true;
            this.btn_cikisYap.Location = new System.Drawing.Point(245, 249);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(195, 31);
            this.btn_cikisYap.TabIndex = 5;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.EditValue = "Şifre";
            this.txt_sifre.Location = new System.Drawing.Point(245, 189);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txt_sifre.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_sifre.Size = new System.Drawing.Size(195, 28);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.Click += new System.EventHandler(this.txt_sifre_Click);
            // 
            // LogOut
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.txt_sifre);
            this.Name = "LogOut";
            this.Size = new System.Drawing.Size(517, 393);
            this.Load += new System.EventHandler(this.LogOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_cikisYap;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
    }
}
