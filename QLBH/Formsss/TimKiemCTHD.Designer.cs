namespace QLBH.Formsss
{
    partial class TimKiemCTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemCTHD));
            this.chitiethd_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.chitiethd_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.girdcolumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.giaban_txt = new DevExpress.XtraEditors.TextEdit();
            this.soluong_txt = new DevExpress.XtraEditors.TextEdit();
            this.mavt_txt = new DevExpress.XtraEditors.TextEdit();
            this.mahd_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.khuyenmai_txt = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethd_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethd_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaban_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavt_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahd_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenmai_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chitiethd_gridcontrol
            // 
            this.chitiethd_gridcontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chitiethd_gridcontrol.Location = new System.Drawing.Point(101, 142);
            this.chitiethd_gridcontrol.MainView = this.chitiethd_gridview;
            this.chitiethd_gridcontrol.Name = "chitiethd_gridcontrol";
            this.chitiethd_gridcontrol.Size = new System.Drawing.Size(606, 300);
            this.chitiethd_gridcontrol.TabIndex = 4;
            this.chitiethd_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.chitiethd_gridview});
            // 
            // chitiethd_gridview
            // 
            this.chitiethd_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.girdcolumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.chitiethd_gridview.GridControl = this.chitiethd_gridcontrol;
            this.chitiethd_gridview.Name = "chitiethd_gridview";
            this.chitiethd_gridview.OptionsSelection.MultiSelect = true;
            this.chitiethd_gridview.DoubleClick += new System.EventHandler(this.chitiethd_gridview_DoubleClick);
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
            this.gridColumn2.Caption = "Mã VT";
            this.gridColumn2.FieldName = "MAVT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 135;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "SL";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Khuyến mãi (%)";
            this.gridColumn4.FieldName = "KHUYENMAI";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá bán";
            this.gridColumn5.FieldName = "GIABAN";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 122;
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(608, 65);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(100, 38);
            this.timkiem_btn.TabIndex = 5;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Location = new System.Drawing.Point(538, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 14);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Giá bán";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(288, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 14);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Khuyến mãi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(288, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 14);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(101, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Mã vật tư";
            // 
            // giaban_txt
            // 
            this.giaban_txt.Location = new System.Drawing.Point(608, 30);
            this.giaban_txt.Name = "giaban_txt";
            this.giaban_txt.Size = new System.Drawing.Size(99, 20);
            this.giaban_txt.TabIndex = 4;
            this.giaban_txt.TextChanged += new System.EventHandler(this.giaban_txt_TextChanged);
            // 
            // soluong_txt
            // 
            this.soluong_txt.Location = new System.Drawing.Point(381, 29);
            this.soluong_txt.Name = "soluong_txt";
            this.soluong_txt.Size = new System.Drawing.Size(123, 20);
            this.soluong_txt.TabIndex = 2;
            this.soluong_txt.TextChanged += new System.EventHandler(this.giaban_txt_TextChanged);
            // 
            // mavt_txt
            // 
            this.mavt_txt.Location = new System.Drawing.Point(178, 75);
            this.mavt_txt.Name = "mavt_txt";
            this.mavt_txt.Size = new System.Drawing.Size(65, 20);
            this.mavt_txt.TabIndex = 1;
            this.mavt_txt.TextChanged += new System.EventHandler(this.giaban_txt_TextChanged);
            // 
            // mahd_txt
            // 
            this.mahd_txt.Location = new System.Drawing.Point(178, 32);
            this.mahd_txt.Name = "mahd_txt";
            this.mahd_txt.Size = new System.Drawing.Size(65, 20);
            this.mahd_txt.TabIndex = 0;
            this.mahd_txt.TextChanged += new System.EventHandler(this.giaban_txt_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(101, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 14);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // khuyenmai_txt
            // 
            this.khuyenmai_txt.Location = new System.Drawing.Point(381, 75);
            this.khuyenmai_txt.Name = "khuyenmai_txt";
            this.khuyenmai_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.khuyenmai_txt.Properties.Items.AddRange(new object[] {
            "5%",
            "10%",
            "0"});
            this.khuyenmai_txt.Size = new System.Drawing.Size(123, 20);
            this.khuyenmai_txt.TabIndex = 3;
            this.khuyenmai_txt.EditValueChanged += new System.EventHandler(this.khuyenmai_txt_EditValueChanged);
            this.khuyenmai_txt.TextChanged += new System.EventHandler(this.giaban_txt_TextChanged);
            // 
            // TimKiemCTHD
            // 
            this.AcceptButton = this.timkiem_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 476);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.giaban_txt);
            this.Controls.Add(this.mahd_txt);
            this.Controls.Add(this.mavt_txt);
            this.Controls.Add(this.soluong_txt);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.chitiethd_gridcontrol);
            this.Controls.Add(this.khuyenmai_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimKiemCTHD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiemCTHD";
            this.Load += new System.EventHandler(this.TimKiemCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitiethd_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethd_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaban_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavt_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahd_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenmai_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl chitiethd_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView chitiethd_gridview;
        private DevExpress.XtraGrid.Columns.GridColumn girdcolumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit giaban_txt;
        private DevExpress.XtraEditors.TextEdit soluong_txt;
        private DevExpress.XtraEditors.TextEdit mavt_txt;
        private DevExpress.XtraEditors.TextEdit mahd_txt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit khuyenmai_txt;
    }
}