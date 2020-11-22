using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyNhaHang
{
    public class Dal_QLNH
    {
        private string strConn = @"Data Source=DESKTOP-SUKQLAU;Initial Catalog=QuanLyBanHang_ver2;Integrated Security=True";

        public SqlConnection getConnect()
        {
            return new SqlConnection(strConn);
        }
        public DataTable getTable(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            return dt;
        }
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            com.Dispose();
            com.Clone();
            conn.Close();
        }
    }
}
