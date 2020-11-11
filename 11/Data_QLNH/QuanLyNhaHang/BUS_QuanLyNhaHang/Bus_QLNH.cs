using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaHang;

namespace BUS_QuanLyNhaHang
{
    public class Bus_QLNH
    {
        List<NhanVien> lst_nv = new List<NhanVien>();
        Dal_QLNH dal = new Dal_QLNH();

        public object MessageBox { get; private set; }

        // chuyển dữ liệu nhân viên sang từ sql sang list 

        //Lay thong tin nhan vien
        public DataTable tblNhanVien()
        {
            string sql = "Select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void read_data_nv()
        {
            DataTable dt = tblNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string manv = dr[0].ToString().Trim();
                string matKhau = dr[1].ToString().Trim();
                string tenNv = dr[2].ToString().Trim();
                string gioiTinh = dr[3].ToString().Trim();
                string diaChi = dr[4].ToString().Trim();
                int namSinh = Int32.Parse(dr[5].ToString().Trim());
                lst_nv.Add(new NhanVien(manv, matKhau, tenNv, gioiTinh, diaChi, namSinh));
            }
        }
        public void insert_NhanVien(string manv, string matKhau, string ten, string gt, string diaChi, int namSinh, string sdt)
        {
            string sql = string.Format("insert table NhanVien values ({0}, {1}, N'{2}', N'{3}', N'{4}', {5}, '{6}')", manv, matKhau, ten, gt, diaChi, namSinh, sdt);
            dal.ExecuteNonQuery(sql);
        }
        public void update_NhanVien(string maNV, string matKhau, string ten, string gt, string diaChi, int namSinh, string sdt)
        {
            string sql = string.Format("Update NhanVien set matKhau = '{0}', tenNV = N'{1}', gioiTinh = N'{2}', diaChi = N'{3}'," +
                                    " namSinh = {4}, sdt = '{5}" +
                                        "where maNv = {6}", matKhau, ten, gt, diaChi, namSinh, sdt, maNV);
            dal.ExecuteNonQuery(sql);
        }
        public void delete_NhanVien(string maNV)
        {
            string sql = string.Format("Delete NhanVien where maNv = '{0}'", maNV);
            dal.ExecuteNonQuery(sql);
        }
        public DataTable find_NhanVien(string tenNV)
        {
            string sql = string.Format("Select * from NhanVien where tenNv = N'{0}'", tenNV);
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public Boolean check_nv(string user, string pass)
        {
            read_data_nv();
            foreach (NhanVien item in lst_nv)
            {
                if (item.maNV.Equals(user) && item.matKhau.Equals(pass))
                    return true;
            }

            return false;
        }
        public DataTable tblQuanLyHoaDon()
        {
            string sql = string.Format("Select HoaDon.maHD , tenKH, KhachHang.diaChi, KhachHang.sdt, HoaDon.ngayNhap from HoaDon inner join KhachHang on HoaDon.maKH = KhachHang.maKH");
            DataTable dt = dal.getTable(sql);
            return dt;
        }
        public DataTable tblKhachHang()
        {
            string sql = string.Format("Select maKH, tenKH from KhachHang");
            DataTable dt = dal.getTable(sql);
            return dt;
        }
        public void insert_HoaDon(string mahd, int maKH, string ngayNhap)
        {
            String sql = string.Format("Insert into HoaDon values('{0}',  '{1}', {2})", mahd, ngayNhap, maKH);
            dal.ExecuteNonQuery(sql);
        }
        public DataTable get_Bang(String sql)
        {
            return dal.getTable(sql);
        }
        public void ExecuteNonQuery(string sql)
        {
            dal.ExecuteNonQuery(sql);
        }
    }
}
