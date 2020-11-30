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
    public partial class ChiTietHDN : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        String mahdn;
        public ChiTietHDN(String Mahdn)
        {
            this.mahdn = Mahdn;
            InitializeComponent();
        }

        private void ChiTietHDN_Load(object sender, EventArgs e)
        {
            txtMaHDN.Text = mahdn;
            getDGV();
            getCBO();
        }
        public void getDGV()
        {
            String sql = String.Format("Select tenSP, chiTietNhap.soLuongNhap, chiTietNhap.donGia from chiTietNhap inner join SanPham on chiTietNhap.maSP = SanPham.maSP where maHDN = '{0}'", mahdn);
            DataTable dt = bus.get_Bang(sql);
            dgvChiTiet.DataSource = dt;
        }
        public void getCBO()
        {
            String sql = String.Format("Select maSP, tenSP from SanPham");
            DataTable dt = bus.get_Bang(sql);
            cboTenSP.DataSource = dt;
            cboTenSP.DisplayMember = "tenSP";
            cboTenSP.ValueMember = "maSP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cboTenSP.SelectedValue.ToString().Trim());
            int soLuongNhap = int.Parse(txtSoLuong.Text.ToString().Trim());
            int donGia = int.Parse(txtDonGia.Text.ToString().Trim());

            String sql = String.Format("Insert into chiTietNhap values('{0}', {1}, {2}, {3})", mahdn, maSP, soLuongNhap, donGia);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!", "Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cboTenSP.SelectedValue.ToString().Trim());
            int soLuongNhap = int.Parse(txtSoLuong.Text.ToString().Trim());
            int donGia = int.Parse(txtDonGia.Text.ToString().Trim());
            String sql = String.Format("Update chiTietNhap set  soLuongNhap = {0}, donGia = {1} where maHDN = '{2}' and maSP = {3}", soLuongNhap, donGia, mahdn, maSP);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Sửa thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!", "Thông báo");
            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;                cboTenSP.Text = dgvChiTiet.Rows[dong].Cells[0].Value.ToString().Trim();
                txtSoLuong.Text = dgvChiTiet.Rows[dong].Cells[1].Value.ToString().Trim();
                txtDonGia.Text = dgvChiTiet.Rows[dong].Cells[2].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cboTenSP.SelectedValue.ToString().Trim());
            try
            {
                String sql = String.Format("Delete chiTietNhap where maHDN = '{0}' and maSP = {1}", mahdn, maSP);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Sản phẩm không có trong hóa đơn!", "Thông báo");
            }
        }
    }
}
