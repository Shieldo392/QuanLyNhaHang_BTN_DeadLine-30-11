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
    public partial class ChiTietHoaDon : Form
    {
        List<SanPham> lst_sanPham = new List<SanPham>();
        List<SanPham> lst_sanPham_order;
        Bus_QLNH bus = new Bus_QLNH();
        String _maNV, _maHD, _tenKH, _diaChi, _sdt, _ngayNhap;

        public ChiTietHoaDon(string maNV, string maHD, string tenKH, string diaChi, string sdt, string ngayNhap)
        {
            this._maNV = maNV;
            this._maHD = maHD;
            this._tenKH = tenKH;
            this._diaChi = diaChi;
            this._sdt = sdt;
            this._ngayNhap = ngayNhap;
            InitializeComponent();
        }

        public ChiTietHoaDon()
        {
            InitializeComponent();


        }

        private void btnCong_lauCua_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtLauCua.Text);
            i++;
            txtLauCua.Text = i + "";
        }

        private void btnTru_lauCua_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtLauCua.Text);
            if (i > 0)
            {
                i--;
                txtLauCua.Text = i + "";
            }

        }

        private void btnCong_khanUot_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKhanUot.Text);
            i++;
            txtKhanUot.Text = i + "";
        }

        private void btnTru_khanUot_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKhanUot.Text);
            if (i > 0)
            {
                i--;
                txtKhanUot.Text = i + "";
            }
        }

        private void btnCong_ThitBo_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtThitBo.Text);
            i++;
            txtThitBo.Text = i + "";
        }

        private void btnTru_thitBo_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtThitBo.Text);
            if (i > 0)
            {
                i--;
                txtThitBo.Text = i + "";
            }
        }

        private void btnCong_TrangLon_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTrangLon.Text);
            i++;
            txtTrangLon.Text = i + "";
        }

        private void btnTru_trangLon_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTrangLon.Text);
            if (i > 0)
            {
                i--;
                txtTrangLon.Text = i + "";
            }
        }

        private void btnCong_tom_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTom.Text);
            i++;
            txtTom.Text = i + "";
        }

        private void btnTru_tom_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTom.Text);
            if (i > 0)
            {
                i--;
                txtTom.Text = i + "";
            }
        }

        private void btnCong_sunLon_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtSunLon.Text);
            i++;
            txtSunLon.Text = i + "";
        }

        private void btnTru_sunLon_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtSunLon.Text);
            if (i > 0)
            {
                i--;
                txtSunLon.Text = i + "";
            }
        }

        private void btnCong_keGa_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKeGa.Text);
            i++;
            txtKeGa.Text = i + "";
        }

        private void btnTru_keGa_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKeGa.Text);
            if (i > 0)
            {
                i--;
                txtKeGa.Text = i + "";
            }
        }

        private void btnCong_nuocLau_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNuocLau.Text);
            i++;
            txtNuocLau.Text = i + "";
        }

        private void btnTru_nuocLau_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNuocLau.Text);
            if (i > 0)
            {
                i--;
                txtNuocLau.Text = i + "";
            }
        }

        private void btnCong_rau_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtRau.Text);
            i++;
            txtRau.Text = i + "";
        }

        private void btnTru_rau_Click(object sender, EventArgs e)
        {

            int i = int.Parse(txtRau.Text);
            if (i > 0)
            {
                i--;
                txtRau.Text = i + "";
            }
        }

        private void btnCong_nam_Click(object sender, EventArgs e)
        {

            int i = int.Parse(txtNam.Text);
            i++;
            txtNam.Text = i + "";
        }

        private void btnTru_nam_Click(object sender, EventArgs e)
        {

            int i = int.Parse(txtNam.Text);
            if (i > 0)
            {
                i--;
                txtNam.Text = i + "";
            }
        }

        private void btnCong_xoiChien_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtXoiChien.Text);
            i++;
            txtXoiChien.Text = i + "";
        }

        private void btnTru_xoiChien_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtXoiChien.Text);
            if (i > 0)
            {
                i--;
                txtXoiChien.Text = i + "";
            }
            
        }

        private void btnCong_khoaiLang_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKhoaiLang.Text);
            i++;
            txtKhoaiLang.Text = i + "";
        }

        private void btnTru_khoaiLang_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtKhoaiLang.Text);
            if (i > 0)
            {
                i--;
                txtKhoaiLang.Text = i + "";
            }
        }
        public SanPham getSP(string tenSP)
        {
            int dem = 0;
            SanPham sp= new SanPham();
            foreach(SanPham item in lst_sanPham)
            {
                if (item.tenSP.Equals(tenSP))
                {
                    ++dem;
                    sp = item;
                    break;
                }
                    
                   
            }
            if (dem != 0)
                return sp;
            else
                return null;
            
            
        }
        public SanPham checkSP(string tenSP)
        {
            get_list_order();
            foreach (SanPham item in lst_sanPham_order)
            {
                if (item.tenSP.Equals(tenSP))
                    return item;
            }
            return null;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // khi nhân nút đặt món kiểm tra xem nếu món đó đã có trng hóa đơn thì update lại
            // nếu không có thì Insert vào hóa đơn
            
            if(txtLauCua.Text != "0")
            {
                SanPham sp = getSP("Lẩu cua");
                int msp = sp.maSP;
                int sl = int.Parse(txtLauCua.Text);
                if (checkSP("Lẩu cua") == null)
                {
                    
                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD, msp, sl, dg, _maNV);
                   
                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Lẩu cua");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);
                    
                    bus.ExecuteNonQuery(sql);
                }
                
                getDGV();
                get_list_order();
                getTongTien();
                txtLauCua.Text = "0";
               
            }
            if (txtKhanUot.Text != "0")
            {
                SanPham sp = getSP("Khăn ướt");
                int msp = sp.maSP;
                int sl = int.Parse(txtKhanUot.Text);
                if (checkSP("Khăn ướt") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD, msp, sl, dg, _maNV);
                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Khăn ướt");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);
                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtKhanUot.Text = "0";

            }
            if (txtThitBo.Text != "0")
            {
                SanPham sp = getSP("Thịt bò");
                int msp = sp.maSP;
                int sl = int.Parse(txtThitBo.Text);
                if (checkSP("Thịt bò") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Thịt bò");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtThitBo.Text = "0";

            }
            if (txtTrangLon.Text != "0")
            {
                SanPham sp = getSP("Tràng lợn");
                int msp = sp.maSP;
                int sl = int.Parse(txtTrangLon.Text);
                if (checkSP("Tràng lợn") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Tràng lợn");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtTrangLon.Text = "0";

            }
            if (txtTom.Text != "0")
            {
                SanPham sp = getSP("Tôm");
                int msp = sp.maSP;
                int sl = int.Parse(txtTom.Text);
                if (checkSP("Tôm") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Tôm");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtTom.Text = "0";

            }
            if (txtSunLon.Text != "0")
            {
                SanPham sp = getSP("Sụn");
                int msp = sp.maSP;
                int sl = int.Parse(txtSunLon.Text);
                if (checkSP("Sụn") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Sụn");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtSunLon.Text = "0";

            }
            if (txtKeGa.Text != "0")
            {
                SanPham sp = getSP("Kê gà");
                int msp = sp.maSP;
                int sl = int.Parse(txtKeGa.Text);
                if (checkSP("Kê gà") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Kê gà");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtKeGa.Text = "0";

            }
            if (txtKeGa.Text != "0")
            {
                SanPham sp = getSP("Nước lẩu");
                int msp = sp.maSP;
                int sl = int.Parse(txtNuocLau.Text);
                if (checkSP("Nước lẩu") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Nước lẩu");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtNuocLau.Text = "0";

            }
            if (txtRau.Text != "0")
            {
                SanPham sp = getSP("Rau");
                int msp = sp.maSP;
                int sl = int.Parse(txtRau.Text);
                if (checkSP("Rau") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Rau");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtRau.Text = "0";

            }
            if (txtNam.Text != "0")
            {
                SanPham sp = getSP("Nấm");
                int msp = sp.maSP;
                int sl = int.Parse(txtNam.Text);
                if (checkSP("Nấm") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Nấm");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtNam.Text = "0";

            }
            if (txtXoiChien.Text != "0")
            {
                SanPham sp = getSP("Xôi chiên");
                int msp = sp.maSP;
                int sl = int.Parse(txtXoiChien.Text);
                if (checkSP("Xôi chiên") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Xôi chiên");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtXoiChien.Text = "0";

            }

            if (txtKhoaiLang.Text != "0")
            {
                SanPham sp = getSP("Khoai lang kén");
                int msp = sp.maSP;
                int sl = int.Parse(txtKhoaiLang.Text);
                if (checkSP("Khoai lang kén") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Khoai lang kén");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtKhoaiLang.Text = "0";

            }
            if (txtNgoChien.Text != "0")
            {
                SanPham sp = getSP("Ngô chiên");
                int msp = sp.maSP;
                int sl = int.Parse(txtNgoChien.Text);
                if (checkSP("Ngô chiên") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Ngô chiên");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtNgoChien.Text = "0";

            }
            if (txtDuaChuot.Text != "0")
            {
                SanPham sp = getSP("Dưa chuột");
                int msp = sp.maSP;
                int sl = int.Parse(txtDuaChuot.Text);
                if (checkSP("Dưa chuột") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Dưa chuột");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtDuaChuot.Text = "0";

            }

            if (txtVoska.Text != "0")
            {
                SanPham sp = getSP("Rượu voska");
                int msp = sp.maSP;
                int sl = int.Parse(txtVoska.Text);
                if (checkSP("Rượu voska") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Rượu voska");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtVoska.Text = "0";

            }

            if (txtTaoMeo.Text != "0")
            {
                SanPham sp = getSP("Rượu táo");
                int msp = sp.maSP;
                int sl = int.Parse(txtTaoMeo.Text);
                if (checkSP("Rượu táo") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Rượu táo");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtTaoMeo.Text = "0";

            }
            if (txtNep.Text != "0")
            {
                SanPham sp = getSP("Rượu nếp");
                int msp = sp.maSP;
                int sl = int.Parse(txtNep.Text);
                if (checkSP("Rượu nếp") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Rượu nếp");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtNep.Text = "0";

            }
            if (txtLavie.Text != "0")
            {
                SanPham sp = getSP("Lavi");
                int msp = sp.maSP;
                int sl = int.Parse(txtLavie.Text);
                if (checkSP("Lavi") == null)
                {

                    int dg = sp.donGia;
                    string sql = string.Format("Insert into ChiTietHD values('{0}', {1}, {2}, {3}, '{4}' )", _maHD.Trim(), msp, sl, dg, _maNV);

                    bus.ExecuteNonQuery(sql);
                }
                else
                {
                    SanPham sp1 = checkSP("Lavi");
                    int sl1 = sp1.soLuong + sl;
                    string sql = string.Format("Update ChiTietHD set soLuong = {0}, maNV = '{1}' where maHD = '{2}' and maSP = {3}", sl1, _maNV, _maHD, msp);

                    bus.ExecuteNonQuery(sql);
                }
                getDGV();
                get_list_order();
                getTongTien();
                txtLavie.Text = "0";

            }

        }


        public void clean()
        {
            txtLauCua.Text = "0";
            txtKhanUot.Text = "0";
            txtThitBo.Text = "0";
            txtTrangLon.Text = "0";
            txtTom.Text = "0";
            txtSunLon.Text = "0";
            txtKeGa.Text = "0";
            txtNuocLau.Text = txtRau.Text = "0";
            txtNam.Text = txtXoiChien.Text = txtKhoaiLang.Text = "0";
            txtNgoChien.Text = txtDuaChuot.Text = txtVoska.Text = "0";
            txtTaoMeo.Text = txtNep.Text = txtLavie.Text = "0";

        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            clean();
            txtMaHD.Text = _maHD;
            txtKhachHang.Text = _tenKH;
            txtDiaChi.Text = _diaChi;
            txtSDT.Text = _sdt;
            txtMaNV.Text = _maNV;
            dtpNgayNhap.Text = _ngayNhap;
            get_list_order();
            getDGV();
            getListSP();
            getTongTien();

        }

        private void btnCong_NgoChien_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNgoChien.Text);
            i++;
            txtNgoChien.Text = i + "";
        }

        private void btnTru_NgoChien_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNgoChien.Text);
            if (i > 0)
            {
                i--;
                txtNgoChien.Text = i + "";
            }
        }

        private void btnCong_DuaChuot_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtDuaChuot.Text);
            i++;
            txtDuaChuot.Text = i + "";
        }

        private void btnCong_Voska_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtVoska.Text);
            i++;
            txtVoska.Text = i + "";
        }

        private void btnCong_TaoMeo_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTaoMeo.Text);
            i++;
            txtTaoMeo.Text = i + "";
        }

        private void btnCong_Nep_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNep.Text);
            i++;
            txtNep.Text = i + "";
        }

        private void btnCong_Lavie_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtLavie.Text);
            i++;
            txtLavie.Text = i + "";
        }

        private void btnTru_DuaChuot_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtDuaChuot.Text);
            if (i > 0)
            {
                i--;
                txtDuaChuot.Text = i + "";
            }
        }

        private void btnTru_Voska_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtVoska.Text);
            if (i > 0)
            {
                i--;
                txtVoska.Text = i + "";
            }
        }

        private void btnTru_TaoMeo_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtTaoMeo.Text);
            if (i > 0)
            {
                i--;
                txtTaoMeo.Text = i + "";
            }
        }

        private void btnTru_Nep_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtNep.Text);
            if (i > 0)
            {
                i--;
                txtNep.Text = i + "";
            }
        }

        private void btnTru_Lavie_Click(object sender, EventArgs e)
        {
            int i = int.Parse(txtLavie.Text);
            if (i > 0)
            {
                i--;
                txtLavie.Text = i + "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frmInHoaDon frm = new frmInHoaDon(_maHD);
            frm.Show();
        }

        private void getTongTien()
        {
            float sum = 0;
            for (int i = 0; i < lst_sanPham_order.Count; i++)
            {
                sum += (lst_sanPham_order[i].donGia * lst_sanPham_order[i].soLuong);
            }
            txtTongTien.Text = sum + " 000 VND";
        }

        public DataTable tblChiTiet()
        {
            String sql = string.Format("select ChiTietHD.maSP, tenSP, ChiTietHD.soLuong, donGia, (ChiTietHD.soLuong*donGia) as 'tongTien' from ChiTietHD inner join SanPham on ChiTietHD.maSP = SanPham.maSP where maHD = '{0}'", _maHD.Trim());
            DataTable dt = bus.get_Bang(sql);
            
            return dt;
        }
        public void getDGV()
        {
            DataTable dt = tblChiTiet();
            dgvBill.DataSource = dt;
        }
        public void get_list_order()
        {
            lst_sanPham_order = new List<SanPham>();
            DataTable dt = tblChiTiet();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                int msp = int.Parse(dr[0].ToString().Trim());
                string tsp = dr[1].ToString().Trim();
                int sl = int.Parse(dr[2].ToString().Trim());
                int dg = int.Parse(dr[3].ToString().Trim());

                lst_sanPham_order.Add(new SanPham(msp, tsp, sl, dg));
            }

        }
        public void getListSP()
        {
            String sql = String.Format("Select maSP, tenSP, soLuong, donGia from SanPham");
            DataTable dt = bus.get_Bang(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                int msp = int.Parse(dr[0].ToString().Trim());
                string tsp = dr[1].ToString().Trim();
                int sl = int.Parse(dr[2].ToString().Trim());
                int dg = int.Parse(dr[3].ToString().Trim());

                lst_sanPham.Add(new SanPham(msp, tsp, sl, dg));
            }

        }
        
    }
}
