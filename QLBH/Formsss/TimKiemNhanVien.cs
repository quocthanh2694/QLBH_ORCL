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

namespace QLBH.Formsss
{
    public partial class TimKiemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        public delegate void Getstring(string s);
        public Getstring getdata;

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            tim();
        }
        private void tim()
        {
            try
            {
                string sql = "select MANV,TENNV,DIACHI,DT,CHUCVU,LUONG from nhanvien where MANV like '%"+manv_txt.Text+"%' and TENNV like N'%" + tennv_txt.Text + "%' and diachi like N'%" + diachi_txt.Text + "%' and DT like '%" + dienthoai_txt.Text + "%' and chucvu like '%"+chucvu_txt.Text+"%' and luong like '%"+Luong_txt.Text+"%'";
                nhanvien_gridcontrol.DataSource = kketnoi.laydata(sql);                
            }
            catch (Exception )
            {
            }
        }

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            tim();
        }

        private void nhanvien_gridview_DoubleClick(object sender, EventArgs e)
        {
            if (nhanvien_gridview.RowCount>0)//Convert.ToInt16(nhanvien_gridview.FocusedRowHandle) > -1)
            {
                string id = nhanvien_gridview.GetRowCellValue(nhanvien_gridview.FocusedRowHandle, "MANV").ToString();
                if (getdata != null)
                {
                    getdata(id);
                }
                this.Close();
            }
            
        }

        private void dienthoai_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))// | e.KeyChar==45)
            {
                e.Handled = true;
            }
        }

        private void dienthoai_txt_TextChanged(object sender, EventArgs e)
        {
            tim();
        }
    }
}