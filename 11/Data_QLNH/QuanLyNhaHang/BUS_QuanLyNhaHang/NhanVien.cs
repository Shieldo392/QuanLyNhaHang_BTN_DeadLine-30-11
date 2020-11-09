using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyNhaHang
{
    public class NhanVien
    {
        private string _maNV, _matKhau, _tenNV, _gioiTinh, _diaChi;
        private int _namSinh;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string matKhau, string tenNV, string gioiTinh, string diaChi, int namSinh)
        {
            this._maNV = maNV;
            this._matKhau = matKhau;
            this._tenNV = tenNV;
            this._gioiTinh = gioiTinh;
            this._diaChi = diaChi;
            this._namSinh = namSinh;
        }
        public string maNV
        {
            get { return this._maNV; }
            set { this._maNV = value; }
        }
        public string matKhau
        {
            get { return this._matKhau; }
            set { this._matKhau = value; }
        }
        public string tenNV
        {
            get { return this._tenNV; }
            set { this._tenNV = value; }
        }
        public string gioiTinh
        {
            get { return this._gioiTinh; }
            set { this._gioiTinh = value; }
        }
        public string diaChi
        {
            get { return this._diaChi; }
            set { this._diaChi = value; }
        }
        public int namSinh
        {
            get { return this._namSinh; }
            set { this._namSinh = value; }
        }
    }
}
