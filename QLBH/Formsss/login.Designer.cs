namespace QLBH.Formsss
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tendangnhaptxt = new DevExpress.XtraEditors.TextEdit();
            this.matkhautxt = new System.Windows.Forms.TextBox();
            this.NhoMatKhauCheck = new DevExpress.XtraEditors.CheckEdit();
            this.tudongdangnhap_ckeck = new DevExpress.XtraEditors.CheckEdit();
            this.nhoTenDangNhapCheck = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ketnoidatabase = new DevExpress.XtraEditors.SimpleButton();
            this.dangnhapbtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLBH.Formsss.WaitForm1), true, true);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tendangnhaptxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhoMatKhauCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudongdangnhap_ckeck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhoTenDangNhapCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(105, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(105, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // tendangnhaptxt
            // 
            this.tendangnhaptxt.Location = new System.Drawing.Point(231, 149);
            this.tendangnhaptxt.Name = "tendangnhaptxt";
            this.tendangnhaptxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tendangnhaptxt.Properties.Appearance.Options.UseFont = true;
            this.tendangnhaptxt.Size = new System.Drawing.Size(184, 22);
            this.tendangnhaptxt.TabIndex = 7;
            this.tendangnhaptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // matkhautxt
            // 
            this.matkhautxt.Font = new System.Drawing.Font("Tahoma", 9F);
            this.matkhautxt.Location = new System.Drawing.Point(231, 191);
            this.matkhautxt.Name = "matkhautxt";
            this.matkhautxt.Size = new System.Drawing.Size(184, 22);
            this.matkhautxt.TabIndex = 11;
            this.matkhautxt.UseSystemPasswordChar = true;
            this.matkhautxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // NhoMatKhauCheck
            // 
            this.NhoMatKhauCheck.Location = new System.Drawing.Point(229, 267);
            this.NhoMatKhauCheck.Name = "NhoMatKhauCheck";
            this.NhoMatKhauCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NhoMatKhauCheck.Properties.Appearance.Options.UseFont = true;
            this.NhoMatKhauCheck.Properties.Caption = "Nhớ mật khẩu";
            this.NhoMatKhauCheck.Size = new System.Drawing.Size(140, 21);
            this.NhoMatKhauCheck.TabIndex = 13;
            this.NhoMatKhauCheck.CheckedChanged += new System.EventHandler(this.ktramatkhaudangnhap);
            this.NhoMatKhauCheck.CheckStateChanged += new System.EventHandler(this.ktraaaaaaaaaaa);
            this.NhoMatKhauCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // tudongdangnhap_ckeck
            // 
            this.tudongdangnhap_ckeck.Location = new System.Drawing.Point(229, 294);
            this.tudongdangnhap_ckeck.Name = "tudongdangnhap_ckeck";
            this.tudongdangnhap_ckeck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tudongdangnhap_ckeck.Properties.Appearance.Options.UseFont = true;
            this.tudongdangnhap_ckeck.Properties.Caption = "Tự động đăng nhập";
            this.tudongdangnhap_ckeck.Size = new System.Drawing.Size(150, 21);
            this.tudongdangnhap_ckeck.TabIndex = 14;
            this.tudongdangnhap_ckeck.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            this.tudongdangnhap_ckeck.CheckStateChanged += new System.EventHandler(this.ktraaaaaaaaaaa);
            this.tudongdangnhap_ckeck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // nhoTenDangNhapCheck
            // 
            this.nhoTenDangNhapCheck.Location = new System.Drawing.Point(229, 240);
            this.nhoTenDangNhapCheck.Name = "nhoTenDangNhapCheck";
            this.nhoTenDangNhapCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nhoTenDangNhapCheck.Properties.Appearance.Options.UseFont = true;
            this.nhoTenDangNhapCheck.Properties.Caption = "Nhớ tên đăng nhập";
            this.nhoTenDangNhapCheck.Size = new System.Drawing.Size(150, 21);
            this.nhoTenDangNhapCheck.TabIndex = 12;
            this.nhoTenDangNhapCheck.CheckedChanged += new System.EventHandler(this.ktratendangnhap);
            this.nhoTenDangNhapCheck.CheckStateChanged += new System.EventHandler(this.ktraaaaaaaaaaa);
            this.nhoTenDangNhapCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Image = global::QLBH.Properties.Resources.close;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(589, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(25, 24);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ketnoidatabase
            // 
            this.ketnoidatabase.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ketnoidatabase.Appearance.Options.UseFont = true;
            this.ketnoidatabase.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.ketnoidatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ketnoidatabase.Image = ((System.Drawing.Image)(resources.GetObject("ketnoidatabase.Image")));
            this.ketnoidatabase.Location = new System.Drawing.Point(450, 346);
            this.ketnoidatabase.Name = "ketnoidatabase";
            this.ketnoidatabase.Size = new System.Drawing.Size(164, 31);
            this.ketnoidatabase.TabIndex = 16;
            this.ketnoidatabase.Text = "Kết nối Database";
            this.ketnoidatabase.Visible = false;
            this.ketnoidatabase.Click += new System.EventHandler(this.ketnoidatabase_Click_1);
            // 
            // dangnhapbtn
            // 
            this.dangnhapbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dangnhapbtn.Appearance.Options.UseFont = true;
            this.dangnhapbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dangnhapbtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dangnhapbtn.Image = global::QLBH.Properties.Resources.login;
            this.dangnhapbtn.Location = new System.Drawing.Point(237, 333);
            this.dangnhapbtn.Name = "dangnhapbtn";
            this.dangnhapbtn.Size = new System.Drawing.Size(132, 44);
            this.dangnhapbtn.TabIndex = 15;
            this.dangnhapbtn.Text = "Đăng nhập";
            this.dangnhapbtn.Click += new System.EventHandler(this.dangnhapbtn_Click_1);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QLBH.Properties.Resources.Sign_in;
            this.pictureEdit1.Location = new System.Drawing.Point(265, 19);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(114, 108);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.ActiveGlowColor = System.Drawing.Color.Empty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(626, 389);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ketnoidatabase);
            this.Controls.Add(this.dangnhapbtn);
            this.Controls.Add(this.NhoMatKhauCheck);
            this.Controls.Add(this.tudongdangnhap_ckeck);
            this.Controls.Add(this.nhoTenDangNhapCheck);
            this.Controls.Add(this.matkhautxt);
            this.Controls.Add(this.tendangnhaptxt);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.Empty;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tendangnhaptxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhoMatKhauCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudongdangnhap_ckeck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhoTenDangNhapCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit tendangnhaptxt;
        private System.Windows.Forms.TextBox matkhautxt;
        private DevExpress.XtraEditors.SimpleButton ketnoidatabase;
        private DevExpress.XtraEditors.SimpleButton dangnhapbtn;
        private DevExpress.XtraEditors.CheckEdit NhoMatKhauCheck;
        private DevExpress.XtraEditors.CheckEdit tudongdangnhap_ckeck;
        private DevExpress.XtraEditors.CheckEdit nhoTenDangNhapCheck;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}