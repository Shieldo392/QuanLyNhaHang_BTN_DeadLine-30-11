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
    public partial class QuanLySanPham : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        int _code;
        public QuanLySanPham(int code)
        {
            this._code = code;
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            getCBONCC();
            getDGVSP();
        }
        
        public void getDGVSP()
        {
            String sql = "Select maSP, tenSP, soLuong, donGia from SanPham ";
            dgvSanPham.DataSource = bus.get_Bang(sql);
        }
        public void getCBONCC()
        {
            String sql = "Select maNCC, tenNCC from NhaCungCap";
            DataTable dt = new DataTable();
            dt = bus.get_Bang(sql);
           
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString().Trim();
            txtSoLuong.Text = dgvSanPham.Rows[dong].Cells[2].Value.ToString().Trim();
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString().Trim();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenSP = txtTenSP.Text;
            try
            {
                
                int sl = int.Parse(txtSoLuong.Text.Trim());
                int dg = int.Parse(txtDonGia.Text.Trim());
                
                String sql = String.Format("Insert into SanPham values( N'{0}', {1}, {2})", tenSP, sl, dg);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!");
                getDGVSP();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String tenSP = txtTenSP.Text;
           // update chưa xong
            try
            {
                 int msp = int.Parse(txtMaSP.Text.Trim());
                 int sl = int.Parse(txtSoLuong.Text.Trim());
                int dg = int.Parse(txtDonGia.Text.Trim());
                String sql = String.Format("Update SanPham set tenSP = N'{0}', soLuong= {1}, donGia = {2} where maSP = {4}", tenSP, sl, dg, msp);
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Update thành công!");
                getDGVSP();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập!");
            }
        }
    }
}
