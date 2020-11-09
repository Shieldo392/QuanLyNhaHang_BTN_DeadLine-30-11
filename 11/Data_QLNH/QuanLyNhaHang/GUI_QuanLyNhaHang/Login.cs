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
    public partial class Login : Form
    {
        Bus_QLNH bus = new Bus_QLNH();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd*//*.Show();*/
            string user = txtUser.Text.ToString().Trim();
            string pass = txtPass.Text.ToString().Trim();
            if (radNhanVien.Checked)
            {
                if (bus.check_nv(user, pass) == true)
                {
                    QuanLyHoaDon frm = new QuanLyHoaDon();
                    frm.Show();
                }
                else
                    MessageBox.Show("Kiểm tra tài khoản mật khẩu!");
            }
        }
    }
}