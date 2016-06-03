namespace QLBH.Formsss
{
    partial class Ketnoidatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ketnoidatabase));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tenservertxt = new System.Windows.Forms.TextBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLBH.Formsss.WaitForm1), true, true);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(85, 221);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            this.labelControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(224, 221);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(167, 23);
            this.usertxt.TabIndex = 1;
            this.usertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(224, 254);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(167, 23);
            this.passtxt.TabIndex = 2;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(85, 254);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu";
            this.labelControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(85, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên server";
            this.labelControl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // tenservertxt
            // 
            this.tenservertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenservertxt.Location = new System.Drawing.Point(182, 185);
            this.tenservertxt.Name = "tenservertxt";
            this.tenservertxt.Size = new System.Drawing.Size(209, 23);
            this.tenservertxt.TabIndex = 1;
            this.tenservertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton2.Image = global::QLBH.Properties.Resources.close;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(493, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(25, 24);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            this.simpleButton2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QLBH.Properties.Resources.database_inactive;
            this.pictureEdit1.Location = new System.Drawing.Point(215, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(130, 124);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(224, 292);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 33);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Kết nối";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            this.simpleButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelControl1_KeyPress);
            // 
            // Ketnoidatabase
            // 
            this.ActiveGlowColor = System.Drawing.Color.Empty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(530, 368);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.tenservertxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.Empty;
            this.Name = "Ketnoidatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối Database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox tenservertxt;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}