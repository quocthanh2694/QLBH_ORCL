namespace QLBH.Formsss
{
    partial class TimKiemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemSanPham));
            this.tenvt_txt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timkiem_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dvt_text = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giamua_text = new DevExpress.XtraEditors.TextEdit();
            this.slton_text = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvt_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamua_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slton_text.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenvt_txt
            // 
            this.tenvt_txt.Location = new System.Drawing.Point(188, 30);
            this.tenvt_txt.Name = "tenvt_txt";
            this.tenvt_txt.Size = new System.Drawing.Size(130, 20);
            this.tenvt_txt.TabIndex = 0;
            this.tenvt_txt.TextChanged += new System.EventHandler(this.timkiem);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(111, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên vật tư";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(111, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Đơn vị tính";
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.Image = ((System.Drawing.Image)(resources.GetObject("timkiem_btn.Image")));
            this.timkiem_btn.Location = new System.Drawing.Point(575, 33);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(100, 38);
            this.timkiem_btn.TabIndex = 4;
            this.timkiem_btn.Text = "Tìm kiếm";
            this.timkiem_btn.Click += new System.EventHandler(this.timkiem_btn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(355, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giá mua";
            // 
            // dvt_text
            // 
            this.dvt_text.Location = new System.Drawing.Point(188, 74);
            this.dvt_text.Name = "dvt_text";
            this.dvt_text.Size = new System.Drawing.Size(89, 20);
            this.dvt_text.TabIndex = 1;
            this.dvt_text.TextChanged += new System.EventHandler(this.timkiem);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(355, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Số lượng tồn";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(80, 142);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 357);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã vật tư";
            this.gridColumn1.FieldName = "MAVT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 83;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên vật tư";
            this.gridColumn2.FieldName = "TENVT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 137;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn vị tính";
            this.gridColumn3.FieldName = "DVT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá mua";
            this.gridColumn4.FieldName = "GIAMUA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 145;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số lượng tồn";
            this.gridColumn5.FieldName = "SLTON";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 159;
            // 
            // giamua_text
            // 
            this.giamua_text.Location = new System.Drawing.Point(429, 30);
            this.giamua_text.Name = "giamua_text";
            this.giamua_text.Properties.Mask.EditMask = "f2";
            this.giamua_text.Size = new System.Drawing.Size(89, 20);
            this.giamua_text.TabIndex = 2;
            this.giamua_text.TextChanged += new System.EventHandler(this.timkiem);
            this.giamua_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giamua_text_KeyPress);
            // 
            // slton_text
            // 
            this.slton_text.Location = new System.Drawing.Point(429, 74);
            this.slton_text.Name = "slton_text";
            this.slton_text.Size = new System.Drawing.Size(89, 20);
            this.slton_text.TabIndex = 3;
            this.slton_text.TextChanged += new System.EventHandler(this.timkiem);
            this.slton_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giamua_text_KeyPress);
            // 
            // TimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 525);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dvt_text);
            this.Controls.Add(this.giamua_text);
            this.Controls.Add(this.slton_text);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tenvt_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TimKiemSanPham";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.Timkiem_Load);
            this.TextChanged += new System.EventHandler(this.timkiem);
            ((System.ComponentModel.ISupportInitialize)(this.tenvt_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamua_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slton_text.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tenvt_txt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton timkiem_btn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit dvt_text;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit giamua_text;
        private DevExpress.XtraEditors.TextEdit slton_text;
    }
}