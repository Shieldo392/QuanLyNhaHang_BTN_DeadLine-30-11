using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyNhaHang
{
    public partial class frmInHoaDon : Form
    {
        String _maHD;
        public frmInHoaDon(String maHD)
        {
            this._maHD = maHD;
            InitializeComponent();
        }
        string strCon = "Data Source =.;Database =QuanLyBanHang_ver2;Integrated Security=true";

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            String sql = String.Format("select maSP, tenSP, soLuong, donGia, tongTien from vw_ctHD where maHD = '{0}'", _maHD);
            SqlConnection scon = new SqlConnection(strCon);
            SqlDataAdapter sda = new SqlDataAdapter(sql, strCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rptInHD rpt = new rptInHD();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
