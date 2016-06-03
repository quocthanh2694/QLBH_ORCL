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
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace QLBH.Formsss
{
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        SqlCommand comd = new SqlCommand();
        public HoaDon()
        {
            InitializeComponent();
        }

        int manv,makh,ngay,tongtg;
        bool loi;
        private void kiemtra()
        {
            if (tongtg_txt.Text == "")
                tongtg = 1;
            else
                tongtg = 0;
            if (manv_txt.Text == "")
                manv = 1;
            else
                manv = 0;
            if (makhachhang_txt.Text == "")
                makh = 1;
            else
                makh = 0;
            if (Ngay_txt.Text == "")
                ngay = 1;
            else
                ngay = 0;

            string thongbao="";
            loi = false;
            if (manv == 1)
            {
                loi = true;
                thongbao = "Vui lòng chọn mã nhân viên";
            }
            if (ngay == 1)
            {
                loi = true;
                thongbao += "\nVui lòng chọn ngày";
            }
            
            if (makh == 1)
            {
                loi = true;
                thongbao += "\nVui lòng chọn mã khách hàng";
            }
            if (tongtg == 1)
            {
                //loi = true;
                //thongbao += "\nVui long nhập tổng trị giá";
            }
            if (loi == true)
                XtraMessageBox.Show(thongbao, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void nhapdl()
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into hoadon values(@MAHD,@NGAY,@MAKH,@TONGTG,@MANV)";
                kketnoi.ketnoiserver();
                comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MAHD", "HD" + Convert.ToInt16((kketnoi.laydata_dong("if( select count(mahd) from hoadon)>0 select max( SUBSTRING(mahd,3,3))+1 from hoadon else select CAST ( 1 as int )"))).ToString("000"));
                comd.Parameters.AddWithValue("@NGAY",Convert.ToDateTime(Ngay_txt.Text));
                comd.Parameters.AddWithValue("@MAKH", makhachhang_txt.Text);
                comd.Parameters.AddWithValue("@TONGTG", tongtg_txt.Text);
                comd.Parameters.AddWithValue("@MANV", manv_txt.Text);

                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Thêm thành công");
                lammoi();
            }
            else
                manv_txt.Focus();
        }
        private void updatelist()
        {
            dtb = kketnoi.laydata("select *,cast(0 as bit) as Chon from hoadon");
            hoadon_gridcontrol.DataSource = dtb;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            updatelist();
            laylookupedit();
            clear.Focus();
        }
        private void lammoi()
        {
            mahoadon_txt.Text = "";

           
            manv_txt.EditValue=null;
            manv_txt.ClosePopup();

            Ngay_txt.Text = "";

            makhachhang_txt.EditValue=null; 
            makhachhang_txt.ClosePopup();
            
            tongtg_txt.Text = "";
        }
        private void clear_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(mahoadon_txt.Text=="")
                    XtraMessageBox.Show("Vui lòng chọn hóa đơn");
                else
                    Suadl();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void Suadl()
        {
            if (XtraMessageBox.Show("Bạn có muốn Sửa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = " update hoadon set NGAY=@NGAY,MAKH=@MAKH,TONGTG=@TONGTG,MANV=@MANV where MAHD=@MAHD";
                kketnoi.ketnoiserver();
                SqlCommand comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MAHD", mahoadon_txt.Text);
                comd.Parameters.AddWithValue("@NGAY",Ngay_txt.Text);
                comd.Parameters.AddWithValue("@MAKH", makhachhang_txt.Text);
                comd.Parameters.AddWithValue("@TONGTG", tongtg_txt.Text);
                comd.Parameters.AddWithValue("@MANV", manv_txt.Text);
              
                comd.ExecuteNonQuery();

                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Sửa thành công!");
                lammoi();

            }
            else
            {
                manv_txt.Focus();    
            }
        }

        bool k;
        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                k = false;
                DataTable dt = hoadon_gridcontrol.DataSource as DataTable;
                if (dt == null) return;
                DataRow[] rows = dt.Select("Chon=true");
                if (rows.Count() > 0)
                    if (XtraMessageBox.Show("Bạn có muốn xóa các hóa đơn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (DataRow r in rows)
                        {
                            string ma = r["MAHD"].ToString();
                            xoadl(ma);
                        }
                if (k == true)
                {
                    updatelist();
                    XtraMessageBox.Show("Xóa thành công");
                    lammoi();
                }
            }
            catch (Exception )
            {
                XtraMessageBox.Show("Hóa đơn đã chọn tồn tại trong Chi tiết hóa đơn","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void xoadl(string ma)
        {

            string str = "delete from hoadon where MAHD=@MAHD";
            kketnoi.ketnoiserver();
            SqlCommand comd = new SqlCommand(str, kketnoi.connect);
            comd.Parameters.AddWithValue("@MAHD", ma);
            comd.ExecuteNonQuery();

            kketnoi.connect.Close();
            k = true;
        }
        

        public void GetValue(String str1)
        {
            mahoadon_txt.Text = str1;
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            TimKienHoaDon tim = new TimKienHoaDon();
            tim.mygetdata = new TimKienHoaDon.getsring(GetValue);
            tim.ShowDialog();
        }

        private void hoadon_gridview_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            mahoadon_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "MAHD").ToString();
            manv_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "MANV").ToString(); manv_txt.ClosePopup();
            Ngay_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "NGAY").ToString();
            makhachhang_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "MAKH").ToString(); makhachhang_txt.ClosePopup();
            tongtg_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "TONGTG").ToString();
        }
        private void laylookupedit()
        {
            dtb = kketnoi.laydata("select MANV,TENNV from nhanvien");
            manv_txt.Properties.DataSource = dtb;
            manv_txt.Properties.DisplayMember = "MANV";
            manv_txt.Properties.ValueMember = "MANV";

            dtb = kketnoi.laydata("select MAKH,TENKH from khachhang");
            makhachhang_txt.Properties.DataSource = dtb;
            makhachhang_txt.Properties.DisplayMember = "MAKH";
            makhachhang_txt.Properties.ValueMember = "MAKH";
        }

        private void Ngay_txt_Validated(object sender, EventArgs e)
        {
            if(Ngay_txt.Text!="")
                if (Convert.ToDateTime(Ngay_txt.Text) > DateTime.Now)
                {
                    XtraMessageBox.Show("Nhập sai ngày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Ngay_txt.Text = "";
                    Ngay_txt.Focus();
                }
        }

        private void mahoadon_txt_TextChanged(object sender, EventArgs e)
        {
            if (mahoadon_txt.Text != "")
            { 
                string sql="select * from hoadon where mahd='"+mahoadon_txt.Text+"'";
                DataTable dttb = new DataTable();
                dttb=kketnoi.laydata(sql);

                manv_txt.Text = dttb.Rows[0]["MANV"].ToString(); manv_txt.ClosePopup();
                Ngay_txt.Text = dttb.Rows[0]["NGAY"].ToString();
                makhachhang_txt.Text = dttb.Rows[0]["MAKH"].ToString(); makhachhang_txt.ClosePopup();
                tongtg_txt.Text = dttb.Rows[0]["TONGTG"].ToString();
            }
        }

        private void tongtg_txt_Validated(object sender, EventArgs e)
        {
            //if(tongtg_txt.Text.ToString().Length>0)
            //    if (Convert.ToDouble(tongtg_txt.Text) < 0)
            //    {
            //        XtraMessageBox.Show("Tổng trị giá không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        tongtg_txt.Focus();
            //    }
        }

        private void timkiem_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode.Equals(Keys.F))
                    timkiem_btn.PerformClick();
        }
          
           
    }      
}