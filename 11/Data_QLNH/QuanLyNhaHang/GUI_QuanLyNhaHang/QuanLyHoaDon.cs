﻿using System;
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
        string _maNV;
        int _code;

        public QuanLyHoaDon(string maNV, int code)
        {
            this._code = code;
            this._maNV = maNV;
            InitializeComponent();
        }
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
            if(txtmaHD.Text =="")
            {
                MessageBox.Show("Mã hóa đơn không được để trống!", "Thông báo");
                return;
            }    
            String maHD = txtmaHD.Text;
            int maKH = int.Parse(cboTenKH.SelectedValue.ToString());
            String date = dtpNgayNhap.Value.ToString();
            bus.insert_HoaDon(maHD, maKH, date);
            getDgvQLHD();
        }

        private void dgvQLHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            String maHD = dgvQLHD.Rows[dong].Cells[0].Value + "";
            String tenKH = dgvQLHD.Rows[dong].Cells[1].Value + "";
            String diaChi = dgvQLHD.Rows[dong].Cells[2].Value + "";
            String sdt = dgvQLHD.Rows[dong].Cells[3].Value + "";
            String ngayNhap = dgvQLHD.Rows[dong].Cells[4].Value + "";
            ChiTietHoaDon frm1 = new ChiTietHoaDon(_maNV, maHD, tenKH, diaChi, sdt, ngayNhap);
            frm1.Show();
            
           
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang frm = new QuanLiKhachHang();
            frm.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham(_code);
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String tenKH1 = txtTenKHFind.Text.Trim();
            String sql = String.Format("Select HoaDon.maHD, tenKH, diaChi, sdt, ngayNhap from " +
                "HoaDon inner join KhachHang on HoaDon.maKH = KhachHang.maKH " +
                "where tenKH LIKE N'%{0}%'", tenKH1);
            dgvQLHD.DataSource = bus.get_Bang(sql);
        }
    }
}
