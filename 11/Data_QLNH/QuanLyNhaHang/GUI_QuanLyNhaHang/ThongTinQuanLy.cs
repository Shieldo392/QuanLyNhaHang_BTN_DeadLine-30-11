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
    public partial class ThongTinQuanLy : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        List<String> lst_ql = new List<string>();
        public ThongTinQuanLy()
        {
            InitializeComponent();
        }

        private void ThongTinQuanLy_Load(object sender, EventArgs e)
        {
            getDGV();
        }
        public void getDGV()
        {
            String sql = "Select * from QuanLy";
            DataTable dt = bus.get_Bang(sql);
            dgvNhanVien.DataSource = dt;
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
            if (check_maQL(manv))
            {
                MessageBox.Show("Mã quản lý đã tồn tại!", "Thông báo");
                return;
            }

            String sql = String.Format("Insert into QuanLy values('{0}', '{1}', N'{2}', N'{3}', N'{4}', {5}, '{6}')", manv, mk, tennv, gt, diaChi, namSinh, sdt);
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
            if (check_maQL(manv) == false)
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
            if (check_maQL(manv1) == false)
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
