using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using DevExpress.XtraEditors;

namespace QLBH
{
   
    class ketnoi
    {
      public  SqlConnection connect;
        public bool ko;
        public bool ktketnoiserver(string server, string user, string pass)
        {
            try
            {
                connect = new SqlConnection(@"Data Source=" + server + ";Initial Catalog=QLBANHANG;User ID=" + user + ";Password=" + pass);
                connect.Open();
                connect.Close();
                ko= true;
            }
            catch
            {
                ko= false;
            }
            return ko;
        }
        public void ketnoiserver()
        {
            try
            {
                string server = Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadSubTree).GetValue("server", "").ToString();
                string user = Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadSubTree).GetValue("user", "").ToString();
                string pass = Registry.CurrentUser.CreateSubKey("QLBH", RegistryKeyPermissionCheck.ReadSubTree).GetValue("pass", "").ToString();
                connect = new SqlConnection(@"Data Source=" + server + ";Initial Catalog=QLBANHANG;User ID=" + user + ";Password=" + pass);
                connect.Open();
            }
            catch (Exception )
            {
              
            }
        }
        SqlCommand command;
        SqlDataAdapter adata;
        SqlDataReader reader;
        public DataTable laydata(string sqlstr)
        {
            DataTable data = new DataTable();
            ketnoiserver();
            
            command = new SqlCommand(sqlstr,connect);
            
            command.ExecuteScalar();

            adata = new SqlDataAdapter();
            adata.SelectCommand = command;
            adata.Fill(data);
            adata.Dispose();

            connect.Close();
            return data;
        }
        public string laydata_dong(string str)// lay gia tri 1 ô
        {
            ketnoiserver();
            command = new SqlCommand(str,connect);
            reader = command.ExecuteReader();
            string v = reader.Read() ? reader[0].ToString() : "";
            reader.Dispose();
            connect.Close();
            return v;
        }
        
    }
}
