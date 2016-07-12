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
using System.IO;
using System.Runtime.InteropServices;
using DevExpress.LookAndFeel;


namespace QLBH.Formsss
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
       ketnoi k = new ketnoi();
        public Login()
        {
            InitializeComponent();
        }
        public bool ktra;
        bool kttenmk ;
        private void kiemtra()
        {
            string thongbao="";
            kttenmk = false;
            if (tendangnhaptxt.Text == "")
            {
                thongbao = "Vui lòng nhập tên!";
                kttenmk = true;
            }
            if (matkhautxt.Text == "")
            {
                thongbao += "\nVui lòng nhập mật khẩu!";
                kttenmk = true;
            }

            if (kttenmk == true)
                XtraMessageBox.Show(thongbao);

            
        }
        private void dangnhapbtn_Click_1(object sender, EventArgs e)
        {
            kiemtra();
            if(kttenmk==false)
                Dangnhap();
        }

        private void Dangnhap()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                bool ktketnoi = false;
                DataTable dtb = new DataTable();
                try
                {
                    string stri = "select username,password from taikhoan where username='" + tendangnhaptxt.Text + "' and password='" + matkhautxt.Text + "'";
                    dtb = k.laydata(stri);
                    ktketnoi = true;
                    splashScreenManager1.CloseWaitForm();
                }
                catch (Exception)
                {
                    splashScreenManager1.CloseWaitForm();
                    ktketnoi = false;
                    XtraMessageBox.Show("Lỗi kết nối đến máy chủ!");
                    
                }

                if (ktketnoi == true)
                {
                    if (dtb.Rows.Count > 0)
                    {
                        ghiten();
                        nhotendangnhap();
                        ktra = true;
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Đăng nhập thất bại\nVui lòng kiểm tra lại thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tendangnhaptxt.ResetText();
                        matkhautxt.ResetText();
                        tendangnhaptxt.Focus();
                        ktra = false;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }

        }
        private void ghiten()
        {
            string sql = "select tennv from taikhoan d,nhanvien v where d.manv=v.manv and  username='" + tendangnhaptxt.Text + "' and password='" + matkhautxt.Text + "'";
            string ten = k.laydata_dong(sql);

            string file1 = Application.StartupPath + "\\nameNV.txt";
            StreamWriter s1 = new StreamWriter(file1);
            s1.Write(ten);
            s1.Close();

            string file = Application.StartupPath + "\\nas.txt";
            StreamWriter s = new StreamWriter(file);
            s.Write(tendangnhaptxt.Text);

            s.Close();
        }
        private void ketnoidatabase_Click_1(object sender, EventArgs e)
        {
            Ketnoidatabase ketnoi = new Ketnoidatabase();
            ketnoi.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dangnhapbtn.PerformClick();
            }
        }
       private void Login_Load(object sender, EventArgs e)
         {
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
          
            
             ketnoi k = new ketnoi();
             
             DataTable t = new DataTable();
           //kiem tra nho ten,nho mk,tu dong dang nhap
             try
             {
               
                string fileName = Application.StartupPath + "\\ID.txt";
                 if (File.Exists(fileName) == true)
                 {
                     StreamReader file = new StreamReader(fileName);
                     string s = file.ReadLine().ToString().Trim();
                   
                     string r = "select username,password from taikhoan where username='"+s+"'";
                     nhoTenDangNhapCheck.Checked = true;
                     t = k.laydata(r);
                     tendangnhaptxt.Text = t.Rows[0][0].ToString();
                 }
                 string mkhau = Application.StartupPath + "\\MK.txt";
                 if (File.Exists(mkhau) == true)
                 {
                     StreamReader file = new StreamReader(fileName);
                     string s = file.ReadLine().ToString().Trim();

                     string r = "select username,password from taikhoan where username='"+s+"'";
                     NhoMatKhauCheck.Checked = true;
                     t = k.laydata(r);
                     matkhautxt.Text = t.Rows[0][1].ToString();
                 }
                 string tddn = Application.StartupPath + "\\tđn.txt";
                 if (File.Exists(tddn) == true)
                     tudongdangnhap_ckeck.Checked = true;
                
             }
             catch (Exception ex)
             { 
                XtraMessageBox.Show(ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }
        }
            
        private void nhotendangnhap()
       {
           try
           {
               if (nhoTenDangNhapCheck.Checked)
               {
                   string id = Application.StartupPath + "\\ID.txt";
                   StreamWriter s = new StreamWriter(id, false);
                   s.Write(tendangnhaptxt.Text);
                   s.Close();
               }
               if (NhoMatKhauCheck.Checked)
               {
                   string mk = Application.StartupPath + "\\MK.txt";
                   StreamWriter m = new StreamWriter(mk, false);
                   m.WriteLine("******");
                   m.Close();
               }
               if (tudongdangnhap_ckeck.Checked)
               {
                   string mk = Application.StartupPath + "\\tđn.txt";
                   StreamWriter m = new StreamWriter(mk, false);
                   m.WriteLine("");
                   m.Close();
               }
           }
           catch (Exception)
           { 
            
           }
        }
        private void ktraaaaaaaaaaa(object sender, EventArgs e)
        {
            if (nhoTenDangNhapCheck.Checked == false)
                NhoMatKhauCheck.Checked = false;

            if (NhoMatKhauCheck.Checked == false)
                tudongdangnhap_ckeck.Checked = false;
            
        }

        private void ktratendangnhap(object sender, EventArgs e)
        {
            try
            {
                if (nhoTenDangNhapCheck.Checked == false)
                    File.Delete(Application.StartupPath + "\\ID.txt");
            }
            catch (Exception) { }
        }

        private void ktramatkhaudangnhap(object sender, EventArgs e)
        {
            try
            {
                if (NhoMatKhauCheck.Checked == false)
                    File.Delete(Application.StartupPath + "\\MK.txt");
            }
            catch (Exception) { }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if (tudongdangnhap_ckeck.Checked == false)
                File.Delete(Application.StartupPath + "\\tđn.txt");
            }
            catch (Exception) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tudongdangnhap_ckeck.Checked==true)
            dangnhapbtn.PerformClick();
        }
    }
}
