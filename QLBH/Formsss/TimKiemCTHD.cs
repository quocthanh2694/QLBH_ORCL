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
    public partial class TimKiemCTHD : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemCTHD()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        public delegate void getsring(string s);
        public getsring mygetdata;
        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            tim();
        }
        private void tim()
        {
            try
            {
                string sql = "select STT,MAHD,MAVT,SL,KHUYENMAI=case when KHUYENMAI =0.1  then '10' when KHUYENMAI=0.05 then '5' else 0 end,GIABAN from cthd where MAHD like N'%" + mahd_txt.Text.ToString() + "%' and MAVT like N'%" + mavt_txt.Text.ToString() + "%' and sl like '%" + soluong_txt.Text.ToString() + "%' and KHUYENMAI like N'%" + t.ToString() + "%' and GIABAN like '%" + giaban_txt.Text.ToString() + "%' ";
                chitiethd_gridcontrol.DataSource = kketnoi.laydata(sql);

            }
            catch (Exception )
            {
               
            }
        }
        private void chitiethd_gridview_DoubleClick(object sender, EventArgs e)
        {
            if (chitiethd_gridview.RowCount>0)//Convert.ToInt16(chitiethd_gridview.FocusedRowHandle) > -1)
            {
                string id = chitiethd_gridview.GetRowCellValue(chitiethd_gridview.FocusedRowHandle, "STT").ToString();
                if (mygetdata != null)
                    mygetdata(id);
                this.Close();
            }
            
        }

        double t;
        private void khuyenmai_txt_EditValueChanged(object sender, EventArgs e)
        {
            t = 0;
            if (khuyenmai_txt.Text == "5%")
                t = 0.05;
            else
                if (khuyenmai_txt.Text == "10%")
                    t = 0.1;
            

        }

        private void TimKiemCTHD_Load(object sender, EventArgs e)
        {
            tim();
        }

        private void giaban_txt_TextChanged(object sender, EventArgs e)
        {
            tim();
        }
    }
}