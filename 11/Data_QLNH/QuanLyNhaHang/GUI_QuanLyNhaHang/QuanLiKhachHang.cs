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
    public partial class QuanLiKhachHang : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        public QuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            getDGVKH();
        }
        public void getDGVKH()
        {
            String sql = "Select * from KhachHang";
            DataTable dt = new DataTable();
            dt = bus.get_Bang(sql);
            dgvKhachHang.DataSource = dt;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            String tenKH = txtTenKH.Text;
            String dc = txtDiaChi.Text;
            String sdt = txtSDT.Text;

            String sql = String.Format("insert into KhachHang values(N'{0}', N'{1}', '{2}')", tenKH, dc, sdt);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!");
                getDGVKH();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            String tenKH = txtTenKH.Text;
            String dc = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            try
            {
                int mKH = int.Parse(txtMaKH.Text.Trim());
                String sql = String.Format("Update KhachHang set tenKH = N'{0}', diaChi = N'{1}', sdt = '{2}' where maKH = {3}", tenKH, dc, sdt, mKH);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Cập nhật thành công!");
                getDGVKH();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int mKH = int.Parse(txtMaKH.Text.Trim());
                String sql = String.Format("Delete KhachHang where maKH = {0}", mKH);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công!");
                getDGVKH();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            String maKH = dgvKhachHang.Rows[dong].Cells[0].Value.ToString().Trim();
            String tenKH = dgvKhachHang.Rows[dong].Cells[1].Value.ToString().Trim();
            String diaChi = dgvKhachHang.Rows[dong].Cells[2].Value.ToString().Trim();
            String sdt = dgvKhachHang.Rows[dong].Cells[3].Value.ToString().Trim();
            txtMaKH.Text = maKH;
            txtTenKH.Text = tenKH;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tenKh = txtTim.Text;
            try
            {
                String sql = String.Format("Select * from KhachHang where tenKH LIKE N'%{0}%'", tenKh);
                dgvKhachHang.DataSource = bus.get_Bang(sql);

            }
            catch
            {
                MessageBox.Show("Không có thông tin khách hàng!", "thông báo");
            }
        }
    }
}
