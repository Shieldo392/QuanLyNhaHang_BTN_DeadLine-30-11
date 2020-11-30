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
        int _code;
        public QuanLyNhaHang(String user, int code)
        {
            this._code = code;
            this._user = user;
            InitializeComponent();
        }
        public QuanLyNhaHang()
        {
            InitializeComponent();
            
        }

        private void QuanLyNhaHang_Load(object sender, EventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon(_user, _code);
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham(_code);
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon(_user, _code);
            frm.MdiParent = this;
            frm.Show();
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_code == 0)
            {
                MessageBox.Show("Bạn phải là Quản lý mới có thể xóa được hóa đơn!");
                return;
            }
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
            if (_code == 0)
            {
                MessageBox.Show("Bạn phải là Quản lý mới có thể sửa được hóa đơn!");
                return;
            }
            SuaHoaDon frm = new SuaHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham(_code);
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhaCC frm = new QuanLyNhaCC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeNhapHang frm = new ThongKeNhapHang(_code);
            frm.Show();
            frm.MdiParent = this;
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien frm = new ThongTinNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(_code == 0)
            {
                MessageBox.Show("Bạn phải là Quản lý mới có thể sửa được hóa đơn!");
                return;
            }
            QuanLyNhanVien frm = new QuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThongTinNhanVien frm = new ThongTinNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_code == 0)
            {
                MessageBox.Show("Bạn phải là Quản lý mới có thể sửa được hóa đơn!");
                return;
            }
            ThongTinQuanLy frm = new ThongTinQuanLy();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
