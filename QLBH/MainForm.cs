using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;

namespace QLBH
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }
        public void TapCreating(XtraTabControl tabControl, string text, Form inform)
        {
            splashScreenManager2.ShowWaitForm();
            
            int kttab = kiemtratontaiTab(tabControl,text);
                if (kttab >= 0)
                {
                    tabControl.SelectedTabPage = tabControl.TabPages[kttab];
                    tabControl.SelectedTabPage.Text = text;
                }
                else
                {
                    XtraTabPage tabpage = new XtraTabPage{ Text = text };
                    tabControl.TabPages.Add(tabpage);
                    tabControl.SelectedTabPage = tabpage;
                    inform.TopLevel = false;
                    inform.Parent = tabpage;                    
                    inform.Show();
                    inform.Dock = DockStyle.Fill;
                }

           splashScreenManager2.CloseWaitForm();
        }

        public int kiemtratontaiTab(XtraTabControl tabcontrol, string text)
        {
            int k=-1;
            for (int i = 0; i < tabcontrol.TabPages.Count; i++)
            {
                if (tabcontrol.TabPages[i].Text == text)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
        
        //exit
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
              Application.Exit();
            
        }
        //About
        private void aboutbutton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About aboutf = new About();
            aboutf.ShowDialog();
            
            
        }
        //logout
        public bool ktlogout;
        private void logoutbutton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\QLBH.exe");
                this.Close();
            }
        }

        //Quan ly san pham
        private void QLSanPham_button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
    
           
            Formsss.QuanLySanPhamFrom sanpham = new Formsss.QuanLySanPhamFrom();
            
            TapCreating(xtraTabControl1, QLSanPham_button.Caption, sanpham);
            

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ngaystatusbar_txt.Caption = DateTime.Now.ToString();

            //kiemtra skin
            string fileNamea = Application.StartupPath + "\\Skins.txt";
            if (File.Exists(fileNamea) == false)
                UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            else
            {
                StreamReader sr = new StreamReader(fileNamea, false);
                UserLookAndFeel.Default.SetSkinStyle(sr.ReadLine());
                sr.Close();

            }
            //show name
            string file1 = Application.StartupPath + "\\nameNV.txt";
            StreamReader red1 = new StreamReader(file1);
            string s1 = red1.ReadLine();
            txtName.Caption = s1;
            //kiem tra quyen

            string file = Application.StartupPath + "\\nas.txt";
            StreamReader red = new StreamReader(file);
            string s=red.ReadLine();
            if (s.Trim().ToUpper() == "ADMIN")
            { 
                ribbonPageGroupNhanvien.Visible = true;
                luongnhanvien_group.Visible = true;
            }
            red.Close();
            ////
            if (s.Trim().ToUpper() != "ADMIN")
                quyen_txt.Caption = "USER";
            else
                quyen_txt.Caption = "ADMIN";
            
            
        }

        private void quanlyKhachhang_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Formsss.QuanLyKhachHang khachhang= new Formsss.QuanLyKhachHang();
            TapCreating(xtraTabControl1, quanlyKhachhang_btn.Caption, khachhang);
            
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.HoaDon hoadon = new Formsss.HoaDon();
            TapCreating(xtraTabControl1, hoadon_btn.Caption, hoadon);
            
        }

        private void chitiethd_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Formsss.ChiTietHoaDon cthoadon = new Formsss.ChiTietHoaDon();
            TapCreating(xtraTabControl1, chitiethd_btn.Caption, cthoadon);
          
        
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Formsss.NhanVien nhanvien = new Formsss.NhanVien();
            TapCreating(xtraTabControl1, nhanvien_btn.Caption, nhanvien);
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string skins = defaultLookAndFeel2.LookAndFeel.SkinName;
            string fileName = Application.StartupPath + "\\Skins.txt";
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(skins);
            sw.Close();
        }

        private void SLSPDaBan_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.SLSPDaBan slspdaban = new Formsss.SLSPDaBan();
            TapCreating(xtraTabControl1, SLSPDaBan_btn.Caption, slspdaban);
            
        }

        private void KhachHangVip_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.KhachHangVip khvip = new Formsss.KhachHangVip();
            TapCreating(xtraTabControl1, KhachHangVip_btn.Caption, khvip);
            
        }

        //private void SPBanChay_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{

        //    //   Formsss.SanPhamBanChay SanPhamBanChay = new Formsss.SanPhamBanChay();
        //    //  TapCreating(xtraTabControl1, SPBanChay_btn.Caption, SanPhamBanChay);

        //}

        private void NVBanNhieuNhat_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.DShoaDon dshoadon= new Formsss.DShoaDon();
            TapCreating(xtraTabControl1,dshoadon_btn.Caption, dshoadon);
            
        }
        //san pham ton kho
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.SPTonKho nhBanHangNhieuNhat = new Formsss.SPTonKho();
            TapCreating(xtraTabControl1, barButtonItem1.Caption, nhBanHangNhieuNhat);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Formsss.TongDoanhThu tongdoanhthu = new Formsss.TongDoanhThu();
            TapCreating(xtraTabControl1, tongdoanhthu_btn.Caption, tongdoanhthu);
            
        }

        private void luongnhanvien_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Formsss.LuongNhanVien luong = new Formsss.LuongNhanVien();
            TapCreating(xtraTabControl1, luongnhanvien_btn.Caption, luong);
           
        }
    }
}
