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
    public partial class QLLoai : DevExpress.XtraEditors.XtraForm
    {
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        SqlCommand comd ;
        int r=0;
        bool loi = false;
        public QLLoai()
        {
            InitializeComponent();
        }

        private void QuanLySanPhamFrom_Load(object sender, EventArgs e)
        {
            updatelist();
            txtTenLoai.Focus();
        }
        private void updatelist()
        {
            dtb = kketnoi.laydata("select *  from loaisp");
            vattu_gridcontrol.DataSource = dtb;
         
        }
        public void lammoi()
        {
            txtTenLoai.Text="";
            txtmaloai.Text = "";
            
        }
      
        //Các hàm kiểm tra
        public int kiemtratrungten()
        {
            for (int i = 0; i < vattu_gridview.RowCount; i++)
            {
                if (dtb.Rows[i][1].ToString().ToUpper() == txtTenLoai.Text.ToUpper())// & dtb.Rows[i][0].ToString().ToUpper() != mavt_txt.Text.ToUpper())
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
       


        private void kiemtra()
        {
            loi = false;
            string thongbao = "";
            if (txtTenLoai.Text=="")
            {
                loi = true;
                thongbao =thongbao+ "Vui lòng nhập tên loại! ";
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
            if (XtraMessageBox.Show("Bạn có muốn thêm loại sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "insert into loaisp values(:MAkv,:TENkv)";
                // Kiem tra Ma so
                bool kt = false;
                string num = "0";
                string count = kketnoi.laydata_dong("select count (maloai) from loaisp");

                if (count.Trim() == "")
                    kt = true;
                else
                {
                    num = kketnoi.laydata_dong("select max( SUBSTR(maloai,3,2))+1 from loaisp ");
                    kt = false;
                }

                kketnoi.ketnoiserver();
                // Thực hiện command
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                if (kt == true)
                {
                    comd.Parameters.Add(new OracleParameter("MAkv", "L01"));
                }
                else
                {
                    comd.Parameters.Add(new OracleParameter("MAkv", "L" + Convert.ToInt16(num).ToString("00")));
                }

                //comd = new SqlCommand(str, kketnoi.connect);
                //comd.Parameters.AddWithValue(":MAsp", "sp" + Convert.ToInt16((kketnoi.laydata_dong("if( select count (masp) from vattu )>0 select max( SUBSTRING(masp,3,2))+1 from vattu else select cast (1 as int)"))).ToString("00"));
                comd.Parameters.AddWithValue(":TENkv", txtTenLoai.Text.Trim());
                
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Thêm thành công");
                lammoi();
            }
            else
                txtTenLoai.Focus();
        }

        bool ktsuasp;
        private void ktsuaspu()
        {
            //ktsuasp = false;
            //for (int i = 0; i < vattu_gridview.RowCount; i++)
            //{
            //    if (dtb.Rows[i][1].ToString().ToUpper() == txtTenKV.Text.ToUpper() & dtb.Rows[i][0].ToString().ToUpper() != txtmaKV.Text.ToUpper())
            //    {
            //       ktsuasp=true;
            //    }
    
            //}
            //if (ktsuasp == true)
            //    XtraMessageBox.Show("Sản phẩm này đã có", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void sua_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmaloai.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn Loại sản phẩm!");
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
            if (XtraMessageBox.Show("Bạn có muốn sửa loại sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string str = "update loaisp set tenloai=:tenkv where maloai=:makv";
                kketnoi.ketnoiserver();
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAkv", txtmaloai.Text);
                comd.Parameters.AddWithValue(":TENkv", txtTenLoai.Text);
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();
                updatelist();
                XtraMessageBox.Show("Sửa thành công");

                lammoi();
            }
            else
            {
                txtTenLoai.Focus();
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
                if (txtmaloai.Text.Trim() != "")
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa loại sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Xoadl(txtmaloai.Text.Trim());
                    }
                    updatelist();
                    lammoi();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(),"lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);// + ex.ToString());
            }
        }

        private void Xoadl(string ma)
        {
                string str = "delete from loaisp where MAloai=:MAkv";
                kketnoi.ketnoiserver();
                OracleCommand comd = new OracleCommand(str, kketnoi.connect);
                comd.Parameters.AddWithValue(":MAkv", ma);
                comd.ExecuteNonQuery();
                kketnoi.connect.Close();

        }
        private void VatTu_gridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtmaloai.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "MALOAI").ToString().Trim();
            txtTenLoai.Text = vattu_gridview.GetRowCellValue(e.RowHandle, "TENLOAI").ToString();
            
            
        }
        private void kiemtragiamua(object sender, EventArgs e)
        {
           
        }
       
        private void kiemtraslton(object sender, EventArgs e)
        {
           
        }

        private void vattu_gridview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Xoa_btn.PerformClick();
        }

        public void GetValue(String str1)
        {
            txtmaloai.Text  = str1;
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            
            
            TimKiemSanPham tim = new TimKiemSanPham();
            tim.getdata = new TimKiemSanPham.Getstring(GetValue);
            tim.ShowDialog();
            
            
        }

        private void mavt_txt_TextChanged(object sender, EventArgs e)
        {
            if (txtmaloai.Text.Trim() != "")
            {
                string sql = "select * from loaisp where maloai = '" + txtmaloai.Text + "'";
                DataTable dttb = kketnoi.laydata(sql);
                txtmaloai.Text = dttb.Rows[0]["MAloai"].ToString();
                txtTenLoai.Text = dttb.Rows[0]["TENloai"].ToString();
              
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
            //if (e.Control)
            //    if (e.KeyCode.Equals(Keys.F))
            //        timkiem_btn.PerformClick();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

    }
}