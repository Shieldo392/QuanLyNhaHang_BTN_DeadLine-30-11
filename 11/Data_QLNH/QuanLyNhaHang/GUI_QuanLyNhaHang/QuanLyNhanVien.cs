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
    public partial class QuanLyNhanVien : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        List<String> lst_nv = new List<string>();
        List<String> lst_ql = new List<string>();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getDGV();
        }
        public void getDGV()
        {
            String sql = "Select * from NhanVien";
            DataTable dt = bus.get_Bang(sql);
            dgvNhanVien.DataSource = dt;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString().Trim();
                txtMatKhau.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString().Trim();
                txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString().Trim();
                txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString().Trim();
                txtNamSinh.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString().Trim();
                txtSDT.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString().Trim();
                String gt = dgvNhanVien.Rows[dong].Cells[3].Value.ToString().Trim();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            String gt;
            String manv = txtMaNV.Text.Trim();
            String tennv = txtTenNV.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String mk = txtMatKhau.Text.Trim();
            String sdt = txtSDT.Text.Trim();
            int namSinh = int.Parse(txtNamSinh.Text.Trim());
            if (radNam.Checked = true)
                gt = "Nam";
            else
            {
                gt = "Nữ";
            }
            if(check_maNV(manv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo");
                return;
            }

            String sql = String.Format("Insert into NhanVien values('{0}', '{1}', N'{2}', N'{3}', N'{4}', {5}, '{6}')", manv, mk, tennv, gt, diaChi, namSinh, sdt);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại Thông tin!", "Thông báo");
            }
        }

        public bool check_maNV(String manv)
        {
            int dem = 0;
            getListNV();
            for (int i = 0; i < lst_nv.Count; i++)
            {
                if (lst_nv[i].Equals(manv))
                    dem++; 
                    
            }
            if (dem == 0)
                return false;
            else
                return true;
        }
        public bool check_maQL(String manv)
        {
            int dem = 0;
            getListQL();
            for (int i = 0; i < lst_ql.Count; i++)
            {
                if (lst_ql[i].Equals(manv))
                    dem++;

            }
            if (dem == 0)
                return false;
            else
                return true;
        }

        public void getListNV()
        {
            String sql = "Select * from NhanVien";
            DataTable dt = bus.get_Bang(sql);
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                lst_nv.Add(dr[0].ToString().Trim());
            }
        }
        public void getListQL()
        {
            String sql = "Select * from QuanLy";
            DataTable dt = bus.get_Bang(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                lst_ql.Add(dr[0].ToString().Trim());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String gt;
            String manv = txtMaNV.Text.Trim();
            String tennv = txtTenNV.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String mk = txtMatKhau.Text.Trim();
            String sdt = txtSDT.Text.Trim();
            int namSinh = int.Parse(txtNamSinh.Text.Trim());
            if (radNam.Checked = true)
                gt = "Nam";
            else
            {
                gt = "Nữ";
            }
            if (check_maNV(manv) == false)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo");
                return;
            }

            String sql = String.Format("Update NhanVien set matKhau = '{0}', " +
                                        "tenNv = N'{1}', gioiTinh = N'{2}', " +
                                        "diaChi = N'{3}', namSinh = {4}, " +
                                        "soDt = '{5}' where maNv = '{6}'", mk, tennv, gt, diaChi, namSinh, sdt, manv);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Update thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại Thông tin!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String manv1 = txtMaNV.Text.Trim();
            if (check_maNV(manv1) == false)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo");
                return;
            }
            String sql = String.Format("Delete NhanVien where maNv = '{0}'", manv1);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại Thông tin!", "Thông báo");
            }
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            String gt;
            String manv = txtMaNV.Text.Trim();
            String tennv = txtTenNV.Text.Trim();
            String diaChi = txtDiaChi.Text.Trim();
            String mk = txtMatKhau.Text.Trim();
            String sdt = txtSDT.Text.Trim();
            int namSinh = int.Parse(txtNamSinh.Text.Trim());
            if (radNam.Checked = true)
                gt = "Nam";
            else
            {
                gt = "Nữ";
            }
            if (check_maQL(manv))
            {
                MessageBox.Show("Mã Quản lý đã tồn tại!", "Thông báo");
                return;
            }

            String sql = String.Format("Insert into QuanLy values('{0}', '{1}', N'{2}', N'{3}', N'{4}', {5}, '{6}')", manv, mk, tennv, gt, diaChi, namSinh, sdt);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm quản lý thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại Thông tin!", "Thông báo");
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
