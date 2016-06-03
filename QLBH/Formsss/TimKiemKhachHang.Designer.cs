namespace QLBH.Formsss
{
    partial class TimKiemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemKhachHang));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diachi_txt = new DevExpress.XtraEditors.TextEdit();
            this.dienthoai_txt = new DevExpress.XtraEditors.TextEdit();
            this.mail_txt = new DevExpress.XtraEditors.TextEdit();
            this.ngaysinh_txt = new DevExpress.XtraEditors.TextEdit();
            this.tenkh_txt = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachi_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienthoai_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkh_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Location = new System.Drawing.Point(74, 73);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 18);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(74, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 18);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Tên Khách Hàng";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(440, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 18);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Mail";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(74, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 18);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(439, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 18);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Điện thoại";
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(721, 56);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(100, 38);
            this.timkiem_btn.TabIndex = 5;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(74, 176);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 337);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã KH";
            this.gridColumn1.FieldName = "MAKH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.FieldName = "TENKH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày sinh";
            this.gridColumn5.FieldName = "NGAYSINH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DIACHI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điện thoại";
            this.gridColumn4.FieldName = "DT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mail";
            this.gridColumn6.FieldName = "MAIL";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // diachi_txt
            // 
            this.diachi_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.diachi_txt.Location = new System.Drawing.Point(199, 111);
            this.diachi_txt.Name = "diachi_txt";
            this.diachi_txt.Size = new System.Drawing.Size(129, 20);
            this.diachi_txt.TabIndex = 2;
            this.diachi_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // dienthoai_txt
            // 
            this.dienthoai_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dienthoai_txt.Location = new System.Drawing.Point(538, 31);
            this.dienthoai_txt.Name = "dienthoai_txt";
            this.dienthoai_txt.Size = new System.Drawing.Size(129, 20);
            this.dienthoai_txt.TabIndex = 3;
            this.dienthoai_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            this.dienthoai_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diachi_txt_KeyPress);
            // 
            // mail_txt
            // 
            this.mail_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mail_txt.Location = new System.Drawing.Point(538, 70);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(129, 20);
            this.mail_txt.TabIndex = 4;
            this.mail_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // ngaysinh_txt
            // 
            this.ngaysinh_txt.Location = new System.Drawing.Point(200, 71);
            this.ngaysinh_txt.Name = "ngaysinh_txt";
            this.ngaysinh_txt.Size = new System.Drawing.Size(128, 20);
            this.ngaysinh_txt.TabIndex = 1;
            this.ngaysinh_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // tenkh_txt
            // 
            this.tenkh_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tenkh_txt.Location = new System.Drawing.Point(202, 35);
            this.tenkh_txt.Name = "tenkh_txt";
            this.tenkh_txt.Size = new System.Drawing.Size(174, 20);
            this.tenkh_txt.TabIndex = 0;
            this.tenkh_txt.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            // 
            // TimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 536);
            this.Controls.Add(this.diachi_txt);
            this.Controls.Add(this.dienthoai_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.ngaysinh_txt);
            this.Controls.Add(this.tenkh_txt);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimKiemKhachHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.Timkiem_Load);
            this.TextChanged += new System.EventHandler(this.dienthoai_txt_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachi_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienthoai_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkh_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.TextEdit diachi_txt;
        private DevExpress.XtraEditors.TextEdit dienthoai_txt;
        private DevExpress.XtraEditors.TextEdit mail_txt;
        private DevExpress.XtraEditors.TextEdit ngaysinh_txt;
        private DevExpress.XtraEditors.TextEdit tenkh_txt;

    }
}