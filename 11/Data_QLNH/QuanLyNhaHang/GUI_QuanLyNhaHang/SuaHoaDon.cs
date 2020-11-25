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
    public partial class SuaHoaDon : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        public SuaHoaDon()
        {
            InitializeComponent();
        }

        private void SuaHoaDon_Load(object sender, EventArgs e)
        {
            getCboTenKH();
            getDgvQLHD();
        }
        public void update_hoaDon(String maHD, int maKH, String ngayNhap)
        {
            
            String sql2 = String.Format("Update HoaDon set maKH = {0}, ngayNhap = '{1}' where maHD = '{2}'", maKH, ngayNhap, maHD);
            try
            {
                bus.ExecuteNonQuery(sql2);
                MessageBox.Show("Update thành công!");
            }
            catch (Exception e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String maHD = txtmaHD.Text.Trim();
            int maKH = int.Parse(cboTenKH.SelectedValue.ToString().Trim());
            String ngayNhap = dtpNgayNhap.Value.ToString();
            update_hoaDon(maHD, maKH, ngayNhap);
            getDgvQLHD();
        }

        private void dgvQLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmaHD.Text = dgvQLHD.Rows[dong].Cells[0].Value + "";
                cboTenKH.Text = dgvQLHD.Rows[dong].Cells[1].Value + "";
                txtDiaChi.Text = dgvQLHD.Rows[dong].Cells[2].Value + "";
                txtSdt.Text = dgvQLHD.Rows[dong].Cells[3].Value + "";
                dtpNgayNhap.Text = dgvQLHD.Rows[dong].Cells[4].Value + "";

            }
            catch
            {

            }
        }
    }
}
