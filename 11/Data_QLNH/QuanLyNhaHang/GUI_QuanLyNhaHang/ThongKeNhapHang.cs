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
    public partial class ThongKeNhapHang : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        List<String> lst_hdNhap;
        int _code;
        public ThongKeNhapHang(int code)
        {
            this._code = code;
            InitializeComponent();
        }

        private void ThongKeNhapHang_Load(object sender, EventArgs e)
        {
            if(_code == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            getList();
            getDGV();
            getCBO();
        }
        private DataTable getTbl()
        {
            String sql = String.Format("Select HDNhap.maHDN, tenNCC, ngayNhap " +
                "from HDNhap  " +
                " inner join NhaCungCap on HDNhap.maNCC = NhaCungCap.maNCC");
            DataTable dt = bus.get_Bang(sql);
            return dt;

        }
        private void getDGV()
        {
            dgv.DataSource = getTbl();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = String.Format("Select HDNhap.maHDN, tenNCC, ngayNhap, tenSP, soLuongNhap, chiTietNhap.donGia " +
                "from HDNhap inner join chiTietNhap on HDNhap.maHDN = chiTietNhap.maHDN " +
                " inner join SanPham  on SanPham.maSP = chiTietNhap.maSP " +
                " inner join NhaCungCap on HDNhap.maNCC = NhaCungCap.maNCC");
            if (comboBox1.Text.Contains("Ngày nhập"))
            {
                sql += " order by ngayNhap desc";
                
            }  
            else if(comboBox1.Text.Contains("Nhà cung cấp"))
            {
                sql += " order by NhaCungCap.maNCC desc";
            }
            else if(comboBox1.Text.Contains("Hóa đơn nhập"))
            {
                sql += " order by HDNhap.maHDN desc";
            }
            else if(comboBox1.Text.Contains("Sản phẩm"))
            {
                sql += " order by SanPham.tenSP desc";
            }
            DataTable dt = bus.get_Bang(sql);
            dgv.DataSource = dt;
        }


        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String maHDN = txtMaHDN.Text.Trim();
            ChiTietHDN frm = new ChiTietHDN(maHDN);
            frm.Show();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaHDN.Text = dgv.Rows[dong].Cells[0].Value.ToString().Trim();
                cboNCC.Text = dgv.Rows[dong].Cells[1].Value.ToString().Trim();
                dateTimePicker1.Text = dgv.Rows[dong].Cells[2].Value.ToString().Trim();
            }
            catch
            {

            }
        }
        private void getCBO()
        {
            String sql = String.Format("Select maNCC, tenNCC from NhaCungCap");
            DataTable dt = bus.get_Bang(sql);
            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "tenNCC";
            cboNCC.ValueMember = "maNCC";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maHDN = txtMaHDN.Text.Trim();
            if(check_mhdn(maHDN))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!", "thông báo");
                return;
            }    
            int maNCC = int.Parse(cboNCC.SelectedValue.ToString().Trim());
            String date = dateTimePicker1.Value.ToString().Trim();
            
            String sql = String.Format("insert into HDNhap values('{0}', {1}, '{2}')", maHDN, maNCC, date);
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

        public void getList()
        {
            lst_hdNhap = new List<string>();
            String sql = "Select Distinct(maHDN) from HDNhap";
            DataTable dt = bus.get_Bang(sql);
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                lst_hdNhap.Add(dr[0].ToString().Trim());
            }
        }
        public bool check_mhdn(String mhdn)
        {

            foreach (String item in lst_hdNhap)
            {
                if (item.Equals(mhdn))
                    return true;
            }
            return false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String maHDN = txtMaHDN.Text.Trim();
            int maNCC = int.Parse(cboNCC.SelectedValue.ToString().Trim());
            String date = dateTimePicker1.Value.ToString().Trim();

            String sql = String.Format("Update HDNhap set maNCC = {0}, ngayNhap = '{1}' where maHDN = '{2}'", maNCC, date, maHDN);
            try
            {
                bus.ExecuteNonQuery(sql);
                MessageBox.Show("Update thành công!", "Thông báo");
                getDGV();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin!", "Thông báo");
            }
        }
    }
}
