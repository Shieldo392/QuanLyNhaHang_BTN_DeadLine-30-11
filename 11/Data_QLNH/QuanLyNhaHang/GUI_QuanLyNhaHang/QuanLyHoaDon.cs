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
    public partial class QuanLyHoaDon : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            getDgvQLHD();
            getCboTenKH();


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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            String maHD = txtmaHD.Text;
            int maKH = int.Parse(cboTenKH.SelectedValue.ToString());
            String date = dtpNgayNhap.Value.ToString();
            bus.insert_HoaDon(maHD, maKH, date);
            getDgvQLHD();
        }
    }
}
