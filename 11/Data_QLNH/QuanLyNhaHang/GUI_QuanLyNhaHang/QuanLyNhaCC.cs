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
    public partial class QuanLyNhaCC : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        List<String> lst_ncc = new List<string>();
        public QuanLyNhaCC()
        {
            InitializeComponent();
        }

        private void QuanLyNhaCC_Load(object sender, EventArgs e)
        {
            getDGV();
        }
        public void getDGV()
        {
            String sql = String.Format("Select * from NhaCungCap");
            DataTable dt = new DataTable();
            dt = bus.get_Bang(sql);
            dgvNCC.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenNCC = txtTenNCC.Text.Trim();
            String  diaChi = txtDiaChi.Text.Trim();
            String sdt = txtSDT.Text.Trim();
            insert(tenNCC, diaChi, sdt);
        }
        public void insert( String tenNCC, String diaChi, String sdt)
        {

            try
            {
                String sql = String.Format("insert into NhaCungCap values(N'{0}', N'{1}', N'{2}')", tenNCC, diaChi, sdt);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại Mã Nhà cung cấp!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String tenNCC = txtTenNCC.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String sdt = txtSDT.Text.Trim();
            try
            {
                int maNCC = int.Parse(txtMaNCC.Text.Trim());
                update(maNCC, tenNCC, diaChi, sdt);

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mã NCC");
            }
        }
        public void update(int maNCC, String tenNCC, String diaChi, String sdt)
        {

            try
            {
                maNCC = int.Parse(txtMaNCC.Text.Trim());
                String sql = String.Format("update NhaCungCap set tenNCC = N'{0}',diaChi =  N'{1}', soDT = '{2}' where maNCC = {3}", tenNCC, diaChi, sdt, maNCC);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Update thành công!");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra thông tin!");
            }

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txtMaNCC.Text = dgvNCC.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTenNCC.Text = dgvNCC.Rows[dong].Cells[1].Value.ToString().Trim();
                txtDiaChi.Text = dgvNCC.Rows[dong].Cells[2].Value.ToString().Trim();
                txtSDT.Text = dgvNCC.Rows[dong].Cells[3].Value.ToString().Trim();

            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maNCC = int.Parse(txtMaNCC.Text.Trim());
                delete(maNCC);

            }
            catch
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!");
            }
            

        }
        public void delete(int maNCC)
        {
            try
            {
                String sql = String.Format("Delete NhaCungCap where maNCC = {0}", maNCC);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công!");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String tenNCc = txtTimKiem.Text.Trim();
            String sql = String.Format("Select * from NhaCungCap where tenNCC LIKE N'%{0}%'", tenNCc);
            DataTable dt = new DataTable();
            dt = bus.get_Bang(sql);
            dgvNCC.DataSource = dt;
        }
    }
}
