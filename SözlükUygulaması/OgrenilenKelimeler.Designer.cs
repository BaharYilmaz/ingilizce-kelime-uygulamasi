namespace SözlükUygulaması
{
    partial class OgrenilenKelimeler
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
            this.listBox_Ogrenilmis = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Ogrenilmis)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Ogrenilmis
            // 
            this.listBox_Ogrenilmis.Location = new System.Drawing.Point(50, 53);
            this.listBox_Ogrenilmis.MultiColumn = true;
            this.listBox_Ogrenilmis.Name = "listBox_Ogrenilmis";
            this.listBox_Ogrenilmis.Size = new System.Drawing.Size(352, 390);
            this.listBox_Ogrenilmis.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(112, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(225, 34);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Öğrenilmiş Kelimeler";
            // 
            // OgrenilenKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SözlükUygulaması.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(439, 486);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listBox_Ogrenilmis);
            this.Name = "OgrenilenKelimeler";
            this.Text = "OgrenilenKelimeler";
            this.Load += new System.EventHandler(this.OgrenilenKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Ogrenilmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBox_Ogrenilmis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}