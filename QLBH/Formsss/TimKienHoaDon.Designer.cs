namespace QLBH.Formsss
{
    partial class TimKienHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKienHoaDon));
            this.hoadon_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.hoadon_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.girdcolumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongtg_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.makh_txt = new DevExpress.XtraEditors.TextEdit();
            this.manv_txt = new DevExpress.XtraEditors.TextEdit();
            this.ngay_txt = new DevExpress.XtraEditors.TextEdit();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongtg_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makh_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadon_gridcontrol
            // 
            this.hoadon_gridcontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoadon_gridcontrol.Location = new System.Drawing.Point(118, 150);
            this.hoadon_gridcontrol.MainView = this.hoadon_gridview;
            this.hoadon_gridcontrol.Name = "hoadon_gridcontrol";
            this.hoadon_gridcontrol.Size = new System.Drawing.Size(606, 300);
            this.hoadon_gridcontrol.TabIndex = 1;
            this.hoadon_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hoadon_gridview});
            // 
            // hoadon_gridview
            // 
            this.hoadon_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.girdcolumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.hoadon_gridview.GridControl = this.hoadon_gridcontrol;
            this.hoadon_gridview.Name = "hoadon_gridview";
            this.hoadon_gridview.OptionsSelection.MultiSelect = true;
            this.hoadon_gridview.DoubleClick += new System.EventHandler(this.hoadon_gridview_DoubleClick);
            // 
            // girdcolumn1
            // 
            this.girdcolumn1.Caption = "Mã HĐ";
            this.girdcolumn1.FieldName = "MAHD";
            this.girdcolumn1.Name = "girdcolumn1";
            this.girdcolumn1.OptionsColumn.AllowEdit = false;
            this.girdcolumn1.Visible = true;
            this.girdcolumn1.VisibleIndex = 0;
            this.girdcolumn1.Width = 97;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "NGAY";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 135;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã KH";
            this.gridColumn3.FieldName = "MAKH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng TG";
            this.gridColumn4.FieldName = "TONGTG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã NV";
            this.gridColumn5.FieldName = "MANV";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 122;
            // 
            // tongtg_txt
            // 
            this.tongtg_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tongtg_txt.Location = new System.Drawing.Point(456, 92);
            this.tongtg_txt.Name = "tongtg_txt";
            this.tongtg_txt.Size = new System.Drawing.Size(111, 20);
            this.tongtg_txt.TabIndex = 3;
            this.tongtg_txt.TextChanged += new System.EventHandler(this.makh_txt_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Location = new System.Drawing.Point(101, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 14);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Mã NV";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(371, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tổng TG";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(371, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Mã KH";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(101, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ngày";
            // 
            // makh_txt
            // 
            this.makh_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.makh_txt.Location = new System.Drawing.Point(456, 47);
            this.makh_txt.Name = "makh_txt";
            this.makh_txt.Size = new System.Drawing.Size(79, 20);
            this.makh_txt.TabIndex = 2;
            this.makh_txt.TextChanged += new System.EventHandler(this.makh_txt_TextChanged);
            // 
            // manv_txt
            // 
            this.manv_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manv_txt.Location = new System.Drawing.Point(162, 49);
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(91, 20);
            this.manv_txt.TabIndex = 0;
            this.manv_txt.TextChanged += new System.EventHandler(this.makh_txt_TextChanged);
            // 
            // ngay_txt
            // 
            this.ngay_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngay_txt.Location = new System.Drawing.Point(162, 86);
            this.ngay_txt.Name = "ngay_txt";
            this.ngay_txt.Size = new System.Drawing.Size(143, 20);
            this.ngay_txt.TabIndex = 1;
            this.ngay_txt.TextChanged += new System.EventHandler(this.makh_txt_TextChanged);
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(627, 51);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(100, 38);
            this.timkiem_btn.TabIndex = 4;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // TimKienHoaDon
            // 
            this.AcceptButton = this.timkiem_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.ngay_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.makh_txt);
            this.Controls.Add(this.tongtg_txt);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.hoadon_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimKienHoaDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKienHoaDon";
            this.Load += new System.EventHandler(this.TimKienHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongtg_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makh_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manv_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl hoadon_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView hoadon_gridview;
        private DevExpress.XtraGrid.Columns.GridColumn girdcolumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit tongtg_txt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit makh_txt;
        private DevExpress.XtraEditors.TextEdit manv_txt;
        private DevExpress.XtraEditors.TextEdit ngay_txt;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
    }
}