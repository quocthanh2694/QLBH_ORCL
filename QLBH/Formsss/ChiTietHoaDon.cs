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
    public partial class ChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        DataTable dtb = new DataTable();
        ketnoi kketnoi = new ketnoi();
        SqlCommand comd = new SqlCommand();

        private void clear_Click(object sender, EventArgs e)
        {
            mahd_txt.EditValue = null;
            mahd_txt.ClosePopup();
            lammoi();
            clear.Focus();
            updatelist();
        }

        private void lammoi()
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

        private void updatelist()
        {
            dtb = kketnoi.laydata("select STT,MAHD,c.MAVT,TENVT,SL,KHUYENMAI=case when KHUYENMAI =0.1  then '10' when KHUYENMAI=0.05 then '5' else 0 end,GIABAN,cast(0 as bit) as Chon from cthd c,vattu v where c.mavt=v.mavt");
            chitiethd_gridcontrol.DataSource = dtb;
        }
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            laymahd_mavt();
            updatelist();
            clear.Focus();
        }
        private void laymahd_mavt()
        {
            DataTable dttb= new DataTable();
            dttb=kketnoi.laydata("select MAHD,MAKH,MANV from hoadon");
            mahd_txt.Properties.DataSource = dttb;
            mahd_txt.Properties.ValueMember = "MAHD";
            mahd_txt.Properties.DisplayMember = "MAHD";

            dttb = kketnoi.laydata("select MAVT,TENVT from Vattu");
            mavt_txt.Properties.DataSource = dttb;
            mavt_txt.Properties.ValueMember = "MAVT";
            mavt_txt.Properties.DisplayMember = "MAVT";
        }

        public bool loi;
        private void kiemtra()
        {
            loi = false;
            string thongbao = "";
            if (mahd_txt.Text == "")
            {
                loi = true;
                thongbao = "Vui lòng chọn mã hóa đơn";
            }
            if (mavt_txt.Text == "")
            {
                loi = true;
                thongbao += "\nVui lòng chọn mã sản phẩm";
            }
            if (soluong_txt.Text == "")
            {
                loi = true;
                thongbao += "\nVui lòng nhập số lượng";
            }
            if (giaban_txt.Text == "")
                giaban_txt.Text = "0";
            //kiem tra trung mahd va mavt khi thêm
            for (int i = 0; i < chitiethd_gridview.RowCount; i++)
            {
                if (dtb.Rows[i]["MAHD"].ToString().ToUpper() == mahd_txt.Text.ToUpper() && dtb.Rows[i]["MAVT"].ToString().ToUpper() == mavt_txt.Text.ToUpper())
                {
                    loi = true;
                    thongbao += "\nHóa đơn và sản phẩm đã tồn tại";
                }
            }
            //kiem tra so luong lon hon so luong trong kho khi them

            if (soluong_txt.Text != "" && soluong_txt.Text != "0.")
            {
                string str = "select sum(sl) from cthd where mavt ='" + mavt_txt.Text + "'";
                double tongsl = Convert.ToDouble(kketnoi.laydata_dong(str)) + Convert.ToDouble(soluong_txt.Text);

                string str2 = "select slton from vattu where mavt='" + mavt_txt.Text + "'";
                double tongslton = Convert.ToDouble(kketnoi.laydata_dong(str2));
                if (tongsl > tongslton)
                {
                    loi = true;
                    thongbao += "Số lượng sản phẩm không được lớn hơn số lượng trong kho";
                    soluong_txt.Text = "";
                    soluong_txt.Focus();
                }
            }


            if (loi == true)
            {
                XtraMessageBox.Show(thongbao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      

        private void Them_btn_Click(object sender, EventArgs e)
        {
            try
            {
                kiemtra();
                
                if (loi == false)
                    nhapdl();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void nhapdl()
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm dòng dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into cthd values(@MAHD,@MAVT,@SL,@KHUYENMAI,@GIABAN,@STT)";
                kketnoi.ketnoiserver();
                comd = new SqlCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue("@MAHD", mahd_txt.Text);
                comd.Parameters.AddWithValue("@MAVT", mavt_txt.Text);
                comd.Parameters.AddWithValue("@SL", Convert.ToDouble(soluong_txt.Text));
                comd.Parameters.AddWithValue("@KHUYENMAI",0);
                comd.Parameters.AddWithValue("@GIABAN", Convert.ToDouble(giaban_txt.Text));
                comd.Parameters.AddWithValue("@STT", kketnoi.laydata_dong("if  (select count(stt) from cthd)>0 select max(STT)+1 from cthd else  select CAST ( 1 as int) "));
                comd.ExecuteNonQuery();

                kketnoi.connect.Close();
                //updatelist();
                XtraMessageBox.Show("Thêm thành công");
               // lammoi();
                update1();
                lammoi();
            }  
        }
        //kiem tra trung khi sua
         bool ktsua;
        private void ktsuacthd()
        {
            string thongbao = "";
            //kiem tra trung
            ktsua = false;
            for (int i = 0; i < chitiethd_gridview.RowCount; i++)
            {
                if (dtb.Rows[i]["MAHD"].ToString().ToUpper() == mahd_txt.Text.ToUpper() && dtb.Rows[i]["MAVT"].ToString().ToUpper() == mavt_txt.Text.ToUpper() && dtb.Rows[i]["STT"].ToString().ToUpper() != stt_txt.Text.ToUpper())
                {
                    ktsua = true;
                    thongbao += "Hóa đơn và sản phẩm đã có";
                }
            }
            

            //kiem tra so luong khong dc lon hon sl trong kho khi sua
            if (soluong_txt.Text != "" && soluong_txt.Text != "0.")
            {
                string str = "select sum(sl) from cthd where mavt ='" + mavt_txt.Text + "'";
                double tongsl = Convert.ToDouble(kketnoi.laydata_dong(str)) +Convert.ToDouble(soluong_txt.Text);

                string str1 = "select sl from cthd where stt='"+stt_txt.Text+"'";
                double tongslhd = Convert.ToDouble(kketnoi.laydata_dong(str1));

                string str2 = "select slton from vattu where mavt='" + mavt_txt.Text + "'";
                double tongslton = Convert.ToDouble(kketnoi.laydata_dong(str2));
                if (tongsl-tongslhd > tongslton)
                {
                    ktsua = true;
                    thongbao += "Số lượng sản phẩm không được lớn hơn số lượng trong kho";
                    soluong_txt.Text = "";
                    soluong_txt.Focus();
                }
            }

            if (ktsua == true)
                XtraMessageBox.Show(thongbao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        private void Sua_btn_Click(object sender, EventArgs e)
        {
            if (stt_txt.Text == "")
            {
             
                XtraMessageBox.Show("Vui lòng chọn hóa đơn");

            }
            else
            {
                ktsuacthd();
                if (ktsua == false)
                    suadl();
            }
        }

        private void suadl()
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn Sửa chi tiết hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string str = " update cthd set MAHD=@MAHD,MAVT=@MAVT,SL=@SL,KHUYENMAI=@KHUYENMAI,GIABAN=@GIABAN where STT=@STT";
                    kketnoi.ketnoiserver();
                    SqlCommand comd = new SqlCommand(str, kketnoi.connect);
                    comd.Parameters.AddWithValue("@MAHD", mahd_txt.Text);
                    comd.Parameters.AddWithValue("MAVT", mavt_txt.Text);
                    comd.Parameters.AddWithValue("@SL", Convert.ToDouble(soluong_txt.Text));
                    comd.Parameters.AddWithValue("@KHUYENMAI", 0);
                    comd.Parameters.AddWithValue("@GIABAN", Convert.ToDouble(giaban_txt.Text));
                    comd.Parameters.AddWithValue("@STT", stt_txt.Text);

                    comd.ExecuteNonQuery();

                    kketnoi.connect.Close();
                    //updatelist();
                    XtraMessageBox.Show("Sửa thành công!");
                    
                    update1();lammoi();
                }
                else
                {
                    soluong_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        bool k;
        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                k = false;
                DataTable dt = chitiethd_gridcontrol.DataSource as DataTable;
                if (dt == null) return;
                DataRow[] rows = dt.Select("Chon=true");
                if (rows.Count() > 0)
                    if (XtraMessageBox.Show("Bạn có muốn xóa các hóa đơn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (DataRow r in rows)
                        {
                            string ma = r["STT"].ToString();
                            xoadl(ma);
                        }
                if (k == true)
                {
                    //updatelist();
                    XtraMessageBox.Show("Xóa thành công");
                    
                    update1();lammoi();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void xoadl(string ma)
        {
            string str = "delete from cthd where STT=@STT";
            kketnoi.ketnoiserver();
            SqlCommand comd = new SqlCommand(str, kketnoi.connect);
            comd.Parameters.AddWithValue("@STT", ma);
            comd.ExecuteNonQuery();
            kketnoi.connect.Close();
            k = true;
        }
        public void GetValue(String str1)
        {
            stt_txt.Text = str1;
            
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            TimKiemCTHD tim = new TimKiemCTHD();
            tim.mygetdata = new TimKiemCTHD.getsring(GetValue);
            tim.ShowDialog();
        }

        private void chitiethd_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                mahd_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "MAHD").ToString(); mahd_txt.ClosePopup();
                mavt_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "MAVT").ToString(); mavt_txt.ClosePopup();
                soluong_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "SL").ToString();
                khuyenmai_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "KHUYENMAI").ToString();
                giaban_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "GIABAN").ToString();
                stt_txt.Text = chitiethd_gridview.GetRowCellValue(e.RowHandle, "STT").ToString();
            }
            catch(Exception){}
        }

        private void soluong_txt_Validated(object sender, EventArgs e)
        {
            try
            {
                if (soluong_txt.Text.ToString().Length > 0)
                    if (Convert.ToDouble(soluong_txt.Text) < 0)
                    {
                        XtraMessageBox.Show("Số lượng không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        soluong_txt.Text = "";
                        soluong_txt.Focus();
                    }
                //sl khong dc lon hon sl ton:::::   | Convert.ToInt16(soluong_txt.Text)==0
               
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.ToString()); }
        }
       
        private void khuyenmai_txt_Validated(object sender, EventArgs e)
        {
            if(khuyenmai_txt.Text.ToString().Length>0)
                if (Convert.ToDouble(khuyenmai_txt.Text) < 0)
                {
                    XtraMessageBox.Show("Khuyến mãi không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    khuyenmai_txt.Text = "";
                   khuyenmai_txt.Focus();
                }      
        }

        private void giaban_txt_Validated(object sender, EventArgs e)
        {
            if (giaban_txt.Text.ToString().Length > 0)
                if (Convert.ToDouble(giaban_txt.Text) < 0)
                {
                    XtraMessageBox.Show("Giá bán không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    giaban_txt.Text = "";
                    giaban_txt.Focus();
                }
        }

        private void timkiem_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode.Equals(Keys.F))
                    timkiem_btn.PerformClick();
            
        }

        private void stt_txt_TextChanged(object sender, EventArgs e)
        {
            
            if (stt_txt.Text != "")
            {
                string sql = "select MAHD,MAVT,SL,KHUYENMAI,GIABAN from cthd where stt='" + stt_txt.Text + "'";
                DataTable dttb = new DataTable();
                dttb = kketnoi.laydata(sql);

                mahd_txt.Text = dttb.Rows[0]["MAHD"].ToString(); mahd_txt.ClosePopup();
                mavt_txt.Text = dttb.Rows[0]["MAVT"].ToString(); mavt_txt.ClosePopup();
                soluong_txt.Text = dttb.Rows[0]["SL"].ToString(); 
                khuyenmai_txt.Text = dttb.Rows[0]["KHUYENMAI"].ToString();
                giaban_txt.Text = dttb.Rows[0]["GIABAN"].ToString();
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mavt_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aaaaa(object sender, EventArgs e)
        {
            try
            {
                giaban_txt.Text = kketnoi.laydata_dong("select GIAMUA from vattu where mavt='" + mavt_txt.Text + "'");
            }
            catch (Exception) { }
        }

        private void asas(object sender, EventArgs e)
        {
            update1();
        }

        private void update1()
        {
            try
            {
                chitiethd_gridcontrol.DataSource = kketnoi.laydata("select STT,MAHD,c.MAVT,TENVT,SL,KHUYENMAI=case when KHUYENMAI =0.1  then '10' when KHUYENMAI=0.05 then '5' else 0 end,GIABAN,cast(0 as bit) as Chon from cthd c,vattu v where c.mavt=v.mavt and mahd='" + mahd_txt.Text + "'");
            }
            catch (Exception) { }
        }
    }
}

