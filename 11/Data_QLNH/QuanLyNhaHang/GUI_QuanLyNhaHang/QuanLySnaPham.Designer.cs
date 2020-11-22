
namespace GUI_QuanLyNhaHang
{
    partial class QuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng còn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà cung cấp";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(180, 142);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(160, 26);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(180, 197);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(280, 26);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(638, 139);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 26);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(638, 204);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(200, 26);
            this.txtDonGia.TabIndex = 9;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(180, 249);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(180, 27);
            this.cboNCC.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(123, 303);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 31);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(223, 303);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 31);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(329, 305);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 29);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(442, 303);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 31);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.tenSP,
            this.soLuong,
            this.donGia,
            this.tenNCC});
            this.dgvSanPham.Location = new System.Drawing.Point(79, 357);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(899, 313);
            this.dgvSanPham.TabIndex = 15;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // maSP
            // 
            this.maSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã SP";
            this.maSP.Name = "maSP";
            this.maSP.ReadOnly = true;
            // 
            // tenSP
            // 
            this.tenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên SP";
            this.tenSP.Name = "tenSP";
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng còn";
            this.soLuong.Name = "soLuong";
            // 
            // donGia
            // 
            this.donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // tenNCC
            // 
            this.tenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Nhà Cung cấp";
            this.tenNCC.Name = "tenNCC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.hóaĐơnNhậpHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem1,
            this.thêmMớiNhânViênToolStripMenuItem,
            this.sửaNhânViênToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // quảnLýNhânViênToolStripMenuItem1
            // 
            this.quảnLýNhânViênToolStripMenuItem1.Name = "quảnLýNhânViênToolStripMenuItem1";
            this.quảnLýNhânViênToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.quảnLýNhânViênToolStripMenuItem1.Text = "Quản lý Nhân viên";
            // 
            // thêmMớiNhânViênToolStripMenuItem
            // 
            this.thêmMớiNhânViênToolStripMenuItem.Name = "thêmMớiNhânViênToolStripMenuItem";
            this.thêmMớiNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thêmMớiNhânViênToolStripMenuItem.Text = "Thêm mới nhân viên";
            // 
            // sửaNhânViênToolStripMenuItem
            // 
            this.sửaNhânViênToolStripMenuItem.Name = "sửaNhânViênToolStripMenuItem";
            this.sửaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sửaNhânViênToolStripMenuItem.Text = "Sửa Nhân viên";
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa nhân viên";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thốngKêHóaĐơnToolStripMenuItem,
            this.sửaHóaĐơnToolStripMenuItem,
            this.xóaHóaĐơnToolStripMenuItem,
            this.thêmMớiHDToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            this.thốngKêHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thốngKêHóaĐơnToolStripMenuItem.Text = "Thống kê hóa đơn";
            // 
            // sửaHóaĐơnToolStripMenuItem
            // 
            this.sửaHóaĐơnToolStripMenuItem.Name = "sửaHóaĐơnToolStripMenuItem";
            this.sửaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sửaHóaĐơnToolStripMenuItem.Text = "Sửa hóa đơn";
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            this.xóaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.xóaHóaĐơnToolStripMenuItem.Text = "Xóa hóa đơn";
            // 
            // thêmMớiHDToolStripMenuItem
            // 
            this.thêmMớiHDToolStripMenuItem.Name = "thêmMớiHDToolStripMenuItem";
            this.thêmMớiHDToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thêmMớiHDToolStripMenuItem.Text = "Thêm mới HD";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSảnPhẩmToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.thêmMớiSảnPhẩmToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            this.thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            this.thốngKêSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống kê sản phẩm";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // thêmMớiSảnPhẩmToolStripMenuItem
            // 
            this.thêmMớiSảnPhẩmToolStripMenuItem.Name = "thêmMớiSảnPhẩmToolStripMenuItem";
            this.thêmMớiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thêmMớiSảnPhẩmToolStripMenuItem.Text = "Thêm mới sản phẩm";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thêmMớiKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            // 
            // thêmMớiKháchHàngToolStripMenuItem
            // 
            this.thêmMớiKháchHàngToolStripMenuItem.Name = "thêmMớiKháchHàngToolStripMenuItem";
            this.thêmMớiKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.thêmMớiKháchHàngToolStripMenuItem.Text = "Thêm mới khách hàng";
            // 
            // hóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.hóaĐơnNhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêHóaĐơnNhậpToolStripMenuItem,
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem});
            this.hóaĐơnNhậpHàngToolStripMenuItem.Name = "hóaĐơnNhậpHàngToolStripMenuItem";
            this.hóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.hóaĐơnNhậpHàngToolStripMenuItem.Text = "Hóa đơn nhập hàng";
            // 
            // thốngKêHóaĐơnNhậpToolStripMenuItem
            // 
            this.thốngKêHóaĐơnNhậpToolStripMenuItem.Name = "thốngKêHóaĐơnNhậpToolStripMenuItem";
            this.thốngKêHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.thốngKêHóaĐơnNhậpToolStripMenuItem.Text = "Thống kê hóa đơn nhập";
            // 
            // thêmMớiHóaĐơnNhậpToolStripMenuItem
            // 
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem.Name = "thêmMớiHóaĐơnNhậpToolStripMenuItem";
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem.Text = "Thêm mới hóa đơn nhập";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // thôngTinNhàCungCấpToolStripMenuItem
            // 
            this.thôngTinNhàCungCấpToolStripMenuItem.Name = "thôngTinNhàCungCấpToolStripMenuItem";
            this.thôngTinNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.thôngTinNhàCungCấpToolStripMenuItem.Text = "Thông tin nhà cung cấp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(707, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tên SP";
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.Location = new System.Drawing.Point(876, 311);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 31);
            this.btnTim.TabIndex = 45;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 698);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySanPham";
            this.Text = " Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiHDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTim;
    }
}