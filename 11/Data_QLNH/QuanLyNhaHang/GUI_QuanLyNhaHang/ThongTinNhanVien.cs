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
    public partial class ThongTinNhanVien : Form
    {
        int _code;
        Bus_QLNH bus = new Bus_QLNH();
        public ThongTinNhanVien()
        {
            
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getDGV();
        }
        public void getDGV()
        {
            String sql = "Select maNv,tenNv, gioiTinh, diaChi, namSinh from NhanVien";
            DataTable dt = bus.get_Bang(sql);
            dgvNhanVien.DataSource = dt;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString().Trim();
                txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString().Trim();
                txtNamSinh.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString().Trim();
                String gt = dgvNhanVien.Rows[dong].Cells[2].Value.ToString().Trim();
                if (gt.Contains("Nam"))
                    radNam.Checked = true;
                else
                {
                    radNu.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String tenNV = txtFindName.Text;
            String sql = String.Format("Select maNv,tenNv, gioiTinh, diaChi, namSinh from NhanVien where tenNv LIKE N'%{0}%'", tenNV);
            try
            {
                DataTable dt = bus.get_Bang(sql);
                dgvNhanVien.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!", "Thông báp");
            }
        }
    }
}
