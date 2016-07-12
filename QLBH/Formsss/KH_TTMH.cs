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
    public partial class KH_TTMH : DevExpress.XtraEditors.XtraForm
    {
        public KH_TTMH()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        private void KhachHangVip_Load(object sender, EventArgs e)
        {

            dtb = kketnoi.laydata("Select * from ThongTinTongHop");
            khachhangvip_gridcontrol.DataSource = dtb;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}