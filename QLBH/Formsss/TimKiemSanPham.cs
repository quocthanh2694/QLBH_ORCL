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
    public partial class TimKiemSanPham : DevExpress.XtraEditors.XtraForm
    {
        //string loaitimkiem;
        public TimKiemSanPham()//string loaitim)
        {
            //loaitimkiem = loaitim;
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        public delegate void Getstring(string s);
        public Getstring getdata;
        

        private void Timkiem_Load(object sender, EventArgs e)
        {
            tim();
            
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    if (e.Info.IsRowIndicator)
            //        e.Info.DisplayText = (e.RowHandle + 1).ToString();
            //}
        }

       
        private void tim()
        {
            try
            {
                string sql = "select  MAVT,TENVT,DVT,GIAMUA,SLTON from vattu where TENVT like N'%" + tenvt_txt.Text + "%' and DVT like N'%" + dvt_text.Text + "%' and giamua like '%" + giamua_text.Text + "%' and slton like '%" + slton_text.Text + "%'";
                gridControl1.DataSource = kketnoi.laydata(sql);
            }
            catch (Exception )
            {
              
            }
        }

        private void timkiem_btn_Click(object sender, EventArgs e)
        {
            tim();
        }

        private void timkiem(object sender, EventArgs e)
        {
            tim();
        }

        private void giamua_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)==false && !Char.IsControl(e.KeyChar))// | e.KeyChar==45)
            {
                e.Handled = true;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)//Convert.ToInt16(gridView1.FocusedRowHandle) > -1)
            {
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAVT").ToString();
                if (getdata != null)
                {
                    getdata(id);
                }
                this.Close();
            }
        }
    }
}
