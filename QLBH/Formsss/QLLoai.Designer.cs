namespace QLBH.Formsss
{
    partial class QLLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLoai));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Xoa_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Sua_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Them_btn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.vattu_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.vattu_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtmaloai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattu_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattu_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaloai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 513);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1268, 4);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.AutoSize = true;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(1264, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(4, 513);
            this.panelControl3.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Xoa_btn);
            this.panelControl2.Controls.Add(this.Sua_btn);
            this.panelControl2.Controls.Add(this.Them_btn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 406);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1264, 107);
            this.panelControl2.TabIndex = 7;
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Xoa_btn.Image = ((System.Drawing.Image)(resources.GetObject("Xoa_btn.Image")));
            this.Xoa_btn.Location = new System.Drawing.Point(652, 43);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(84, 37);
            this.Xoa_btn.TabIndex = 2;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            this.Xoa_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Sua_btn
            // 
            this.Sua_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Sua_btn.Image = ((System.Drawing.Image)(resources.GetObject("Sua_btn.Image")));
            this.Sua_btn.Location = new System.Drawing.Point(510, 43);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(84, 37);
            this.Sua_btn.TabIndex = 1;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            this.Sua_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // Them_btn
            // 
            this.Them_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Them_btn.Image = ((System.Drawing.Image)(resources.GetObject("Them_btn.Image")));
            this.Them_btn.Location = new System.Drawing.Point(372, 43);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(84, 37);
            this.Them_btn.TabIndex = 0;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            this.Them_btn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // panelControl4
            // 
            this.panelControl4.AllowTouchScroll = true;
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.vattu_gridcontrol);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.FireScrollEventOnMouseWheel = true;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(831, 406);
            this.panelControl4.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(285, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(245, 31);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Quản lý loại sản phẩm";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // vattu_gridcontrol
            // 
            this.vattu_gridcontrol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vattu_gridcontrol.Location = new System.Drawing.Point(101, 64);
            this.vattu_gridcontrol.MainView = this.vattu_gridview;
            this.vattu_gridcontrol.Name = "vattu_gridcontrol";
            this.vattu_gridcontrol.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.vattu_gridcontrol.Size = new System.Drawing.Size(606, 300);
            this.vattu_gridcontrol.TabIndex = 0;
            this.vattu_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vattu_gridview});
            this.vattu_gridcontrol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // vattu_gridview
            // 
            this.vattu_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colCheck});
            this.vattu_gridview.GridControl = this.vattu_gridcontrol;
            this.vattu_gridview.Name = "vattu_gridview";
            this.vattu_gridview.OptionsFind.AlwaysVisible = true;
            this.vattu_gridview.OptionsSelection.MultiSelect = true;
            this.vattu_gridview.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.VatTu_gridview_RowCellClick);
            this.vattu_gridview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vattu_gridview_KeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã loại";
            this.gridColumn1.FieldName = "MALOAI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên loại";
            this.gridColumn2.FieldName = "TENLOAI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 110;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "Chọn";
            this.colCheck.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colCheck.FieldName = "Chon";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 37;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.FullFocusRect = true;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // panel
            // 
            this.panel.AllowTouchScroll = true;
            this.panel.Controls.Add(this.simpleButton1);
            this.panel.Controls.Add(this.txtTenLoai);
            this.panel.Controls.Add(this.txtmaloai);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(831, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(433, 406);
            this.panel.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Location = new System.Drawing.Point(333, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Clear";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            this.simpleButton1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLoai.Location = new System.Drawing.Point(189, 175);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(166, 20);
            this.txtTenLoai.TabIndex = 1;
            this.txtTenLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.slton_txt_KeyDown);
            this.txtTenLoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmaloai.Enabled = false;
            this.txtmaloai.Location = new System.Drawing.Point(189, 129);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(95, 20);
            this.txtmaloai.TabIndex = 0;
            this.txtmaloai.TextChanged += new System.EventHandler(this.mavt_txt_TextChanged);
            this.txtmaloai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.slton_txt_KeyDown);
            this.txtmaloai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.timkiem_btn_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(36, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Mã loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(36, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 18);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên loại";
            // 
            // QLLoai
            // 
            this.AcceptButton = this.Them_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 517);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLLoai";
            this.Text = "Quản_lý_sản_phẩm";
            this.Load += new System.EventHandler(this.QuanLySanPhamFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattu_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattu_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaloai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Xoa_btn;
        private DevExpress.XtraEditors.SimpleButton Sua_btn;
        private DevExpress.XtraEditors.SimpleButton Them_btn;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.TextEdit txtmaloai;
        private DevExpress.XtraGrid.GridControl vattu_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView vattu_gridview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}