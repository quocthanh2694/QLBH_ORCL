using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLBH.Formsss
{
    public partial class TimKiemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        
        
        public delegate void getstring(string s);
        public getstring mygetdata;
        private void Timkiem_Load(object sender, EventArgs e)
        {
            tim();
            
        }
        public void tim()
        {
            try
            {
                string str = "select MAKH,TENKH,NGAYSINH,DIACHI,DT,MAIL from khachhang where tenkh like '%" + tenkh_txt.Text + "%' and NGAYSINH like '%" + ngaysinh_txt.Text.Trim() + "%' and diachi like '%" + diachi_txt.Text+ "%' and dt like '%" +dienthoai_txt.Text + "%' and mail like '%" + mail_txt.Text + "%'";
                gridControl1.DataSource= kketnoi.laydata(str);
            }
            catch (Exception rex)
            {
               // MessageBox.Show(rex.ToString());
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)//Convert.ToInt16(gridView1.FocusedRowHandle) > -1)
            {
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
                if (mygetdata != null)
                    mygetdata(id);
                this.Close();
            }
            
        }
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            tim();
        }

        private void diachi_txt_KeyPress(object sender, KeyPressEventArgs e)
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
