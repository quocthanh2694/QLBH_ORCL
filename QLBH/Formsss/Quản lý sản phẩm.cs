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
using System.Data.OracleClient;

namespace QLBH.Formsss
{
    public partial class QuanLySanPhamFrom : DevExpress.XtraEditors.XtraForm
    {
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        SqlCommand comd ;
        int r=0;
        bool loi = false;
        public QuanLySanPhamFrom()
        {
            InitializeComponent();
        }

        private void QuanLySanPhamFrom_Load(object sender, EventArgs e)
        {
            updatelist();
            tenvt_txt.Focus();
        }
        private void updatelist()
        {
            dtb = kketnoi.laydata("select *  from sanpham");
            vattu_gridcontrol.DataSource = dtb;
         
        }
        public void lammoi()
        {
            tenvt_txt.Text="";
            mavt_txt.Text = "";
            dvt_lkp.Text = "";
            giamua_txt.Text = "";
            slton_txt.Text = "";
        }
      
        //Các hàm kiểm tra
        public int kiemtratrungten()
        {
            for (int i = 0; i < vattu_gridview.RowCount; i++)
            {
                if (dtb.Rows[i][1].ToString().ToUpper() == tenvt_txt.Text.ToUpper())// & dtb.Rows[i][0].ToString().ToUpper() != mavt_txt.Text.ToUpper())
                {
                    r = 1;
                    break;
                }
                else
                    r = 0;
            }
            return r;
        }
        public int ktt=0,kt = 0, kts = 0,ktdsp1=0;
        public int ktrten()
        {
            if (tenvt_txt.Text== "")
                ktt = 1;
            else
                ktt = 0;
            return ktt;
        }
        public int ktrgiamua()
        {
            if (giamua_txt.Text == "")
                kt = 1;
            else
                kt = 0;
            return kt;
        }
        public int ktrsl()
        {
            if (slton_txt.Text == "")
                kts = 1;
            else
                kts = 0;
            return kts;
        }
        public int ktdsp()
        {
            if (dvt_lkp.Text == "")
                ktdsp1 = 1;
            else 
                ktdsp1 = 0;
            return ktdsp1;
        }


        private void kiemtra()
        {
            loi = false;
            string thongbao = "";
            if (ktrten() == 1)
            {
                loi = true;
                thongbao =thongbao+ "Vui lòng nhập tên Vật tư! ";
            }

            if (kiemtratrungten() == 1) 
            {
                loi = true;
                thongbao =thongbao + "\n Vật tư này đã có! ";
            }
            if (ktdsp() == 1)
            {
                loi = true;
                thongbao = thongbao + "\n Vui lòng chọn đơn vị tính! ";
            }
            if (ktrgiamua() == 1)
            {
                loi = true;
                thongbao = thongbao + "\n Vui lòng nhập giá mua! "; 
            }
            if (ktrsl() == 1)
            {
                loi = true;
                thongbao = thongbao + "\n Vui lòng nhập số lượng tồn! "; 
            }
            if (loi == true)
            {
                XtraMessageBox.Show(thongbao, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                XtraMessageBox.Show("Không thể thêm dòng này" + ex.ToString());
            }

        }

        private void nhapdl()
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into sanpham values(:MAsp,:TENsp,:Dvt,:GIAMUA,:SLTON)";
                // Kiem tra Ma so
                bool kt = false;
                string num = "0";
                string count = kketnoi.laydata_dong("select count (masp) from sanpham");

                if (count.Trim() == "")
                    kt = true;
                else
                {
                    num = kketnoi.laydata_dong("select max( SUBSTR(masp,3,2))+1 from sanpham ");
                    kt = false;
                }

                kketnoi.ketnoiserver();
                // Thực hiện command
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                if (kt == true)
                {
                    comd.Parameters.Add(new OracleParameter("MAsp", "KH01"));
                }
                else
                {
                    comd.Parameters.Add(new OracleParameter("MAsp", "SP" + Convert.ToInt16(num).ToString("00")));
                }

                //comd = new SqlCommand(str, kketnoi.connect);
                //comd.Parameters.AddWithValue(":MAsp", "sp" + Convert.ToInt16((kketnoi.laydata_dong("if( select count (masp) from vattu )>0 select max( SUBSTRING(masp,3,2))+1 from vattu else select cast (1 as int)"))).ToString("00"));
                comd.Parameters.AddWithValue(":TENsp", tenvt_txt.Text.Trim());
                comd.Parameters.AddWithValue(":Dvt", dvt_lkp.Text.Trim());
                comd.Parameters.AddWithValue(":GIAMUA", Convert.ToDouble(giamua_txt.Text.Trim()));
                comd.Parameters.AddWithValue(":SLTON", Convert.ToDouble(slton_txt.Text.Trim()));
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Thêm thành công");
                lammoi();
            }
            else
                tenvt_txt.Focus();
        }

        bool ktsuasp;
        private void ktsuaspu()
        {
            ktsuasp = false;
            for (int i = 0; i < vattu_gridview.RowCount; i++)
            {
                if (dtb.Rows[i][1].ToString().ToUpper() == tenvt_txt.Text.ToUpper() & dtb.Rows[i][0].ToString().ToUpper() != mavt_txt.Text.ToUpper())
                {
                   ktsuasp=true;
                }
    
            }
            if (ktsuasp == true)
                XtraMessageBox.Show("Sản phẩm này đã có", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mavt_txt.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn sản phẩm!");
                }
                else
                {
                    ktsuaspu();
                    if(ktsuasp==false)
                        suadl();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể sửa dòng này" + ex.ToString());
            }
        }

        private void suadl()
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "update sanpham set TENsp=:TENsp,Dvt=:Dsp,GIAMUA=:GIAMUA,SLTON=:SLTON where MAsp=:MAsp";
                kketnoi.ketnoiserver();
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAsp", mavt_txt.Text);
                comd.Parameters.AddWithValue(":TENsp", tenvt_txt.Text);
                comd.Parameters.AddWithValue(":Dsp", dvt_lkp.Text.Trim());
                comd.Parameters.AddWithValue(":GIAMUA", Convert.ToDouble(giamua_txt.Text.Trim()));
                comd.Parameters.AddWithValue(":SLTON", Convert.ToDouble(slton_txt.Text.Trim()));
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Sửa thành công");

                lammoi();
            }
            else
            {
                tenvt_txt.Focus();
            }
        }
        bool k;
        private void xoa_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //k = false;
                //DataTable dt = vattu_gridcontrol.DataSource as DataTable;
                //if (dt == null) return;
                //DataRow[] rows = dt.Select("Chon=true");
                //if(rows.Count()>0)
                //    if (XtraMessageBox.Show("Bạn có muốn xóa những sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)        
                //        foreach (DataRow r in rows)
                //        {
                //            string masp = r["MAsp"].ToString();
                //            Xoadl(masp);
                //            k = true;
                //        }
                //if (k == true)
                //{
                //    updatelist();
                //    XtraMessageBox.Show("Đã xóa");
                //    lammoi();
                //}
                if (mavt_txt.Text.Trim() != "")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Xoadl(mavt_txt.Text.Trim());
                    }
                    updatelist();
                    lammoi();
                }
            }
            catch (Exception)// ex)
            {
                XtraMessageBox.Show("Sản phẩm đã chọn tồn tại trong danh sách hóa đơn","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);// + ex.ToString());
            }
        }

        private void Xoadl(string ma)
        {
                string str = "delete from sanpham where MAsp=:MAsp";
                kketnoi.ketnoiserver();
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAsp", ma);
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();

        }
        private void VatTu_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            mavt_txt.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "MASP").ToString().Trim();
            tenvt_txt.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "TENSP").ToString();
            dvt_lkp.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "DVT").ToString();
            giamua_txt.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "GIAMUA").ToString();
            slton_txt.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "SLTON").ToString();
            
            
        }
        private void kiemtragiamua(object sender, EventArgs e)
        {
            if (giamua_txt.Text.ToString().Length>0)
            //{
            //    XtraMessageBox.Show("Yêu cầu nhập giá mua!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    giamua_txt.Focus();
            //}
            //else 
            {
                if (Convert.ToDouble(giamua_txt.Text) < 0)
                {
                    XtraMessageBox.Show("Giá mua không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    giamua_txt.Text = "";
                    giamua_txt.Focus();
                }
            }    
        }
       
        private void kiemtraslton(object sender, EventArgs e)
        {
            if (slton_txt.Text.ToString().Length>0)
            {
                if (Convert.ToDouble(slton_txt.Text) < 0)
                {
                    XtraMessageBox.Show("Số lượng tồn không được âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slton_txt.Text = "";
                    slton_txt.Focus();
                }
            }
        }

        private void vattu_gridview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Xoa_btn.PerformClick();
        }

        public void GetValue(String str1)
        {
            mavt_txt.Text  = str1;
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            
            
            TimKiemSanPham tim = new TimKiemSanPham();
            tim.getdata = new TimKiemSanPham.Getstring(GetValue);
            tim.ShowDialog();
            
            
        }

        private void mavt_txt_TextChanged(object sender, EventArgs e)
        {
            if (mavt_txt.Text.Trim() != "")
            {
                string sql = "select * from sanpham where masp = '" + mavt_txt.Text + "'";
                DataTable dttb = kketnoi.laydata(sql);
                mavt_txt.Text = dttb.Rows[0]["MASP"].ToString();
                tenvt_txt.Text = dttb.Rows[0]["TENSP"].ToString();
                dvt_lkp.Text = dttb.Rows[0]["DVT"].ToString();
                giamua_txt.Text = dttb.Rows[0]["GIAMUA"].ToString();
                slton_txt.Text = dttb.Rows[0]["SLTON"].ToString();
            }

        }

        private void slton_txt_KeyDown(object sender, KeyEventArgs e)//kiemtra enter trong cac textbox
        {
            if (e.KeyCode == Keys.Enter)
                Them_btn.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void timkiem_btn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyCode.Equals(Keys.F))
                    timkiem_btn.PerformClick();
        }

    }
}