using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;


namespace QLBH.Formsss
{
    
    public partial class Ketnoidatabase : DevExpress.XtraEditors.XtraForm
    {
        public Ketnoidatabase()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tenservertxt.Text == "" | usertxt.Text == "" | passtxt.Text == "")
                {
                    XtraMessageBox.Show("Sai thông tin \nKết nối thất bại!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tenservertxt.Focus();
                    return;
                }
                splashScreenManager1.ShowWaitForm();
                ketnoi ktketnoi = new ketnoi();
                if (ktketnoi.ktketnoiserver(tenservertxt.Text, usertxt.Text, passtxt.Text) == true)
                {
                    splashScreenManager1.CloseWaitForm();
                    Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("server", tenservertxt.Text);
                    Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("user", usertxt.Text);
                    Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("pass", passtxt.Text);
                    XtraMessageBox.Show("Kết nối đến máy chủ thành công!!!!!");
                    this.Close();
                }
                else
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("Kết nối thất bại!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    simpleButton1.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi:" + ex.ToString());
            }
  
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton1.PerformClick();
            }

        }
    }
}
