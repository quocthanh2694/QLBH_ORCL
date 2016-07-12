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
using System.Data.OracleClient;

namespace QLBH.Formsss
{
    public partial class TongDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public TongDoanhThu()
        {
            InitializeComponent();
        }

        private void doanhthu_txt_TextChanged(object sender, EventArgs e)
        {
            kiemtrachon();

        }

        private void kiemtrachon()
        {

            if (doanhthu_txt.Text == "Năm" | doanhthu_txt.Text == "")
            {
                nam_txt.Visible = false;
                thang_txt.Visible = false;
                nam_lb.Visible = false;
                thang_lb.Visible = false;
                nam_txt.Text = "";
                thang_txt.Text = "";
            }
            if (doanhthu_txt.Text == "Tháng")
            {
                nam_txt.Visible = true;
                nam_lb.Visible = true;
                thang_txt.Visible = false;
                thang_lb.Visible = false;
                thang_txt.Text = "";
                //nam_txt.EditValue = null; nam_txt.ClosePopup();
            }
            if (doanhthu_txt.Text == "Ngày")
            {
                nam_txt.Visible = true;
                nam_lb.Visible = true;
                thang_txt.Visible = true;
                thang_lb.Visible = true;
                // nam_txt.EditValue=null; nam_txt.ClosePopup();
                thang_txt.Text = "";
            }
        }

        private void nam_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void thang_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (thang_txt.Text != "")
                    if (Convert.ToInt16(thang_txt.Text.ToString()) > 12 | Convert.ToInt16(thang_txt.Text.ToString()) < 1)
                    {
                        XtraMessageBox.Show("Nhập sai tháng");
                        thang_txt.Text = "";
                        thang_txt.Focus();
                    }
            }
            catch (Exception)
            { }
        }
        ketnoi kketnoi = new ketnoi();
        DataTable dtb = new DataTable();
        private void doanhthu_txt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (doanhthu_txt.Text == "Năm")
                {
                   // dtb = kketnoi.laydata("select N'Năm' as ma, year(ngay) as date,sum(sl*giaban*khuyenmai) as doanhthu from hoadon h,cthd c where c.MAHD=h.MAHD group by year( ngay)");
                    dtb = kketnoi.laydata(@"select * from ThongKeDoanhThu_Nam  ");
                    chart();
                }
                if (doanhthu_txt.Text == "Tháng")
                {
                  //  dtb = kketnoi.laydata("select N'Tháng'as ma,   month(ngay) as date,sum(sl*giaban*khuyenmai) as doanhthu from hoadon h,cthd c where c.MAHD=h.MAHD and year(ngay)=" + Convert.ToInt16(nam_txt.Text.ToString()) + " group by year(ngay),month( ngay)");
                    int s;
                    if (nam_txt.Text.ToString()== "")
                        s = 0;
                    else
                    {
                        s = Convert.ToInt16(nam_txt.Text.ToString());
                    }
                    dtb = kketnoi.laydata(@"  select 'Tháng' as ma,  EXTRACT(month FROM Ngay) as ngay,sum(sl*giaban*khuyenmai) as doanhthu
                        from hoadon h,cthd c
                        where c.MAHD=h.MAHD and  EXTRACT(year FROM Ngay)='" + s + "' group by EXTRACT(month FROM Ngay),EXTRACT(year FROM Ngay)");
                    chart();
                }
            }
            catch (Exception) { }

        }

        private void chart()
        {

            chartControl1.DataSource = dtb;

            chartControl1.SeriesDataMember = "MA";
            chartControl1.SeriesTemplate.ArgumentDataMember = "ngay";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "doanhthu" });


            chartControl1.SeriesTemplate.View = new StackedBarSeriesView();
            // chartControl1.SeriesNameTemplate.BeginText = "nam";
            //  chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

        private void nam_txt_TextChanged123(object sender, EventArgs e)
        {
          
        }

        private void TongDoanhThu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kketnoi.laydata("select  EXTRACT(year FROM Ngay) as Nam from hoadon group by EXTRACT(year FROM Ngay) order by  EXTRACT(year FROM Ngay) desc");
            

            nam_txt.DataSource = dt;
            nam_txt.DisplayMember = "Nam";
            nam_txt.ValueMember = "Nam";
            nam_txt.Text = "";

            dtb = kketnoi.laydata(@"select * from ThongKeDoanhThu_Nam  ");
            chart();
        }

        private void thang_txt_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (nam_txt.Text == "" && thang_txt.Text != "")
                {
                    XtraMessageBox.Show("Vui lòng chọn năm");
                    nam_txt.Focus();
                }
                else
                {
                    if (thang_txt.Text != "")
                    {
                        dtb = kketnoi.laydata("select N'Ngày'as ma, EXTRACT(day FROM Ngay) as ngay,sum(sl*giaban*khuyenmai) as doanhthu from hoadon h,cthd c where c.MAHD=h.MAHD and EXTRACT(year FROM Ngay)=" + Convert.ToInt16(nam_txt.Text.ToString()) + " and EXTRACT(month FROM Ngay)=" + Convert.ToInt16(thang_txt.Text.ToString()) + " group by EXTRACT(day FROM Ngay)");
                        chart();
                    }
                }
            }
            catch (Exception) { }
        }

        private void thang_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void nam_txt_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (nam_txt.Text.ToString() != "" && thang_txt.Visible == false)
                {


                    dtb = kketnoi.laydata(@"  select 'Tháng' as ma,  EXTRACT(month FROM Ngay) as ngay,sum(sl*giaban*khuyenmai) as doanhthu
                        from hoadon h,cthd c
                        where c.MAHD=h.MAHD and  EXTRACT(year FROM Ngay)='"+Convert.ToInt16(nam_txt.Text.ToString())+"' group by EXTRACT(month FROM Ngay),EXTRACT(year FROM Ngay)");

                   // dtb = kketnoi.laydata("select N'Tháng'as ma,   month(ngay) as date,sum(sl*giaban*khuyenmai) as doanhthu from hoadon h,cthd c where c.MAHD=h.MAHD and year(ngay)=" + Convert.ToInt16(nam_txt.Text.ToString()) + " group by year(ngay),month( ngay)");
                    chart();
                }
                if (thang_txt.Visible == true && thang_txt.Text != "")
                {
                    dtb = kketnoi.laydata("select N'Ngày'as ma, EXTRACT(day FROM Ngay) as ngay,sum(sl*giaban*khuyenmai) as doanhthu from hoadon h,cthd c where c.MAHD=h.MAHD and EXTRACT(year FROM Ngay)=" + Convert.ToInt16(nam_txt.Text.ToString()) + " and EXTRACT(month FROM Ngay)=" + Convert.ToInt16(thang_txt.Text.ToString()) + " group by EXTRACT(day FROM Ngay)");
                    chart();
                }
            }
            catch (Exception a) {
              //  MessageBox.Show(a.ToString()); 
            }
        }

    }
}