namespace QLBH.Formsss
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.manv_txt = new DevExpress.XtraEditors.LookUpEdit();
            this.tongtg_txt = new DevExpress.XtraEditors.TextEdit();
            this.makhachhang_txt = new DevExpress.XtraEditors.LookUpEdit();
            this.Ngay_txt = new DevExpress.XtraEditors.DateEdit();
            this.mahoadon_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.clear = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.hoadon_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.hoadon_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.girdcolumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Xoa_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Sua_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Them_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongtg_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makhachhang_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngay_txt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngay_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoadon_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // manv_txt
            // 
            this.manv_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manv_txt.Location = new System.Drawing.Point(166, 134);
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.manv_txt.Properties.NullText = "";
            this.manv_txt.Size = new System.Drawing.Size(95, 20);
            this.manv_txt.TabIndex = 5;
            this.manv_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // tongtg_txt
            // 
            this.tongtg_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tongtg_txt.Enabled = false;
            this.tongtg_txt.Location = new System.Drawing.Point(166, 262);
            this.tongtg_txt.Name = "tongtg_txt";
            this.tongtg_txt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tongtg_txt.Size = new System.Drawing.Size(143, 20);
            this.tongtg_txt.TabIndex = 4;
            this.tongtg_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            this.tongtg_txt.Validated += new System.EventHandler(this.tongtg_txt_Validated);
            // 
            // makhachhang_txt
            // 
            this.makhachhang_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.makhachhang_txt.Location = new System.Drawing.Point(166, 216);
            this.makhachhang_txt.Name = "makhachhang_txt";
            this.makhachhang_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.makhachhang_txt.Properties.NullText = "";
            this.makhachhang_txt.Size = new System.Drawing.Size(95, 20);
            this.makhachhang_txt.TabIndex = 3;
            this.makhachhang_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Ngay_txt
            // 
            this.Ngay_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ngay_txt.EditValue = null;
            this.Ngay_txt.Location = new System.Drawing.Point(166, 170);
            this.Ngay_txt.Name = "Ngay_txt";
            this.Ngay_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngay_txt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ngay_txt.Size = new System.Drawing.Size(143, 20);
            this.Ngay_txt.TabIndex = 2;
            this.Ngay_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            this.Ngay_txt.Validated += new System.EventHandler(this.Ngay_txt_Validated);
            // 
            // mahoadon_txt
            // 
            this.mahoadon_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mahoadon_txt.Enabled = false;
            this.mahoadon_txt.Location = new System.Drawing.Point(166, 92);
            this.mahoadon_txt.Name = "mahoadon_txt";
            this.mahoadon_txt.Size = new System.Drawing.Size(81, 20);
            this.mahoadon_txt.TabIndex = 1;
            this.mahoadon_txt.TextChanged += new System.EventHandler(this.mahoadon_txt_TextChanged);
            this.mahoadon_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Location = new System.Drawing.Point(81, 136);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Mã NV";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(81, 265);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tổng TG";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(81, 219);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã KH";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(81, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã HD";
            // 
            // panelControl5
            // 
            this.panelControl5.AllowTouchScroll = true;
            this.panelControl5.Controls.Add(this.clear);
            this.panelControl5.Controls.Add(this.manv_txt);
            this.panelControl5.Controls.Add(this.tongtg_txt);
            this.panelControl5.Controls.Add(this.makhachhang_txt);
            this.panelControl5.Controls.Add(this.Ngay_txt);
            this.panelControl5.Controls.Add(this.mahoadon_txt);
            this.panelControl5.Controls.Add(this.labelControl6);
            this.panelControl5.Controls.Add(this.labelControl4);
            this.panelControl5.Controls.Add(this.labelControl3);
            this.panelControl5.Controls.Add(this.labelControl2);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(852, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(416, 410);
            this.panelControl5.TabIndex = 17;
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.Location = new System.Drawing.Point(309, 89);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(81, 177);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ngày";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(294, 18);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(183, 31);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Quản lý hóa đơn";
            // 
            // hoadon_gridcontrol
            // 
            this.hoadon_gridcontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoadon_gridcontrol.Location = new System.Drawing.Point(110, 62);
            this.hoadon_gridcontrol.MainView = this.hoadon_gridview;
            this.hoadon_gridcontrol.Name = "hoadon_gridcontrol";
            this.hoadon_gridcontrol.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.hoadon_gridcontrol.Size = new System.Drawing.Size(606, 300);
            this.hoadon_gridcontrol.TabIndex = 0;
            this.hoadon_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hoadon_gridview});
            this.hoadon_gridcontrol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // hoadon_gridview
            // 
            this.hoadon_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.girdcolumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1});
            this.hoadon_gridview.GridControl = this.hoadon_gridcontrol;
            this.hoadon_gridview.Name = "hoadon_gridview";
            this.hoadon_gridview.OptionsSelection.MultiSelect = true;
            this.hoadon_gridview.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.hoadon_gridview_RowClick);
            // 
            // girdcolumn1
            // 
            this.girdcolumn1.Caption = "Mã HĐ";
            this.girdcolumn1.FieldName = "MAHD";
            this.girdcolumn1.Name = "girdcolumn1";
            this.girdcolumn1.OptionsColumn.AllowEdit = false;
            this.girdcolumn1.Visible = true;
            this.girdcolumn1.VisibleIndex = 1;
            this.girdcolumn1.Width = 90;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "NGAY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã KH";
            this.gridColumn3.FieldName = "MAKH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 99;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng TG";
            this.gridColumn4.FieldName = "TONGTG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 118;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã NV";
            this.gridColumn5.FieldName = "MANV";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 119;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chọn";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "Chon";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 37;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panelControl4
            // 
            this.panelControl4.AllowTouchScroll = true;
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.hoadon_gridcontrol);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.FireScrollEventOnMouseWheel = true;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(852, 410);
            this.panelControl4.TabIndex = 16;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.timkiem_btn);
            this.panelControl2.Controls.Add(this.Xoa_btn);
            this.panelControl2.Controls.Add(this.Sua_btn);
            this.panelControl2.Controls.Add(this.Them_btn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 410);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1268, 107);
            this.panelControl2.TabIndex = 15;
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(791, 43);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(86, 37);
            this.timkiem_btn.TabIndex = 2;
            this.timkiem_btn.Text = "Tìm kiếm\r\n(Ctrl+F)";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            this.timkiem_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Xoa_btn.Image = ((System.Drawing.Image)(resources.GetObject("Xoa_btn.Image")));
            this.Xoa_btn.Location = new System.Drawing.Point(654, 43);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(84, 37);
            this.Xoa_btn.TabIndex = 2;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.Click += new System.EventHandler(this.Xoa_btn_Click);
            this.Xoa_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Sua_btn
            // 
            this.Sua_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sua_btn.Image = ((System.Drawing.Image)(resources.GetObject("Sua_btn.Image")));
            this.Sua_btn.Location = new System.Drawing.Point(512, 43);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(84, 37);
            this.Sua_btn.TabIndex = 1;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            this.Sua_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Them_btn
            // 
            this.Them_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Them_btn.Image = ((System.Drawing.Image)(resources.GetObject("Them_btn.Image")));
            this.Them_btn.Location = new System.Drawing.Point(374, 43);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(84, 37);
            this.Them_btn.TabIndex = 0;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            this.Them_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // HoaDon
            // 
            this.AcceptButton = this.Them_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 517);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongtg_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makhachhang_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngay_txt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ngay_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahoadon_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit manv_txt;
        private DevExpress.XtraEditors.TextEdit tongtg_txt;
        private DevExpress.XtraEditors.LookUpEdit makhachhang_txt;
        private DevExpress.XtraEditors.DateEdit Ngay_txt;
        private DevExpress.XtraEditors.TextEdit mahoadon_txt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
        private DevExpress.XtraEditors.SimpleButton Xoa_btn;
        private DevExpress.XtraEditors.SimpleButton Sua_btn;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Them_btn;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl hoadon_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView hoadon_gridview;
        private DevExpress.XtraGrid.Columns.GridColumn girdcolumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton clear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}