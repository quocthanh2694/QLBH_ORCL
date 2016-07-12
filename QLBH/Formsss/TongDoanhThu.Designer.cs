namespace QLBH.Formsss
{
    partial class TongDoanhThu
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
            this.doanhthu_txt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.thang_txt = new System.Windows.Forms.ComboBox();
            this.thang_lb = new DevExpress.XtraEditors.LabelControl();
            this.nam_lb = new DevExpress.XtraEditors.LabelControl();
            this.nam_txt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // doanhthu_txt
            // 
            this.doanhthu_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doanhthu_txt.Location = new System.Drawing.Point(422, 27);
            this.doanhthu_txt.Name = "doanhthu_txt";
            this.doanhthu_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.doanhthu_txt.Properties.Appearance.Options.UseFont = true;
            this.doanhthu_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.doanhthu_txt.Properties.Items.AddRange(new object[] {
            "Năm",
            "Tháng",
            "Ngày"});
            this.doanhthu_txt.Size = new System.Drawing.Size(131, 22);
            this.doanhthu_txt.TabIndex = 0;
            this.doanhthu_txt.EditValueChanged += new System.EventHandler(this.doanhthu_txt_EditValueChanged);
            this.doanhthu_txt.TextChanged += new System.EventHandler(this.doanhthu_txt_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(230, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thống kê doanh thu theo :";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.Location = new System.Drawing.Point(115, 85);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(996, 333);
            this.chartControl1.TabIndex = 2;
            // 
            // thang_txt
            // 
            this.thang_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.thang_txt.FormattingEnabled = true;
            this.thang_txt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang_txt.Location = new System.Drawing.Point(879, 26);
            this.thang_txt.Name = "thang_txt";
            this.thang_txt.Size = new System.Drawing.Size(83, 21);
            this.thang_txt.TabIndex = 5;
            this.thang_txt.Visible = false;
            this.thang_txt.TextChanged += new System.EventHandler(this.thang_txt_TextChanged_1);
            this.thang_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thang_txt_KeyPress);
            // 
            // thang_lb
            // 
            this.thang_lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thang_lb.Location = new System.Drawing.Point(783, 28);
            this.thang_lb.Name = "thang_lb";
            this.thang_lb.Size = new System.Drawing.Size(81, 17);
            this.thang_lb.TabIndex = 1;
            this.thang_lb.Text = "Nhập tháng :";
            this.thang_lb.Visible = false;
            // 
            // nam_lb
            // 
            this.nam_lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nam_lb.Location = new System.Drawing.Point(583, 30);
            this.nam_lb.Name = "nam_lb";
            this.nam_lb.Size = new System.Drawing.Size(72, 17);
            this.nam_lb.TabIndex = 1;
            this.nam_lb.Text = "Nhập năm :";
            this.nam_lb.Visible = false;
            // 
            // nam_txt
            // 
            this.nam_txt.FormattingEnabled = true;
            this.nam_txt.Location = new System.Drawing.Point(672, 28);
            this.nam_txt.Name = "nam_txt";
            this.nam_txt.Size = new System.Drawing.Size(64, 21);
            this.nam_txt.TabIndex = 6;
            this.nam_txt.Visible = false;
            this.nam_txt.TextChanged += new System.EventHandler(this.nam_txt_TextChanged_1);
            // 
            // TongDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 478);
            this.Controls.Add(this.nam_txt);
            this.Controls.Add(this.thang_txt);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.nam_lb);
            this.Controls.Add(this.thang_lb);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.doanhthu_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongDoanhThu";
            this.Text = "TongDoanhThu";
            this.Load += new System.EventHandler(this.TongDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit doanhthu_txt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ComboBox thang_txt;
        private DevExpress.XtraEditors.LabelControl thang_lb;
        private DevExpress.XtraEditors.LabelControl nam_lb;
        private System.Windows.Forms.ComboBox nam_txt;
    }
}