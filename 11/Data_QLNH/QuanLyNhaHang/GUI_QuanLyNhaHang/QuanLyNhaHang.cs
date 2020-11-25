using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyNhaHang
{
    public partial class QuanLyNhaHang : Form
    {
        String _user;
        public QuanLyNhaHang(String user)
        {
            this._user = user;
            InitializeComponent();
        }
        public QuanLyNhaHang()
        {
            InitializeComponent();
            
        }

        private void QuanLyNhaHang_Load(object sender, EventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon(_user);
            frm.MdiParent = this;
            frm.Show();
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaHoaDon frm = new XoaHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang frm = new QuanLiKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaHoaDon frm = new SuaHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhaCC frm = new QuanLyNhaCC();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
