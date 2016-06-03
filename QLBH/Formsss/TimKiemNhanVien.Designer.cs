namespace QLBH.Formsss
{
    partial class TimKiemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemNhanVien));
            this.nhanvien_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.nhanvien_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.girdcolumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            this.manv_txt = new DevExpress.XtraEditors.TextEdit();
            this.tennv_txt = new DevExpress.XtraEditors.TextEdit();
            this.diachi_txt = new DevExpress.XtraEditors.TextEdit();
            this.dienthoai_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chucvu_txt = new DevExpress.XtraEditors.TextEdit();
            this.Luong_txt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennv_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachi_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienthoai_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvu_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luong_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvien_gridcontrol
            // 
            this.nhanvien_gridcontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nhanvien_gridcontrol.Location = new System.Drawing.Point(73, 147);
            this.nhanvien_gridcontrol.MainView = this.nhanvien_gridview;
            this.nhanvien_gridcontrol.Name = "nhanvien_gridcontrol";
            this.nhanvien_gridcontrol.Size = new System.Drawing.Size(717, 300);
            this.nhanvien_gridcontrol.TabIndex = 5;
            this.nhanvien_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nhanvien_gridview});
            // 
            // nhanvien_gridview
            // 
            this.nhanvien_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.girdcolumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5});
            this.nhanvien_gridview.GridControl = this.nhanvien_gridcontrol;
            this.nhanvien_gridview.Name = "nhanvien_gridview";
            this.nhanvien_gridview.OptionsSelection.MultiSelect = true;
            this.nhanvien_gridview.DoubleClick += new System.EventHandler(this.nhanvien_gridview_DoubleClick);
            // 
            // girdcolumn1
            // 
            this.girdcolumn1.Caption = "Mã NV";
            this.girdcolumn1.FieldName = "MANV";
            this.girdcolumn1.Name = "girdcolumn1";
            this.girdcolumn1.OptionsColumn.AllowEdit = false;
            this.girdcolumn1.Visible = true;
            this.girdcolumn1.VisibleIndex = 0;
            this.girdcolumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
            this.gridColumn2.FieldName = "TENNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 167;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DIACHI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 146;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điện thoại";
            this.gridColumn4.FieldName = "DT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 109;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chức vụ";
            this.gridColumn1.FieldName = "CHUCVU";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 103;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Lương";
            this.gridColumn5.FieldName = "LUONG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 108;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên nhân viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(316, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(316, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Điện thoại";
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(727, 61);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(100, 38);
            this.timkiem_btn.TabIndex = 6;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // manv_txt
            // 
            this.manv_txt.Location = new System.Drawing.Point(163, 38);
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(68, 20);
            this.manv_txt.TabIndex = 0;
            this.manv_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // tennv_txt
            // 
            this.tennv_txt.Location = new System.Drawing.Point(163, 79);
            this.tennv_txt.Name = "tennv_txt";
            this.tennv_txt.Size = new System.Drawing.Size(124, 20);
            this.tennv_txt.TabIndex = 1;
            this.tennv_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // diachi_txt
            // 
            this.diachi_txt.Location = new System.Drawing.Point(391, 38);
            this.diachi_txt.Name = "diachi_txt";
            this.diachi_txt.Size = new System.Drawing.Size(100, 20);
            this.diachi_txt.TabIndex = 2;
            this.diachi_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // dienthoai_txt
            // 
            this.dienthoai_txt.Location = new System.Drawing.Point(391, 79);
            this.dienthoai_txt.Name = "dienthoai_txt";
            this.dienthoai_txt.Size = new System.Drawing.Size(100, 20);
            this.dienthoai_txt.TabIndex = 3;
            this.dienthoai_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            this.dienthoai_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dienthoai_txt_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(528, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Chức vụ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(528, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Lương";
            // 
            // chucvu_txt
            // 
            this.chucvu_txt.Location = new System.Drawing.Point(603, 38);
            this.chucvu_txt.Name = "chucvu_txt";
            this.chucvu_txt.Size = new System.Drawing.Size(100, 20);
            this.chucvu_txt.TabIndex = 4;
            this.chucvu_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // Luong_txt
            // 
            this.Luong_txt.Location = new System.Drawing.Point(603, 79);
            this.Luong_txt.Name = "Luong_txt";
            this.Luong_txt.Size = new System.Drawing.Size(100, 20);
            this.Luong_txt.TabIndex = 5;
            this.Luong_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            this.Luong_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dienthoai_txt_KeyPress);
            // 
            // TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(866, 488);
            this.Controls.Add(this.Luong_txt);
            this.Controls.Add(this.chucvu_txt);
            this.Controls.Add(this.dienthoai_txt);
            this.Controls.Add(this.diachi_txt);
            this.Controls.Add(this.tennv_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nhanvien_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimKiemNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiemNhanVien";
            this.Load += new System.EventHandler(this.TimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennv_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachi_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienthoai_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvu_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luong_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl nhanvien_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView nhanvien_gridview;
        private DevExpress.XtraGrid.Columns.GridColumn girdcolumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
        private DevExpress.XtraEditors.TextEdit manv_txt;
        private DevExpress.XtraEditors.TextEdit tennv_txt;
        private DevExpress.XtraEditors.TextEdit diachi_txt;
        private DevExpress.XtraEditors.TextEdit dienthoai_txt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit chucvu_txt;
        private DevExpress.XtraEditors.TextEdit Luong_txt;
    }
}