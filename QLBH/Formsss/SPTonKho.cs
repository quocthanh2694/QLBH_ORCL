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
using DevExpress.XtraCharts;

namespace QLBH.Formsss
{
    public partial class SPTonKho : DevExpress.XtraEditors.XtraForm
    {
        public SPTonKho()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();

        private void SPTonKho_Load(object sender, EventArgs e)
        {
            //SanPhamTonKho_gridcontrol.DataSource = kketnoi.laydata("select * from SPTonKho");

            DataTable dt = new DataTable();
           // dt = kketnoi.laydata("select  EXTRACT(year FROM Ngay) as Nam from hoadon group by EXTRACT(year FROM Ngay) order by  EXTRACT(year FROM Ngay) desc");


            //nam_txt.DataSource = dt;
            //nam_txt.DisplayMember = "Nam";
            //nam_txt.ValueMember = "Nam";
            //nam_txt.Text = "";

            dtb = kketnoi.laydata(@"select * from XemSPTonKho");
            chart();
        }
        private void chart()
        {

            chartControl1.DataSource = dtb;

            chartControl1.SeriesDataMember = "MA";
            chartControl1.SeriesTemplate.ArgumentDataMember = "TenSP";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "SLTON" });


            chartControl1.SeriesTemplate.View = new StackedBarSeriesView();
            // chartControl1.SeriesNameTemplate.BeginText = "nam";
            //  chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }
        //private void tim()
        //{
        //    string[] a = textEdit1.Text.ToString().Split(' ');
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //            string str = "select * from sptonkho where [Mã sản phẩm] like N'%" + a[i].ToString() + "%' or [Tên sản phẩm] like N'%" + a[i].ToString() + "%' or [Đơn vị tính] like N'%" + a[i].ToString() + "%' or  [Giá mua] like '%" + a[i].ToString() + "%' or [Số lượng tồn kho] like '%" + a[i].ToString() + "%'";
        //            DataTable dt = new DataTable();
        //            dt = kketnoi.laydata(str);

        //            if (i == 0) dtb = dt.Clone();
        //            foreach (DataRow r in dt.Rows)
        //            {
        //                DataRow row = dtb.NewRow();
        //                dtb.ImportRow(r);
        //            }
        //    }
           
        //    for (int c = 0; c < dtb.Rows.Count-1; c++)
        //    {
        //        for (int d=c+1; d < dtb.Rows.Count; d++)
        //        {
        //            if (dtb.Rows[d]["Mã sản phẩm"].ToString().Trim() == dtb.Rows[c]["Mã sản phẩm"].ToString().Trim())
                        
        //                dtb.Rows.Remove(dtb.Rows[d]);
        //        }
        //    }
        //    SanPhamTonKho_gridcontrol.DataSource = dtb;
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //tim();
        }

        private void textEdit1_textchanged(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           // tim();
           
        }
    }
}