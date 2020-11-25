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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // QuanLyHoaDon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}