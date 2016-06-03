using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLBH.Formsss
{
    public partial class QuanLyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtb = new DataTable();
        ketnoi kketnoi = new ketnoi();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            UpdateList();
            tenkhachhang_txt.Focus();
        }
        
        private void UpdateList()
        {
            try
            {
                string str = "select *,cast(0 as bit) as Chon from khachhang";
                dtb = kketnoi.laydata(str);
                khachhang_gridcontrol.DataSource = dtb;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Lỗi");
            }
        }
        public void lammoi()
        {
            makh_txt.Text = "";
            tenkhachhang_txt.Text="";
            diachi_txt.Text = "";
            mail_txt.Text = "";
            dienthoai_txt.Text = "";
            ngaysinh_dateEdit.Text = "";
        }
        public int ns=0,ten = 0, diachi = 0, dienthoai = 0, mail = 0;
        
        public void cachamkiemtra()
        {
            if (tenkhachhang_txt.Text == "")
                ten = 1;
            else
                ten = 0;
            if (diachi_txt.Text == "")
                diachi = 1;
            else
                diachi = 0;
            if (ngaysinh_dateEdit.Text == "")
                ns = 1;
            else
                ns = 0;
        }
        bool loi;
        private void kiemtra()
        {
            cachamkiemtra();
            string thongbao = "";
            loi = false;
            if (ten == 1)
            {
                loi = true;
                thongbao += "Bạn chưa nhập tên khách hàng!";
            }
            if (ns == 1)
            {
                loi = true;
                thongbao += "\nBạn chưa nhập ngày sinh khách hàng!";
            }
            if (diachi == 1)
            {
                loi = true;
                thongbao += "\nBạn chưa nhập địa chỉ khách hàng!";
            }
            
            if(loi== true)
                XtraMessageBox.Show(thongbao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Them_btn_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtra();
                if(loi==false)
                    nhapdl();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Lỗi");
            }
        }

        private void nhapdl()
        {

            if (XtraMessageBox.Show("Bạn có muốn thêm khách hàng này!", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into khachhang values(@makh,@tenkh,@diachi,@dt,@mail,@ns)";
                kketnoi.ketnoiserver();
                SqlCommand comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@makh", "KH" + Convert.ToInt16(kketnoi.laydata_dong("if( select count(makh) from khachhang)>0 select max(substring(makh,3,2))+1 from KHACHHANG else select CAST ( 1 as int )")).ToString("00"));
                comd.Parameters.AddWithValue("@tenkh", tenkhachhang_txt.Text);
                comd.Parameters.AddWithValue("@diachi",diachi_txt.Text);
                comd.Parameters.AddWithValue("@dt", dienthoai_txt.Text);
                comd.Parameters.AddWithValue("@mail", mail_txt.Text);
                comd.Parameters.AddWithValue("@ns",Convert.ToDateTime(ngaysinh_dateEdit.Text));
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                UpdateList();
                XtraMessageBox.Show("Thêm thành công!");
                lammoi();
            }
            else
                tenkhachhang_txt.Focus();
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (makh_txt.Text == "")
                    XtraMessageBox.Show("Vui lòng chọn khách hàng!");
                else
                    Suadl();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Lỗi");
            }
        }

        private void Suadl()
        {
            if (XtraMessageBox.Show("Bạn có muốn Sửa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = " update khachhang set TENKH=@tenkh,DIACHI=@diachi,DT=@dt,MAIL=@mail,NGAYSINH=@ns where MAKH=@makh";
                kketnoi.ketnoiserver();
                SqlCommand comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@makh", makh_txt.Text);
                comd.Parameters.AddWithValue("@tenkh", tenkhachhang_txt.Text);
                comd.Parameters.AddWithValue("@ns", Convert.ToDateTime(ngaysinh_dateEdit.Text));
                comd.Parameters.AddWithValue("@diachi", diachi_txt.Text);
                comd.Parameters.AddWithValue("@dt", dienthoai_txt.Text);
                comd.Parameters.AddWithValue("@mail", mail_txt.Text);
                comd.ExecuteNonQuery();

                kketnoi.connect.Close();
                UpdateList();
                XtraMessageBox.Show("Sửa thành công!");
                lammoi();
               
            }
            else
            {
                tenkhachhang_txt.Focus();
            }
        }

        bool k;
        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                k = false;
                DataTable dt = khachhang_gridcontrol.DataSource as DataTable;
                if (dt == null) return;
                DataRow[] rows = dt.Select("Chon=true");
                if(rows.Count()>0)
                    if (XtraMessageBox.Show("Bạn có muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (DataRow r in rows)
                        {
                            string ma = r["MAKH"].ToString();
                            xoadl(ma);
                        }
                if (k == true)
                {
                    UpdateList();
                    XtraMessageBox.Show("Xóa thành công");
                    lammoi();
                }
                
            }
            catch(Exception )//ex)
            {
                XtraMessageBox.Show("Khách hàng đã chọn tồn tại trong chi tiết hóa đơn", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);//,"ex.Tostring());"
            }
        }

        private void xoadl(string ma)
        {
            string str = "delete from khachhang where MAKH=@makh";
            kketnoi.ketnoiserver();
            SqlCommand comd = new SqlCommand(str, kketnoi.connect);
            comd.Parameters.AddWithValue("@makh", ma);
            comd.ExecuteNonQuery();

            kketnoi.connect.Close();
            k = true;
        }
        private void kiemtradt(object sender, EventArgs e)
        {
        }
        private void kiemtrangaysinh(object sender, EventArgs e)
        {
            if (ngaysinh_dateEdit.Text != "")
            {

                string nam = ngaysinh_dateEdit.Text.Substring(6, 4);
                if (Convert.ToInt16(nam) > DateTime.Now.Year)
                {
                    XtraMessageBox.Show("Nhập sai ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ngaysinh_dateEdit.Text = "";
                    ngaysinh_dateEdit.Focus();
                }
            }
        }

        public void GetValue(String str1)
        {
            makh_txt.Text = str1;
        }

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            
            TimKiemKhachHang tim = new TimKiemKhachHang();
            tim.mygetdata = new TimKiemKhachHang.getstring(GetValue);
            tim.ShowDialog();
        }

        private void makh_txt_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (makh_txt.Text != "")
                {
                    string str = "select MAKH,TENKH,NGAYSINH,DIACHI,DT,MAIL from khachhang where makh='" + makh_txt.Text + "'";
                    dtb = kketnoi.laydata(str);
                    makh_txt.Text = dtb.Rows[0][0].ToString();
                    tenkhachhang_txt.Text = dtb.Rows[0][1].ToString();
                    ngaysinh_dateEdit.Text = dtb.Rows[0][2].ToString();
                    diachi_txt.Text = dtb.Rows[0][3].ToString();
                    dienthoai_txt.Text = dtb.Rows[0][4].ToString();
                    mail_txt.Text = dtb.Rows[0][5].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void khachhang_gridvew_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                makh_txt.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "MAKH").ToString().Trim();
                tenkhachhang_txt.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "TENKH").ToString().Trim();
                ngaysinh_dateEdit.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "NGAYSINH").ToString().Trim();
                diachi_txt.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "DIACHI").ToString().Trim();
                dienthoai_txt.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "DT").ToString().Trim();
                mail_txt.Text = khachhang_gridvew.GetRowCellValue(e.RowHandle, "MAIL").ToString().Trim();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Lỗi");
            }
        }

        private void khachhang_gridcontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Xoa_btn.PerformClick();
        }

        private void dienthoai_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))// | e.KeyChar==45)
            {
                e.Handled = true;
            }
        }

        private void dienthoai_txt_Validated(object sender, EventArgs e)
        {

            int len = dienthoai_txt.Text.ToString().Length;
            if (len != 0)
                if (len < 9 | len > 11)
                {
                    XtraMessageBox.Show("Nhập sai số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dienthoai_txt.Text = "";
                    dienthoai_txt.Focus();
                }
        }

        private void enter_trongt_textbox(object sender, KeyPressEventArgs e)//keypress
        {
           
            if (e.KeyChar == 13)
                Them_btn.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void simpleButton1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode.Equals(Keys.F))
                    timkiem_btn.PerformClick();
        }

        private void dienthoai_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}