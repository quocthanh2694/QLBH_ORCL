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
using System.Data.OracleClient;
using System.IO;

namespace QLBH.Formsss
{
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        OracleCommand comd = new OracleCommand();
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
            //if (manv_txt.Text == "")
            //    manv = 1;
            //else
            //    manv = 0;
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
            //if (manv == 1)
            //{
            //    loi = true;
            //    thongbao = "Vui lòng chọn mã nhân viên";
            //}
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
        bool loicthd=false;
        private void kiemtraCTHD()
        {
            loicthd = false;
            string thongbao = "";
            if (mahoadon_txt.Text == "")
            {
                loicthd = true;
                thongbao = "Vui lòng chọn hóa đơn";
            }
            if (mavt_txt.Text == "")
            {
                loicthd = true;
                thongbao += "\nVui lòng chọn mã sản phẩm";
            }
            if (soluong_txt.Text == "")
            {
                loicthd = true;
                thongbao += "\nVui lòng nhập số lượng";
            }
           
            if (giaban_txt.Text == "")
                giaban_txt.Text = "0";
            //kiem tra trung mahd va mavt khi thêm
            for (int i = 0; i < chitiethd_gridview.RowCount; i++)
            {
                if (dtb.Rows[i]["MAHD"].ToString().ToUpper() == mahoadon_txt.Text.ToUpper() && dtb.Rows[i]["MASP"].ToString().ToUpper() == mavt_txt.EditValue.ToString().ToUpper())
                {
                    loicthd = true;
                    thongbao += "\nSản phẩm này đã có!";
                }
            }
            //kiem tra so luong lon hon so luong trong kho khi them

            //if (soluong_txt.Text != "" && soluong_txt.Text != "0.")
            //{
            //    string str = "select sum(sl) from cthd where masp ='" + mavt_txt.Text + "'";
            //    double tongsl = Convert.ToDouble(kketnoi.laydata_dong(str)) + Convert.ToDouble(soluong_txt.Text);

            //    string str2 = "select slton from sanpham where masp='" + mavt_txt.Text + "'";
            //    double tongslton = Convert.ToDouble(kketnoi.laydata_dong(str2));
            //    if (tongsl > tongslton)
            //    {
            //        loicthd = true;
            //        thongbao += "Số lượng sản phẩm không được lớn hơn số lượng trong kho";
            //        soluong_txt.Text = "";
            //        soluong_txt.Focus();
            //    }
            //}


            if (loicthd == true)
            {
                XtraMessageBox.Show(thongbao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                string str = "insert into hoadon values(:MAHD,:NGAY,:MAKH,:TONGTG,:MANV)";
                // Kiem tra Ma so
                bool kt = false;
                string num = "0";
                string count = kketnoi.laydata_dong("select count (mahd) from hoadon");

                if (count.Trim() == "")
                    kt = true;
                else
                {
                    num = kketnoi.laydata_dong("select max( SUBSTR(mahd,3,3))+1 from hoadon ");
                    kt = false;
                }

                kketnoi.ketnoiserver();
                // Thực hiện command
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                if (kt == true)
                {
                    comd.Parameters.Add(new OracleParameter("MAHD", "HD001"));
                }
                else
                {
                    comd.Parameters.Add(new OracleParameter("MAHD", "HD" + Convert.ToInt16(num).ToString("000")));
                }

                // Lấy mã nhân viên
                string file = Application.StartupPath + "\\nas.txt";
                StreamReader red = new StreamReader(file);
                string s = red.ReadLine();
                //
                string manv = kketnoi.laydata_dong("select n.manv from nhanvien n, taikhoan d where n.manv=d.MANV and username='"+s.Trim().ToLower()+"' ");
                red.Close();

                //comd = new SqlCommand(str, kketnoi.connect);
                //comd.Parameters.AddWithValue(":MAHD", "HD" + Convert.ToInt16((kketnoi.laydata_dong("if( select count(mahd) from hoadon)>0 select max( SUBSTRING(mahd,3,3))+1 from hoadon else select CAST ( 1 as int )"))).ToString("000"));
                comd.Parameters.AddWithValue(":NGAY", Convert.ToDateTime(Ngay_txt.Text));
                comd.Parameters.AddWithValue(":MAKH", makhachhang_txt.Text);
                comd.Parameters.AddWithValue(":TONGTG", 0);
                comd.Parameters.AddWithValue(":MANV", manv);

                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Thêm thành công");
                lammoi();
            }
            else { }
               // manv_txt.Focus();
        }
        private void updatelistCTHD()
        {
            dtb = kketnoi.laydata("select STT,MAHD,c.MAsp,TENsp,SL,case when KHUYENMAI =0.1  then 10 when KHUYENMAI=0.05 then 5 else 0 end as KhuyenMai,GIABAN from cthd c,sanpham v where c.masp=v.masp and mahd='"+mahoadon_txt.Text.Trim()+"'");
            chitiethd_gridcontrol.DataSource = dtb;
        }
        private void updatelist()
        {
            dtb = kketnoi.laydata("select * from hoadon");
            hoadon_gridcontrol.DataSource = dtb;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            updatelist();
            laylookupedit();
            clear.Focus();
        }
        private void lammoiCTHD()
        {
            //mahd_txt.EditValue = null;
            //mahd_txt.ClosePopup();

            mavt_txt.EditValue = null;
            mavt_txt.ClosePopup();

            soluong_txt.Text = "";
            khuyenmai_txt.Text = "";
            giaban_txt.Text = "";
            stt_txt.Text = "";
        }
        private void lammoi()
        {
            mahoadon_txt.Text = "";

           
            //manv_txt.EditValue=null;
            //manv_txt.ClosePopup();

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
                string str = " update hoadon set NGAY=:NGAY,MAKH=:MAKH,TONGTG=:TONGTG where MAHD=:MAHD";
                kketnoi.ketnoiserver();
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAHD", mahoadon_txt.Text);
                comd.Parameters.AddWithValue(":NGAY", Convert.ToDateTime(Ngay_txt.Text));
                comd.Parameters.AddWithValue(":MAKH", makhachhang_txt.Text);
                comd.Parameters.AddWithValue(":TONGTG", tongtg_txt.Text);
                //comd.Parameters.AddWithValue(":MANV", manv_txt.Text);
              
                comd.ExecuteNonQuery();

                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Sửa thành công!");
                lammoi();

            }
            else
            {
               // manv_txt.Focus();    
            }
        }

        bool k;
        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //k = false;
                //DataTable dt = hoadon_gridcontrol.DataSource as DataTable;
                //if (dt == null) return;
                //DataRow[] rows = dt.Select("Chon=true");
                //if (rows.Count() > 0)
                //    if (XtraMessageBox.Show("Bạn có muốn xóa các hóa đơn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //        foreach (DataRow r in rows)
                //        {
                //            string ma = r["MAHD"].ToString();
                //            xoadl(ma);
                //        }
                //if (k == true)
                //{
                //    updatelist();
                //    XtraMessageBox.Show("Xóa thành công");
                //    lammoi();
                //}
                if (mahoadon_txt.Text.Trim() != "")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa hóa đơn này này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        xoadl(mahoadon_txt.Text.Trim());
                    }
                    updatelist();
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

            string str = "delete from hoadon where MAHD=:MAHD";
            kketnoi.ketnoiserver();
            OracleCommand comd = new OracleCommand(str, kketnoi.connect);
            comd.Parameters.AddWithValue(":MAHD", ma);
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
           // manv_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "MANV").ToString(); manv_txt.ClosePopup();
            Ngay_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "NGAY").ToString();
            makhachhang_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "MAKH").ToString(); makhachhang_txt.ClosePopup();
            tongtg_txt.Text = hoadon_gridview.GetRowCellValue(e.RowHandle, "TONGTG").ToString();
        }
        private void laylookupedit()
        {
            //dtb = kketnoi.laydata("select MANV,TENNV from nhanvien");
            //manv_txt.Properties.DataSource = dtb;
            //manv_txt.Properties.DisplayMember = "MANV";
            //manv_txt.Properties.ValueMember = "MANV";

            dtb = kketnoi.laydata("select MAKH,TENKH from khachhang");
            makhachhang_txt.Properties.DataSource = dtb;
            makhachhang_txt.Properties.DisplayMember = "MAKH";
            makhachhang_txt.Properties.ValueMember = "MAKH";

            DataTable dttb = new DataTable();
            dttb = kketnoi.laydata("select MASP,TENSP from sanpham");
            mavt_txt.Properties.DataSource = dttb;
            mavt_txt.Properties.ValueMember = "MASP";
            mavt_txt.Properties.DisplayMember = "TENSP";
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

            //    manv_txt.Text = dttb.Rows[0]["MANV"].ToString(); manv_txt.ClosePopup();
                Ngay_txt.Text = dttb.Rows[0]["NGAY"].ToString();
                makhachhang_txt.Text = dttb.Rows[0]["MAKH"].ToString(); makhachhang_txt.ClosePopup();
                tongtg_txt.Text = dttb.Rows[0]["TONGTG"].ToString();
            }
            lammoiCTHD();
            updatelistCTHD();
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
            //if (e.Control)
            //    if (e.KeyCode.Equals(Keys.F))
            //        timkiem_btn.PerformClick();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtraCTHD();

                if (loicthd == false)
                    nhapdlCTHD();
                CapNhatKhuyenMai_TongTG();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void nhapdlCTHD()
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm dòng dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string stt=kketnoi.laydata_dong("select max(STT)+1 from cthd");
                string str = "insert into cthd values(:MAHD,:MASP,:SL,:KHUYENMAI,:GIABAN,:STT)";
                kketnoi.ketnoiserver();
                comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAHD", mahoadon_txt.Text);
                comd.Parameters.AddWithValue(":MASP", mavt_txt.EditValue);
                comd.Parameters.AddWithValue(":SL", Convert.ToDouble(soluong_txt.Text));
                comd.Parameters.AddWithValue(":KHUYENMAI", 0);
                comd.Parameters.AddWithValue(":GIABAN", Convert.ToDouble(giaban_txt.Text));
                comd.Parameters.AddWithValue(":STT", stt);
                comd.ExecuteNonQuery();

                kketnoi.connect.Close();
                //updatelist();
                XtraMessageBox.Show("Thêm thành công");
                // lammoi();
                updatelistCTHD();
                lammoiCTHD();
            }
        }
        private void chitiethd_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

               
                soluong_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "SL").ToString();
                string s = chitiethd_gridview.GetRowCellValue(e.RowHandle, "MASP").ToString();
                mavt_txt.EditValue = s;
                mavt_txt.ClosePopup();
                khuyenmai_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "KHUYENMAI").ToString();
                giaban_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "GIABAN").ToString();
                stt_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "STT").ToString();
            }
            catch (Exception) { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (stt_txt.Text == "")
            {

                XtraMessageBox.Show("Vui lòng chọn 1 dòng");

            }
            else
            {
                //kiemtraCTHD();
                //if (loicthd == false)
                    suadlCTHD();
                    CapNhatKhuyenMai_TongTG();
            }
        }
        private void suadlCTHD()
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn Sửa dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string str = " update cthd set MASP=:MAVT,SL=:SL,KHUYENMAI=:KHUYENMAI,GIABAN=:GIABAN where STT=:STT";
                    kketnoi.ketnoiserver();
                    OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                    //comd.Parameters.AddWithValue(":MAHD", mahoadon_txt.Text);
                    comd.Parameters.AddWithValue(":MAVT", mavt_txt.EditValue);
                    comd.Parameters.AddWithValue(":SL", Convert.ToDouble(soluong_txt.Text));
                    comd.Parameters.AddWithValue(":KHUYENMAI", 0);
                    comd.Parameters.AddWithValue(":GIABAN", Convert.ToDouble(giaban_txt.Text));
                    comd.Parameters.AddWithValue(":STT", stt_txt.Text);

                    comd.ExecuteNonQuery();

                    kketnoi.connect.Close();
                    //updatelist();
                    XtraMessageBox.Show("Sửa thành công!");

                    updatelistCTHD(); lammoiCTHD();
                }
                else
                {
                    soluong_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Sản phẩm này đã có!");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (stt_txt.Text.Trim() != "")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        XoadlCTHD(stt_txt.Text);
                        CapNhatKhuyenMai_TongTG();
                    }
                    updatelistCTHD();
                    lammoiCTHD();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa!");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());// + ex.ToString());
            }
        }
        private void XoadlCTHD(string ma)
        {
            string str = "delete from cthd where stt=:MAsp";
            kketnoi.ketnoiserver();
            OracleCommand comd = new OracleCommand(str, kketnoi.connect);
            comd.Parameters.AddWithValue(":MAsp", ma);
            comd.ExecuteNonQuery();
            kketnoi.connect.Close();

        }
        public void CapNhatKhuyenMai_TongTG()
        {
            // Khuyen mai
            kketnoi.ketnoiserver();
            OracleCommand cmd = new OracleCommand("UpdateKhuyenMai_CTHD",kketnoi.connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("x", OracleType.Int32).Value = "1";
            cmd.ExecuteNonQuery();

            // TongTG
            OracleCommand cmd1 = new OracleCommand("tinhTongTG", kketnoi.connect);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("x", OracleType.Int32).Value = "1";
            cmd1.ExecuteNonQuery();

            updatelist();
            updatelistCTHD();
        }

        private void mavt_txt_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(mavt_txt.EditValue.ToString());
            try
            {
                giaban_txt.Text = kketnoi.laydata_dong("select GIAMUA from sanpham where masp='" + mavt_txt.EditValue.ToString() + "'");
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lammoiCTHD();
        }
           
    }      
}