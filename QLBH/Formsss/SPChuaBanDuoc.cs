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
    public partial class SPChuaBanDuoc : DevExpress.XtraEditors.XtraForm
    {
        public SPChuaBanDuoc()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();

        private void SLSPDaBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBANHANGDataSet.ThongKeSLSPDaBan' table. You can move, or remove it, as needed.
         //   this.thongKeSLSPDaBanTableAdapter.Fill(this.qLBANHANGDataSet.ThongKeSLSPDaBan);

            dtb = kketnoi.laydata("select * from XemSPChuaBanDuoc");
            SLSPDaBan_gridcontrol.DataSource = dtb;

            chartControl1.Visible = false;
        }



        private void list_Click(object sender, EventArgs e)
        {
            chartControl1.Visible = false;
        }

        private void Chart_Click(object sender, EventArgs e)
        {
            chartControl1.Visible = true;
        }
    }
}