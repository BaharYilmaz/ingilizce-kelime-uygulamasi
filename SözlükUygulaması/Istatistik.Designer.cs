namespace SözlükUygulaması
{
    partial class Istatistik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istatistik));
            this.btn_sifirla = new DevExpress.XtraEditors.SimpleButton();
            this.chart_Istatistik = new DevExpress.XtraCharts.ChartControl();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Istatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_sifirla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifirla.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_sifirla.Appearance.Options.UseBackColor = true;
            this.btn_sifirla.Appearance.Options.UseFont = true;
            this.btn_sifirla.Appearance.Options.UseForeColor = true;
            this.btn_sifirla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_sifirla.Location = new System.Drawing.Point(287, 530);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(247, 35);
            this.btn_sifirla.TabIndex = 1;
            this.btn_sifirla.Text = "Tüm İlerlemeyi Sıfırla";
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // chart_Istatistik
            // 
            xyDiagram2.AxisX.MinorCount = 5;
            xyDiagram2.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram2.AxisX.Title.Text = "";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chart_Istatistik.Diagram = xyDiagram2;
            this.chart_Istatistik.Legend.Name = "Kelime";
            this.chart_Istatistik.Location = new System.Drawing.Point(134, 91);
            this.chart_Istatistik.Name = "chart_Istatistik";
            series2.Name = "Kelime";
            this.chart_Istatistik.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chart_Istatistik.Size = new System.Drawing.Size(540, 287);
            this.chart_Istatistik.TabIndex = 2;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_bilgi.Location = new System.Drawing.Point(397, 399);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 24);
            this.lbl_bilgi.TabIndex = 4;
            this.lbl_bilgi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 586);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Istatistik
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.chart_Istatistik);
            this.Controls.Add(this.btn_sifirla);
            this.Name = "Istatistik";
            this.Size = new System.Drawing.Size(812, 676);
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Istatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_sifirla;
        private DevExpress.XtraCharts.ChartControl chart_Istatistik;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
