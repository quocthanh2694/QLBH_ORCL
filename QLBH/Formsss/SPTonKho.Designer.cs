namespace QLBH.Formsss
{
    partial class SPTonKho
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SanPhamTonKho_gridcontrol = new DevExpress.XtraGrid.GridControl();
            this.sanPhanTonKho_gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamTonKho_gridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhanTonKho_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.labelControl7.Location = new System.Drawing.Point(512, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(300, 31);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Số lượng sản phẩm tồn kho";
            // 
            // SanPhamTonKho_gridcontrol
            // 
            this.SanPhamTonKho_gridcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SanPhamTonKho_gridcontrol.Location = new System.Drawing.Point(186, 67);
            this.SanPhamTonKho_gridcontrol.MainView = this.sanPhanTonKho_gridview;
            this.SanPhamTonKho_gridcontrol.Name = "SanPhamTonKho_gridcontrol";
            this.SanPhamTonKho_gridcontrol.Size = new System.Drawing.Size(891, 373);
            this.SanPhamTonKho_gridcontrol.TabIndex = 8;
            this.SanPhamTonKho_gridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.sanPhanTonKho_gridview});
            // 
            // sanPhanTonKho_gridview
            // 
            this.sanPhanTonKho_gridview.GridControl = this.SanPhamTonKho_gridcontrol;
            this.sanPhanTonKho_gridview.Name = "sanPhanTonKho_gridview";
            this.sanPhanTonKho_gridview.OptionsBehavior.Editable = false;
            this.sanPhanTonKho_gridview.OptionsBehavior.ReadOnly = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(781, 73);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(196, 20);
            this.textEdit1.TabIndex = 10;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_textchanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(988, 72);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 21);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Find";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SPTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 478);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.SanPhamTonKho_gridcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SPTonKho";
            this.Text = "SPTonKho";
            this.Load += new System.EventHandler(this.SPTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamTonKho_gridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhanTonKho_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl SanPhamTonKho_gridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView sanPhanTonKho_gridview;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer timer1;
    }
}