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
    public partial class LuongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public LuongNhanVien()
        {
            InitializeComponent();
        }
        ketnoi kketnoi = new ketnoi();
        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
           
            laynam();

            
            laydl(DateTime.Now.Month.ToString(),DateTime.Now.Year.ToString());
        }

        private void laynam()
        {
            DataTable dt = new DataTable();
            dt = kketnoi.laydata("select year(ngay) as Nam from hoadon group by year(ngay)");
            nam_txt.Properties.DataSource = dt;
            nam_txt.Properties.DisplayMember = "Nam";
            nam_txt.Properties.ValueMember = "Nam";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //chartControl1.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           // chartControl1.Visible = true;
        }

        private void thang_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void thang_txt_TextChanged(object sender, EventArgs e)
        {

            if (nam_txt.Text == "" && thang_txt.Text != "")
            {
                XtraMessageBox.Show("Vui lòng chọn năm");
                nam_txt.Focus();
            }
            else
            {
                laydl(thang_txt.Text, nam_txt.Text);
            }

        }

        private void laydl(string thang,string nam)
        {
            try
            {
                //if (thang_txt.Text != "" && nam_txt.Text !="")
                //{
                    string str = "tongluong @thang,@nam";
                    kketnoi.connect.Open();
                    SqlCommand comd = new SqlCommand(str, kketnoi.connect);

                    comd.Parameters.AddWithValue("@thang", thang);
                    comd.Parameters.AddWithValue("@nam", nam);
                    comd.ExecuteNonQuery();

                    SqlDataAdapter adata = new SqlDataAdapter();
                    adata.SelectCommand = comd;
                    DataTable dtb = new DataTable();
                    adata.Fill(dtb);
                    adata.Dispose();
                    kketnoi.connect.Close();

                    luongnhanvien_gridcontrol.DataSource = dtb;
               // }
            }
            catch (Exception) { }
        }

        private void nam_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nam_txt_TextChanged(object sender, EventArgs e)
        {
            if( thang_txt.Text != "")
              laydl(thang_txt.Text,nam_txt.Text);
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}