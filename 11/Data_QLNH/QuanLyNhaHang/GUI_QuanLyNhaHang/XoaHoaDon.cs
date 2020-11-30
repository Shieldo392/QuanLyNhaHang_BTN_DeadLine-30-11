using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyNhaHang;

namespace GUI_QuanLyNhaHang
{
    public partial class XoaHoaDon : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        public XoaHoaDon()
        {
            InitializeComponent();
        }

        private void XoaHoaDon_Load(object sender, EventArgs e)
        {
            getCboTenKH();
            getDgvQLHD();
        }
        public void delete_hoaDon(String maHD)
        {
            
            String sql1 = String.Format("Delete ChiTietHD where maHD = '{0}'", maHD);
            String sql2 = String.Format("Delete HoaDon where maHD = '{0}'", maHD);
            try
            {
                bus.ExecuteNonQuery(sql1);
                bus.ExecuteNonQuery(sql2);
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mã hóa đơn!");
            }

        }
        public void getCboTenKH()
        {
            cboTenKH.DataSource = bus.tblKhachHang();
            cboTenKH.DisplayMember = "tenKH";
            cboTenKH.ValueMember = "maKH";
        }
        public void getDgvQLHD()
        {
            DataTable dt = new DataTable();
            dt = bus.tblQuanLyHoaDon();
            dgvQLHD.DataSource = dt;
        }

        private void dgvQLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmaHD.Text = dgvQLHD.Rows[dong].Cells[0].Value + "";
                cboTenKH.Text = dgvQLHD.Rows[dong].Cells[1].Value + "";
                txtDiaChi.Text= dgvQLHD.Rows[dong].Cells[2].Value + "";
                txtSdt.Text = dgvQLHD.Rows[dong].Cells[3].Value + "";
                dtpNgayNhap.Text = dgvQLHD.Rows[dong].Cells[4].Value + "";

            }
            catch
            {

            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String mahd = txtmaHD.Text;
            delete_hoaDon(mahd);
            getDgvQLHD();
        }

        
    }
}
