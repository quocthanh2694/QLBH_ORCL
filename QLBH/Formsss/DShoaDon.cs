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
    public partial class DShoaDon : DevExpress.XtraEditors.XtraForm
    {
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        public DShoaDon()
        {
            InitializeComponent();
        }

        private void NVBanHangNhieuNhat_Load(object sender, EventArgs e)
        {
            dshoadon_gridcontrol.DataSource = kketnoi.laydata("select * from dshoadon");
        }
        private void tim()
        {
            string[] a = textEdit1.Text.ToString().Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                string str = "select * from dshoadon where stt like '%" + a[i].ToString() + "%' or [mã hóa đơn] like N'%" + a[i].ToString() + "%' or [tên nhân viên] like N'%" + a[i].ToString() + "%' or [Tên khách hàng] like N'%" + a[i].ToString() + "%' or convert(varchar(20),[ngày],103) like '%" + a[i].ToString() + "%' or [Tên sản phẩm] like N'%" + a[i].ToString() + "%' or [Số lượng] like '%" + a[i].ToString() + "%' or [Khuyến mãi (%)] like '%" + a[i].ToString() + "%' or [Giá bán] like '%" + a[i].ToString() + "%'";
                DataTable dt = new DataTable();
                dt = kketnoi.laydata(str);

                if (i == 0) dtb = dt.Clone();
                foreach (DataRow r in dt.Rows)
                {
                    DataRow row = dtb.NewRow();
                    dtb.ImportRow(r);
                }
            }

            for (int c = 0; c < dtb.Rows.Count - 1; c++)
            {
                for (int d = c + 1; d < dtb.Rows.Count; d++)
                {
                    if (dtb.Rows[d]["STT"].ToString().Trim() == dtb.Rows[c]["STT"].ToString().Trim())

                        dtb.Rows.Remove(dtb.Rows[d]);
                }
            }
            dshoadon_gridcontrol.DataSource = dtb;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tim();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tim();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            In inn = new In();
            inn.ShowDialog();
            splashScreenManager1.CloseWaitForm();
        }
    }
}