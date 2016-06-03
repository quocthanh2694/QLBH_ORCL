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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        SqlCommand comd = new SqlCommand();
        DataTable dtb = new DataTable();
         int  ten,diachi,dienthoai;
         bool loi;
         string thongbao;
        private void kiemtra()
        {
            if (tennv_txt.Text == "")
                ten = 1;            
            else
                ten = 0;
            if (diachi_txt.Text == "")
                diachi = 1;
            else
                diachi = 0;
            if (dienthoai_txt.Text == "")
                dienthoai = 1;
            else
                dienthoai = 0;

            thongbao = "";
            loi = false;
            if (ten == 1)
            { 
                loi = true;
                thongbao+="Bạn chưa nhập tên nhân viên";
            }
            if (diachi == 1)
            {
                loi = true;
                thongbao += "\nBạn chưa nhập địa chỉ nhân viên";
            }
            if (dienthoai == 1)
            {
                loi = true;
                thongbao += "\nBạn chưa nhập số điện thoại nhân viên";
            }
            kiemtradt();
            if (chucvu_cbx.Text == "")
            {
                loi = true;
                thongbao += "\nBạn chưa chọn chức vụ nhân viên";
            }
            if (luong_txt.Text =="")
            {
                luong_txt.Text = "0";
            }
            if(loi==true)
                XtraMessageBox.Show(thongbao, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void kiemtradt()
        {
            int len = dienthoai_txt.Text.ToString().Length;
            if (len != 0)
                if (len < 9 | len > 11)
                {
                    dienthoai_txt.Text = "";
                    dienthoai_txt.Focus();
                    thongbao += "\nNhập sai số điện thoại";
                    loi = true;

                }
        }
        private void Them_btn_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtra();
                kiemtradt();
                if(loi==false)
                    nhapdl();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void nhapdl()
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into nhanvien values(@MANV,@TENNV,@DIACHI,@DT,@CHUCVU,@LUONG)";
                kketnoi.ketnoiserver();
                comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MANV", "NV" + Convert.ToInt16((kketnoi.laydata_dong("if(select count (manv) from NHANVIEN)>0	select max( SUBSTRING(manv,3,2))+1 from nhanvien else select cast (1 as int)"))).ToString("00"));
                comd.Parameters.AddWithValue("@TENNV", tennv_txt.Text);
                comd.Parameters.AddWithValue("@DIACHI", diachi_txt.Text.Trim());
                comd.Parameters.AddWithValue("@DT", dienthoai_txt.Text.Trim());
                comd.Parameters.AddWithValue("@CHUCVU", chucvu_cbx.Text);
                comd.Parameters.AddWithValue("@LUONG", Convert.ToDouble(luong_txt.Text.ToString()));
               
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Thêm thành công");
                lammoi();
            }
            else
                tennv_txt.Focus();
        }
        private void updatelist()
        {
            dtb = kketnoi.laydata("select *,cast(0 as bit) as Chon from nhanvien");
            nhanvien_gridcontrol.DataSource = dtb;
        }
        private void lammoi()
        {
            manv_txt.Text="";
            tennv_txt.Text="";
            diachi_txt.Text="";
            dienthoai_txt.Text="";
            luong_txt.Text = "";
            chucvu_cbx.Text = "";
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (manv_txt.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn nhân viên!");
                }
                else
                {
                     int len = dienthoai_txt.Text.ToString().Length;
                     if (len != 0)
                        if (len < 9 | len > 11)
                        {
                            XtraMessageBox.Show("Sai số điện thoại");
                        }
                        else
                            suadl();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể sửa" + ex.ToString());
            }
        }

        private void suadl()
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "update nhanvien set MANV=@MANV,TENNV=@TENNV,DIACHI=@DIACHI,DT=@DT,LUONG=@LUONG,CHUCVU=@CHUCVU where MANV=@MANV";
                kketnoi.ketnoiserver();
                comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MANV", manv_txt.Text.Trim());
                comd.Parameters.AddWithValue("@TENNV", tennv_txt.Text.Trim());
                comd.Parameters.AddWithValue("@DIACHI", diachi_txt.Text.Trim());
                comd.Parameters.AddWithValue("@DT", dienthoai_txt.Text.Trim());
                comd.Parameters.AddWithValue("LUONG", Convert.ToDouble(luong_txt.Text.ToString()));
                comd.Parameters.AddWithValue("CHUCVU", chucvu_cbx.Text);

                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Sửa thành công");

                lammoi();
            }
            else
            {
                tennv_txt.Focus();
            }
        }
        public bool k ;
        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                k = false;
                DataTable dt = nhanvien_gridcontrol.DataSource as DataTable;
                if (dt == null)
                    return;
                DataRow[] rows = dt.Select("Chon=true");
                if(rows.Count()>0)
                    if (XtraMessageBox.Show("Bạn có muốn xóa những nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                        foreach (DataRow r in rows)
                        {
                            string manv = r["MANV"].ToString();
                            xoadl(manv);
                    
                        }
                if (k == true)
                {
                    updatelist();
                    XtraMessageBox.Show("Đã xóa");
                    lammoi();
                    
                }

            }
            catch (Exception )
            {
                XtraMessageBox.Show("Nhân viên đã chọn tồn tại trong danh sách hóa đơn","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);//Không thể xóa" + ex.ToString());
            }
        }

        private void xoadl(string ma)
        {          
                string str = "delete from nhanvien where MANV=@MANV";
                kketnoi.ketnoiserver();
                comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MANV", ma);
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                 k = true;
            
        }
        public void GetValue(String str1)
        {
            manv_txt.Text  = str1;
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {

            TimKiemNhanVien tim = new TimKiemNhanVien();
            tim.getdata = new TimKiemNhanVien.Getstring(GetValue);
            tim.ShowDialog();
            
        }

        private void nhanvien_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            manv_txt.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "MANV").ToString().Trim();
            tennv_txt.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "TENNV").ToString().Trim();
            diachi_txt.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "DIACHI").ToString().Trim();
            dienthoai_txt.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "DT").ToString().Trim();
            chucvu_cbx.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "CHUCVU").ToString();
            luong_txt.Text = nhanvien_gridview.GetRowCellValue(e.RowHandle, "LUONG").ToString();
        }

        private void nhanvien_gridview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Xoa_btn.PerformClick();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            updatelist();
            tennv_txt.Focus();
        }

        private void dienthoai_txt_Validated(object sender, EventArgs e)
        {
           // kiemtradt();
        }

      

        private void dienthoai_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ktra_enter_txt_ketpress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
                Them_btn.PerformClick();
        }

        private void manv_txt_TextChanged(object sender, EventArgs e)
        {
            
            if (manv_txt.Text.ToString() != "")
            { 
                string sql = "select* from nhanvien where manv like  '"+manv_txt.Text+"'";
                DataTable dttb = kketnoi.laydata(sql);
                manv_txt.Text = dttb.Rows[0]["MANV"].ToString();
                tennv_txt.Text = dttb.Rows[0]["TENNV"].ToString();
                diachi_txt.Text = dttb.Rows[0]["Diachi"].ToString();
                dienthoai_txt.Text = dttb.Rows[0]["DT"].ToString();
                chucvu_cbx.Text = dttb.Rows[0]["CHUCVU"].ToString();
                luong_txt.Text = dttb.Rows[0]["LUONG"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void dienthoai_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode.Equals(Keys.F))
                    timkiem_btn.PerformClick();
        }

        private void luong_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dienthoai_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nhanvien_gridcontrol_Click(object sender, EventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}