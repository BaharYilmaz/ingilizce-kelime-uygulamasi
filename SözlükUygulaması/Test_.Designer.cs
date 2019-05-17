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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_));
            this.btn_testIki = new DevExpress.XtraEditors.CheckButton();
            this.btn_testUc = new DevExpress.XtraEditors.CheckButton();
            this.btn_testBir = new DevExpress.XtraEditors.CheckButton();
            this.btn_testDort = new DevExpress.XtraEditors.CheckButton();
            this.panel_Test = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TestKelime = new System.Windows.Forms.TextBox();
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Test)).BeginInit();
            this.panel_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_testIki
            // 
            this.btn_testIki.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_testIki.Appearance.Options.UseFont = true;
            this.btn_testIki.Location = new System.Drawing.Point(34, 100);
            this.btn_testIki.Name = "btn_testIki";
            this.btn_testIki.Size = new System.Drawing.Size(337, 48);
            this.btn_testIki.TabIndex = 0;
            this.btn_testIki.Text = "---";
            this.btn_testIki.Click += new System.EventHandler(this.btn_testIki_Click);
            // 
            // btn_testUc
            // 
            this.btn_testUc.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_testUc.Appearance.Options.UseFont = true;
            this.btn_testUc.Location = new System.Drawing.Point(34, 174);
            this.btn_testUc.Name = "btn_testUc";
            this.btn_testUc.Size = new System.Drawing.Size(337, 48);
            this.btn_testUc.TabIndex = 0;
            this.btn_testUc.Text = "---";
            this.btn_testUc.Click += new System.EventHandler(this.btn_testUc_Click);
            // 
            // btn_testBir
            // 
            this.btn_testBir.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_testBir.Appearance.Options.UseFont = true;
            this.btn_testBir.Location = new System.Drawing.Point(34, 26);
            this.btn_testBir.Name = "btn_testBir";
            this.btn_testBir.Size = new System.Drawing.Size(337, 48);
            this.btn_testBir.TabIndex = 0;
            this.btn_testBir.Text = "---";
            this.btn_testBir.Click += new System.EventHandler(this.btn_testBir_Click);
            // 
            // btn_testDort
            // 
            this.btn_testDort.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_testDort.Appearance.Options.UseFont = true;
            this.btn_testDort.Location = new System.Drawing.Point(34, 245);
            this.btn_testDort.Name = "btn_testDort";
            this.btn_testDort.Size = new System.Drawing.Size(337, 48);
            this.btn_testDort.TabIndex = 0;
            this.btn_testDort.Text = "---";
            this.btn_testDort.Click += new System.EventHandler(this.btn_testDort_Click);
            // 
            // panel_Test
            // 
            this.panel_Test.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Test.Appearance.Options.UseBackColor = true;
            this.panel_Test.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_Test.Controls.Add(this.btn_testIki);
            this.panel_Test.Controls.Add(this.btn_testUc);
            this.panel_Test.Controls.Add(this.btn_testBir);
            this.panel_Test.Controls.Add(this.btn_testDort);
            this.panel_Test.Location = new System.Drawing.Point(206, 249);
            this.panel_Test.Name = "panel_Test";
            this.panel_Test.Size = new System.Drawing.Size(406, 323);
            this.panel_Test.TabIndex = 10;
            this.panel_Test.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Test_Paint);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(206, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(406, 28);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kelimenin türkçe karşılığını seçiniz";
            // 
            // txt_TestKelime
            // 
            this.txt_TestKelime.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_TestKelime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TestKelime.Location = new System.Drawing.Point(259, 100);
            this.txt_TestKelime.Name = "txt_TestKelime";
            this.txt_TestKelime.Size = new System.Drawing.Size(294, 32);
            this.txt_TestKelime.TabIndex = 12;
            this.txt_TestKelime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_test
            // 
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bilgi.Location = new System.Drawing.Point(256, 46);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 24);
            this.lbl_bilgi.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 586);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Test_
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.txt_TestKelime);
            this.Controls.Add(this.panel_Test);
            this.Controls.Add(this.labelControl2);
            this.Name = "Test_";
            this.Size = new System.Drawing.Size(812, 676);
            this.Load += new System.EventHandler(this.Test__Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Test)).EndInit();
            this.panel_Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton btn_testIki;
        private DevExpress.XtraEditors.CheckButton btn_testUc;
        private DevExpress.XtraEditors.CheckButton btn_testBir;
        private DevExpress.XtraEditors.CheckButton btn_testDort;
        private DevExpress.XtraEditors.PanelControl panel_Test;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_TestKelime;
        private System.Windows.Forms.Timer timer_test;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
