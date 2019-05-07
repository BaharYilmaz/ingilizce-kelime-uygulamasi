namespace SözlükUygulaması
{
    partial class Test_
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
            this.btn_testIki = new DevExpress.XtraEditors.CheckButton();
            this.btn_testUc = new DevExpress.XtraEditors.CheckButton();
            this.btn_testBir = new DevExpress.XtraEditors.CheckButton();
            this.btn_testDort = new DevExpress.XtraEditors.CheckButton();
            this.txt_TestKelime = new DevExpress.XtraEditors.TextEdit();
            this.panel_Test = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TestKelime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Test)).BeginInit();
            this.panel_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_testIki
            // 
            this.btn_testIki.Location = new System.Drawing.Point(68, 86);
            this.btn_testIki.Name = "btn_testIki";
            this.btn_testIki.Size = new System.Drawing.Size(168, 29);
            this.btn_testIki.TabIndex = 0;
            this.btn_testIki.Text = "---";
            this.btn_testIki.Click += new System.EventHandler(this.btn_testIki_Click);
            // 
            // btn_testUc
            // 
            this.btn_testUc.Location = new System.Drawing.Point(68, 130);
            this.btn_testUc.Name = "btn_testUc";
            this.btn_testUc.Size = new System.Drawing.Size(168, 29);
            this.btn_testUc.TabIndex = 0;
            this.btn_testUc.Text = "---";
            this.btn_testUc.Click += new System.EventHandler(this.btn_testUc_Click);
            // 
            // btn_testBir
            // 
            this.btn_testBir.Location = new System.Drawing.Point(68, 41);
            this.btn_testBir.Name = "btn_testBir";
            this.btn_testBir.Size = new System.Drawing.Size(168, 29);
            this.btn_testBir.TabIndex = 0;
            this.btn_testBir.Text = "---";
            this.btn_testBir.Click += new System.EventHandler(this.btn_testBir_Click);
            // 
            // btn_testDort
            // 
            this.btn_testDort.Location = new System.Drawing.Point(68, 174);
            this.btn_testDort.Name = "btn_testDort";
            this.btn_testDort.Size = new System.Drawing.Size(168, 29);
            this.btn_testDort.TabIndex = 0;
            this.btn_testDort.Text = "---";
            this.btn_testDort.Click += new System.EventHandler(this.btn_testDort_Click);
            // 
            // txt_TestKelime
            // 
            this.txt_TestKelime.Location = new System.Drawing.Point(239, 130);
            this.txt_TestKelime.Name = "txt_TestKelime";
            this.txt_TestKelime.Size = new System.Drawing.Size(125, 22);
            this.txt_TestKelime.TabIndex = 11;
            // 
            // panel_Test
            // 
            this.panel_Test.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Test.Appearance.Options.UseBackColor = true;
            this.panel_Test.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_Test.Controls.Add(this.btn_testIki);
            this.panel_Test.Controls.Add(this.btn_testUc);
            this.panel_Test.Controls.Add(this.btn_testBir);
            this.panel_Test.Controls.Add(this.btn_testDort);
            this.panel_Test.Location = new System.Drawing.Point(158, 234);
            this.panel_Test.Name = "panel_Test";
            this.panel_Test.Size = new System.Drawing.Size(294, 247);
            this.panel_Test.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(208, 195);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(193, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kelimenin türkçe karşılığını seçiniz";
            // 
            // Test_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_TestKelime);
            this.Controls.Add(this.panel_Test);
            this.Controls.Add(this.labelControl2);
            this.Name = "Test_";
            this.Size = new System.Drawing.Size(610, 610);
            this.Load += new System.EventHandler(this.Test__Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TestKelime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Test)).EndInit();
            this.panel_Test.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton btn_testIki;
        private DevExpress.XtraEditors.CheckButton btn_testUc;
        private DevExpress.XtraEditors.CheckButton btn_testBir;
        private DevExpress.XtraEditors.CheckButton btn_testDort;
        private DevExpress.XtraEditors.TextEdit txt_TestKelime;
        private DevExpress.XtraEditors.PanelControl panel_Test;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
