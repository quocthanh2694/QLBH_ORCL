namespace QLBH.Formsss
{
    partial class LuongNhanVien
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.luongnhanvien_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.luongnhanvien_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.thang_txt = new System.Windows.Forms.ComboBox();
            this.nam_lb = new DevExpress.XtraEditors.LabelControl();
            this.thang_lb = new DevExpress.XtraEditors.LabelControl();
            this.nam_txt = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.luongnhanvien_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongnhanvien_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nam_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(27, -98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(294, 31);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Danh sách khách hàng VIP";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl1.Location = new System.Drawing.Point(357, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(518, 31);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Số lượng hóa đơn bán được và lương nhân viên";
            // 
            // luongnhanvien_gridcontrol
            // 
            this.luongnhanvien_gridcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luongnhanvien_gridcontrol.Location = new System.Drawing.Point(156, 118);
            this.luongnhanvien_gridcontrol.MainView = this.luongnhanvien_gridview;
            this.luongnhanvien_gridcontrol.Name = "luongnhanvien_gridcontrol";
            this.luongnhanvien_gridcontrol.Size = new System.Drawing.Size(976, 346);
            this.luongnhanvien_gridcontrol.TabIndex = 8;
            this.luongnhanvien_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.luongnhanvien_gridview});
            // 
            // luongnhanvien_gridview
            // 
            this.luongnhanvien_gridview.GridControl = this.luongnhanvien_gridcontrol;
            this.luongnhanvien_gridview.Name = "luongnhanvien_gridview";
            this.luongnhanvien_gridview.OptionsBehavior.Editable = false;
            this.luongnhanvien_gridview.OptionsBehavior.ReadOnly = true;
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
            this.thang_txt.Location = new System.Drawing.Point(717, 73);
            this.thang_txt.Name = "thang_txt";
            this.thang_txt.Size = new System.Drawing.Size(83, 21);
            this.thang_txt.TabIndex = 15;
            this.thang_txt.TextChanged += new System.EventHandler(this.thang_txt_TextChanged);
            this.thang_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thang_txt_KeyPress);
            // 
            // nam_lb
            // 
            this.nam_lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nam_lb.Location = new System.Drawing.Point(421, 77);
            this.nam_lb.Name = "nam_lb";
            this.nam_lb.Size = new System.Drawing.Size(72, 17);
            this.nam_lb.TabIndex = 12;
            this.nam_lb.Text = "Nhập năm :";
            // 
            // thang_lb
            // 
            this.thang_lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thang_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.thang_lb.Location = new System.Drawing.Point(621, 75);
            this.thang_lb.Name = "thang_lb";
            this.thang_lb.Size = new System.Drawing.Size(81, 17);
            this.thang_lb.TabIndex = 13;
            this.thang_lb.Text = "Nhập tháng :";
            // 
            // nam_txt
            // 
            this.nam_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nam_txt.Location = new System.Drawing.Point(514, 74);
            this.nam_txt.Name = "nam_txt";
            this.nam_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nam_txt.Properties.NullText = "";
            this.nam_txt.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.nam_txt.Size = new System.Drawing.Size(83, 20);
            this.nam_txt.TabIndex = 14;
            this.nam_txt.TextChanged += new System.EventHandler(this.nam_txt_TextChanged);
            this.nam_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nam_txt_KeyPress);
            // 
            // LuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 517);
            this.Controls.Add(this.thang_txt);
            this.Controls.Add(this.nam_lb);
            this.Controls.Add(this.thang_lb);
            this.Controls.Add(this.nam_txt);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.luongnhanvien_gridcontrol);
            this.Controls.Add(this.labelControl7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LuongNhanVien";
            this.Text = "LuongNhanVien";
            this.Load += new System.EventHandler(this.LuongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luongnhanvien_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongnhanvien_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nam_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl luongnhanvien_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView luongnhanvien_gridview;
        private System.Windows.Forms.ComboBox thang_txt;
        private DevExpress.XtraEditors.LabelControl nam_lb;
        private DevExpress.XtraEditors.LabelControl thang_lb;
        private DevExpress.XtraEditors.LookUpEdit nam_txt;
    }
}