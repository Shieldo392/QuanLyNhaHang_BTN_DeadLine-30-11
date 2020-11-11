using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QuanLyNhaHang
{
    public class SanPham
    {
        protected int _masp, _soLuong, _donGia;
        protected String _tenSP;

        public SanPham()
        {
        }

        public SanPham(int masp, string tenSP, int soLuong, int donGia)
        {
            _masp = masp;
            _soLuong = soLuong;
            _donGia = donGia;
            _tenSP = tenSP;
        }
        public int maSP
        {
            get { return this._masp; }
            set { this._masp = value; }
        }

        public String tenSP
        {
            get { return this._tenSP; }
            set { this._tenSP = value; }
        }
        public int soLuong
        {
            get { return this._soLuong; }
            set { this._soLuong = value; }
        }
        public int donGia
        {
            get { return this._donGia; }
            set { this._donGia = value; }
        }

    }
}
