namespace QuanLyTiemGiaoHoa.Forms
{
    partial class frmMain
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
            lblLienKet = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            thốngToolStripMenuItem = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuHoa = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuLoaiHoa = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuNhapHang = new ToolStripMenuItem();
            mnuGiaoHang = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip.Location = new Point(0, 599);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(1201, 26);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(980, 20);
            toolStripStatusLabel2.Spring = true;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(281, 26);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(281, 26);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(233, 26);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(233, 26);
            mnuThongKeSanPham.Text = "Thống kê sản phẩm...";
            // 
            // thốngToolStripMenuItem
            // 
            thốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            thốngToolStripMenuItem.Name = "thốngToolStripMenuItem";
            thốngToolStripMenuItem.Size = new Size(152, 24);
            thốngToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(225, 26);
            mnuHoaDon.Text = "Hóa đơn bán hàng...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(222, 6);
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(225, 26);
            mnuNhanVien.Text = "Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(225, 26);
            mnuKhachHang.Text = "Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(222, 6);
            // 
            // mnuHoa
            // 
            mnuHoa.Name = "mnuHoa";
            mnuHoa.Size = new Size(225, 26);
            mnuHoa.Text = "Hoa...";
            mnuHoa.Click += mnuHoa_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(225, 26);
            mnuNhaCungCap.Text = "Nhà cung cấp...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuLoaiHoa
            // 
            mnuLoaiHoa.Name = "mnuLoaiHoa";
            mnuLoaiHoa.Size = new Size(225, 26);
            mnuLoaiHoa.Text = "Loại hoa...";
            mnuLoaiHoa.Click += mnuLoaiHoa_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiHoa, mnuNhaCungCap, mnuHoa, mnuNhapHang, mnuGiaoHang, toolStripSeparator1, mnuKhachHang, mnuNhanVien, toolStripSeparator3, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(73, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhapHang
            // 
            mnuNhapHang.Name = "mnuNhapHang";
            mnuNhapHang.Size = new Size(225, 26);
            mnuNhapHang.Text = "Nhập hàng...";
            mnuNhapHang.Click += mnuNhapHang_Click;
            // 
            // mnuGiaoHang
            // 
            mnuGiaoHang.Name = "mnuGiaoHang";
            mnuGiaoHang.Size = new Size(225, 26);
            mnuGiaoHang.Text = "Giao hàng...";
            mnuGiaoHang.Click += mnuGiaoHang_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(224, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(224, 26);
            mnuDangNhap.Text = "Đăng nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator2, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, thốngToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 2, 0, 2);
            menuStrip.Size = new Size(1201, 28);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 625);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tiệm giao hoa tươi";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripStatusLabel lblLienKet;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem thốngToolStripMenuItem;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuHoa;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuLoaiHoa;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuThoat;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuHeThong;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuNhapHang;
        private ToolStripMenuItem mnuGiaoHang;
    }
}