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
    public partial class TimKienHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public TimKienHoaDon()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        public delegate void getsring(string s);
        public getsring mygetdata;
        private void makh_txt_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void TimKienHoaDon_Load(object sender, EventArgs e)
        {
            tim();

        }
        
        private void tim()
        {
            try
            {
                string sql = "select MAHD,NGAY,MAKH,TONGTG,MANV from hoadon where  convert(varchar(20),NGAY,103) like '%"+ngay_txt.Text+"%' and MAKH like '%"+makh_txt.Text+"%' and TONGTG like '%"+tongtg_txt.Text+"%' and MANV like '%"+manv_txt.Text+"%'";
                hoadon_gridcontrol.DataSource = kketnoi.laydata(sql);
            
            }
            catch (Exception )
            {
               
            }
        }
       
        private void hoadon_gridview_DoubleClick(object sender, EventArgs e)
        {
            if (hoadon_gridview.RowCount>0)//Convert.ToInt16(hoadon_gridview.FocusedRowHandle) > -1)
            {
                string id = hoadon_gridview.GetRowCellValue(hoadon_gridview.FocusedRowHandle, "MAHD").ToString();
                if (mygetdata != null)
                    mygetdata(id);
                this.Close();
            }
            
        }

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            tim();
        }
    }
}