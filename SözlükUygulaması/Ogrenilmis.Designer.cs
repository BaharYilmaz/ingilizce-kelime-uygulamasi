namespace SözlükUygulaması
{
    partial class Ogrenilmis
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBox_Ogrenilmis = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Ogrenilmis)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(158, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(335, 34);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Öğrenilmiş Kelimeler";
            // 
            // listBox_Ogrenilmis
            // 
            this.listBox_Ogrenilmis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Ogrenilmis.Appearance.Options.UseFont = true;
            this.listBox_Ogrenilmis.Location = new System.Drawing.Point(141, 106);
            this.listBox_Ogrenilmis.MultiColumn = true;
            this.listBox_Ogrenilmis.Name = "listBox_Ogrenilmis";
            this.listBox_Ogrenilmis.Size = new System.Drawing.Size(367, 450);
            this.listBox_Ogrenilmis.TabIndex = 4;
            // 
            // Ogrenilmis
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listBox_Ogrenilmis);
            this.Name = "Ogrenilmis";
            this.Size = new System.Drawing.Size(668, 630);
            this.Load += new System.EventHandler(this.Ogrenilmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_Ogrenilmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBox_Ogrenilmis;
    }
}
