namespace GUI_QuanLyNhaHang
{
    partial class QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dgvQLHD = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenKHFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtmaHD
            // 
            resources.ApplyResources(this.txtmaHD, "txtmaHD");
            this.txtmaHD.Name = "txtmaHD";
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            resources.ApplyResources(this.cboTenKH, "cboTenKH");
            this.cboTenKH.Name = "cboTenKH";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dtpNgayNhap
            // 
            resources.ApplyResources(this.dtpNgayNhap, "dtpNgayNhap");
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.tenKH,
            this.diaChi,
            this.sdt,
            this.ngayNhap});
            resources.ApplyResources(this.dgvQLHD, "dgvQLHD");
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLHD_CellDoubleClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            resources.ApplyResources(this.maHD, "maHD");
            this.maHD.Name = "maHD";
            // 
            // tenKH
            // 
            this.tenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKH.DataPropertyName = "tenKH";
            resources.ApplyResources(this.tenKH, "tenKH");
            this.tenKH.Name = "tenKH";
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            resources.ApplyResources(this.diaChi, "diaChi");
            this.diaChi.Name = "diaChi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            resources.ApplyResources(this.sdt, "sdt");
            this.sdt.Name = "sdt";
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "ngayNhap";
            resources.ApplyResources(this.ngayNhap, "ngayNhap");
            this.ngayNhap.Name = "ngayNhap";
            // 
            // txtTenKHFind
            // 
            resources.ApplyResources(this.txtTenKHFind, "txtTenKHFind");
            this.txtTenKHFind.Name = "txtTenKHFind";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnThemMoi
            // 
            resources.ApplyResources(this.btnThemMoi, "btnThemMoi");
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            resources.ApplyResources(this.btnTimKiem, "btnTimKiem");
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            resources.ApplyResources(this.đăngXuấtToolStripMenuItem, "đăngXuấtToolStripMenuItem");
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            resources.ApplyResources(this.thoátToolStripMenuItem, "thoátToolStripMenuItem");
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem1,
            this.thêmMớiNhânViênToolStripMenuItem,
            this.sửaNhânViênToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            resources.ApplyResources(this.quảnLýNhânViênToolStripMenuItem, "quảnLýNhânViênToolStripMenuItem");
            // 
            // quảnLýNhânViênToolStripMenuItem1
            // 
            this.quảnLýNhânViênToolStripMenuItem1.Name = "quảnLýNhânViênToolStripMenuItem1";
            resources.ApplyResources(this.quảnLýNhânViênToolStripMenuItem1, "quảnLýNhânViênToolStripMenuItem1");
            // 
            // thêmMớiNhânViênToolStripMenuItem
            // 
            this.thêmMớiNhânViênToolStripMenuItem.Name = "thêmMớiNhânViênToolStripMenuItem";
            resources.ApplyResources(this.thêmMớiNhânViênToolStripMenuItem, "thêmMớiNhânViênToolStripMenuItem");
            // 
            // sửaNhânViênToolStripMenuItem
            // 
            this.sửaNhânViênToolStripMenuItem.Name = "sửaNhânViênToolStripMenuItem";
            resources.ApplyResources(this.sửaNhânViênToolStripMenuItem, "sửaNhânViênToolStripMenuItem");
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            resources.ApplyResources(this.xóaNhânViênToolStripMenuItem, "xóaNhânViênToolStripMenuItem");
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
            resources.ApplyResources(this.hóaĐơnToolStripMenuItem, "hóaĐơnToolStripMenuItem");
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            resources.ApplyResources(this.quảnLýHóaĐơnToolStripMenuItem, "quảnLýHóaĐơnToolStripMenuItem");
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            resources.ApplyResources(this.thốngKêHóaĐơnToolStripMenuItem, "thốngKêHóaĐơnToolStripMenuItem");
            // 
            // sửaHóaĐơnToolStripMenuItem
            // 
            this.sửaHóaĐơnToolStripMenuItem.Name = "sửaHóaĐơnToolStripMenuItem";
            resources.ApplyResources(this.sửaHóaĐơnToolStripMenuItem, "sửaHóaĐơnToolStripMenuItem");
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            resources.ApplyResources(this.xóaHóaĐơnToolStripMenuItem, "xóaHóaĐơnToolStripMenuItem");
            // 
            // thêmMớiHDToolStripMenuItem
            // 
            this.thêmMớiHDToolStripMenuItem.Name = "thêmMớiHDToolStripMenuItem";
            resources.ApplyResources(this.thêmMớiHDToolStripMenuItem, "thêmMớiHDToolStripMenuItem");
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSảnPhẩmToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.thêmMớiSảnPhẩmToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            resources.ApplyResources(this.sảnPhẩmToolStripMenuItem, "sảnPhẩmToolStripMenuItem");
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            this.thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            resources.ApplyResources(this.thốngKêSảnPhẩmToolStripMenuItem, "thốngKêSảnPhẩmToolStripMenuItem");
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            resources.ApplyResources(this.quảnLýSảnPhẩmToolStripMenuItem, "quảnLýSảnPhẩmToolStripMenuItem");
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // thêmMớiSảnPhẩmToolStripMenuItem
            // 
            this.thêmMớiSảnPhẩmToolStripMenuItem.Name = "thêmMớiSảnPhẩmToolStripMenuItem";
            resources.ApplyResources(this.thêmMớiSảnPhẩmToolStripMenuItem, "thêmMớiSảnPhẩmToolStripMenuItem");
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thêmMớiKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            resources.ApplyResources(this.kháchHàngToolStripMenuItem, "kháchHàngToolStripMenuItem");
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            resources.ApplyResources(this.thôngTinKháchHàngToolStripMenuItem, "thôngTinKháchHàngToolStripMenuItem");
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thêmMớiKháchHàngToolStripMenuItem
            // 
            this.thêmMớiKháchHàngToolStripMenuItem.Name = "thêmMớiKháchHàngToolStripMenuItem";
            resources.ApplyResources(this.thêmMớiKháchHàngToolStripMenuItem, "thêmMớiKháchHàngToolStripMenuItem");
            // 
            // hóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.hóaĐơnNhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêHóaĐơnNhậpToolStripMenuItem,
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem});
            this.hóaĐơnNhậpHàngToolStripMenuItem.Name = "hóaĐơnNhậpHàngToolStripMenuItem";
            resources.ApplyResources(this.hóaĐơnNhậpHàngToolStripMenuItem, "hóaĐơnNhậpHàngToolStripMenuItem");
            // 
            // thốngKêHóaĐơnNhậpToolStripMenuItem
            // 
            this.thốngKêHóaĐơnNhậpToolStripMenuItem.Name = "thốngKêHóaĐơnNhậpToolStripMenuItem";
            resources.ApplyResources(this.thốngKêHóaĐơnNhậpToolStripMenuItem, "thốngKêHóaĐơnNhậpToolStripMenuItem");
            // 
            // thêmMớiHóaĐơnNhậpToolStripMenuItem
            // 
            this.thêmMớiHóaĐơnNhậpToolStripMenuItem.Name = "thêmMớiHóaĐơnNhậpToolStripMenuItem";
            resources.ApplyResources(this.thêmMớiHóaĐơnNhậpToolStripMenuItem, "thêmMớiHóaĐơnNhậpToolStripMenuItem");
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhàCungCấpToolStripMenuItem});
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            resources.ApplyResources(this.nhàCungCấpToolStripMenuItem, "nhàCungCấpToolStripMenuItem");
            // 
            // thôngTinNhàCungCấpToolStripMenuItem
            // 
            this.thôngTinNhàCungCấpToolStripMenuItem.Name = "thôngTinNhàCungCấpToolStripMenuItem";
            resources.ApplyResources(this.thôngTinNhàCungCấpToolStripMenuItem, "thôngTinNhàCungCấpToolStripMenuItem");
            // 
            // QuanLyHoaDon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenKHFind);
            this.Controls.Add(this.dgvQLHD);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTenKH);
            this.Controls.Add(this.txtmaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.DataGridView dgvQLHD;
        private System.Windows.Forms.TextBox txtTenKHFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
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
    }
}