namespace QLBH.Formsss
{
    partial class DShoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DShoaDon));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dshoadon_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.dshoadon_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLBH.Formsss.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dshoadon_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshoadon_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(510, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(253, 31);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Danh sách các hóa đơn";
            // 
            // dshoadon_gridcontrol
            // 
            this.dshoadon_gridcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshoadon_gridcontrol.Location = new System.Drawing.Point(185, 67);
            this.dshoadon_gridcontrol.MainView = this.dshoadon_gridview;
            this.dshoadon_gridcontrol.Name = "dshoadon_gridcontrol";
            this.dshoadon_gridcontrol.Size = new System.Drawing.Size(860, 365);
            this.dshoadon_gridcontrol.TabIndex = 6;
            this.dshoadon_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dshoadon_gridview});
            // 
            // dshoadon_gridview
            // 
            this.dshoadon_gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.dshoadon_gridview.GridControl = this.dshoadon_gridcontrol;
            this.dshoadon_gridview.Name = "dshoadon_gridview";
            this.dshoadon_gridview.OptionsBehavior.Editable = false;
            this.dshoadon_gridview.OptionsBehavior.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MaxWidth = 50;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 29;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã HĐ";
            this.gridColumn2.FieldName = "Mã hóa đơn";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên NV";
            this.gridColumn3.FieldName = "Tên nhân viên";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 121;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên khách hàng";
            this.gridColumn4.FieldName = "Tên khách hàng";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 126;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày";
            this.gridColumn5.FieldName = "Ngày";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 103;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên sản phẩm";
            this.gridColumn6.FieldName = "Tên sản phẩm";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 96;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số lượng";
            this.gridColumn7.FieldName = "Số lượng";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Khuyến mãi (%)";
            this.gridColumn8.FieldName = "Khuyến mãi (%)";
            this.gridColumn8.MaxWidth = 100;
            this.gridColumn8.MinWidth = 90;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 93;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Giá bán";
            this.gridColumn9.FieldName = "Giá bán";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 115;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(944, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 21);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Find";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(617, 73);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(307, 20);
            this.textEdit1.TabIndex = 12;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inhoadon
            // 
            this.inhoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inhoadon.Image = ((System.Drawing.Image)(resources.GetObject("inhoadon.Image")));
            this.inhoadon.Location = new System.Drawing.Point(944, 12);
            this.inhoadon.Name = "inhoadon";
            this.inhoadon.Size = new System.Drawing.Size(101, 41);
            this.inhoadon.TabIndex = 14;
            this.inhoadon.Text = "In hóa đơn";
            this.inhoadon.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DShoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 478);
            this.Controls.Add(this.inhoadon);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dshoadon_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DShoaDon";
            this.Text = "NVBanHangNhieuNhat";
            this.Load += new System.EventHandler(this.NVBanHangNhieuNhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dshoadon_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dshoadon_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl dshoadon_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView dshoadon_gridview;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton inhoadon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        //private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        //private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        //     private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}