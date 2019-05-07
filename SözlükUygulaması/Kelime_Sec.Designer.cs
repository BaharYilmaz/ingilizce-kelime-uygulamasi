namespace SözlükUygulaması
{
    partial class Kelime_Sec
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
            this.btn_secOgren = new DevExpress.XtraEditors.SimpleButton();
            this.btn_secBiliyorum = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_sec = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_sec)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_secOgren
            // 
            this.btn_secOgren.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_secOgren.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secOgren.Appearance.Options.UseBackColor = true;
            this.btn_secOgren.Appearance.Options.UseFont = true;
            this.btn_secOgren.Location = new System.Drawing.Point(586, 313);
            this.btn_secOgren.Name = "btn_secOgren";
            this.btn_secOgren.Size = new System.Drawing.Size(94, 64);
            this.btn_secOgren.TabIndex = 7;
            this.btn_secOgren.Text = "Öğren";
            this.btn_secOgren.Click += new System.EventHandler(this.btn_secOgren_Click);
            // 
            // btn_secBiliyorum
            // 
            this.btn_secBiliyorum.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_secBiliyorum.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secBiliyorum.Appearance.Options.UseBackColor = true;
            this.btn_secBiliyorum.Appearance.Options.UseFont = true;
            this.btn_secBiliyorum.Location = new System.Drawing.Point(586, 212);
            this.btn_secBiliyorum.Name = "btn_secBiliyorum";
            this.btn_secBiliyorum.Size = new System.Drawing.Size(94, 64);
            this.btn_secBiliyorum.TabIndex = 6;
            this.btn_secBiliyorum.Text = "Biliyorum";
            this.btn_secBiliyorum.Click += new System.EventHandler(this.btn_secBiliyorum_Click);
            // 
            // listBox_sec
            // 
            this.listBox_sec.Appearance.BackColor = System.Drawing.Color.White;
            this.listBox_sec.Appearance.Options.UseBackColor = true;
            this.listBox_sec.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.listBox_sec.Location = new System.Drawing.Point(282, 117);
            this.listBox_sec.Name = "listBox_sec";
            this.listBox_sec.Size = new System.Drawing.Size(259, 385);
            this.listBox_sec.TabIndex = 5;
            this.listBox_sec.SelectedIndexChanged += new System.EventHandler(this.listBox_sec_SelectedIndexChanged);
            this.listBox_sec.Click += new System.EventHandler(this.listBox_sec_Click);
            // 
            // Kelime_Sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_secOgren);
            this.Controls.Add(this.btn_secBiliyorum);
            this.Controls.Add(this.listBox_sec);
            this.Name = "Kelime_Sec";
            this.Size = new System.Drawing.Size(815, 619);
            this.Load += new System.EventHandler(this.Kelime_Sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_sec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_secOgren;
        private DevExpress.XtraEditors.SimpleButton btn_secBiliyorum;
        private DevExpress.XtraEditors.ListBoxControl listBox_sec;
    }
}
