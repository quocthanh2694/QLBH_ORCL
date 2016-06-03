namespace QLBH.Formsss
{
    partial class KhachHangVip
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.khachhangvip_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.khachhangvip_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangvip_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangvip_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(519, 28);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(294, 31);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Danh sách khách hàng VIP";
            // 
            // khachhangvip_gridcontrol
            // 
            this.khachhangvip_gridcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachhangvip_gridcontrol.Location = new System.Drawing.Point(129, 86);
            this.khachhangvip_gridcontrol.MainView = this.khachhangvip_gridview;
            this.khachhangvip_gridcontrol.Name = "khachhangvip_gridcontrol";
            this.khachhangvip_gridcontrol.Size = new System.Drawing.Size(1010, 399);
            this.khachhangvip_gridcontrol.TabIndex = 4;
            this.khachhangvip_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.khachhangvip_gridview});
            // 
            // khachhangvip_gridview
            // 
            this.khachhangvip_gridview.GridControl = this.khachhangvip_gridcontrol;
            this.khachhangvip_gridview.Name = "khachhangvip_gridview";
            this.khachhangvip_gridview.OptionsBehavior.Editable = false;
            this.khachhangvip_gridview.OptionsBehavior.ReadOnly = true;
            // 
            // KhachHangVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 517);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.khachhangvip_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHangVip";
            this.Text = "KhachHangVip";
            this.Load += new System.EventHandler(this.KhachHangVip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangvip_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangvip_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl khachhangvip_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView khachhangvip_gridview;
    }
}