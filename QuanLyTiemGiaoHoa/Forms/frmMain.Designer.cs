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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblLienKet = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeHoa = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeHoaBanChay = new ToolStripMenuItem();
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
            panelSidebar = new Panel();
            pnlSubBaoCaoThongKe = new Panel();
            btnThongKeHoaBanChay = new Button();
            btnThongKeDoanhThu = new Button();
            btnThongKeHoa = new Button();
            btnBaoCaoThongKe = new Button();
            imageList = new ImageList(components);
            pnlSubQuanLy = new Panel();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnGiaoHang = new Button();
            btnNhapHang = new Button();
            btnHoa = new Button();
            btnNhaCungCap = new Button();
            btnLoaiHoa = new Button();
            btnQuanLy = new Button();
            pnlSubHeThong = new Panel();
            btnDoiMatKhau = new Button();
            btnDangXuat = new Button();
            btnDangNhap = new Button();
            btnHeThong = new Button();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            panelSidebar.SuspendLayout();
            pnlSubBaoCaoThongKe.SuspendLayout();
            pnlSubQuanLy.SuspendLayout();
            pnlSubHeThong.SuspendLayout();
            SuspendLayout();
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(104, 22);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(141, 22);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.LavenderBlush;
            statusStrip.Font = new Font("Times New Roman", 12F);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip.Location = new Point(0, 845);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 20, 0);
            statusStrip.Size = new Size(1822, 28);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1556, 22);
            toolStripStatusLabel2.Spring = true;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.BackColor = Color.OldLace;
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(320, 26);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.BackColor = Color.PapayaWhip;
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(320, 26);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.BackColor = Color.LavenderBlush;
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Image = (Image)resources.GetObject("mnuTroGiup.Image");
            mnuTroGiup.ImageTransparentColor = Color.LavenderBlush;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(113, 26);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.BackColor = Color.OldLace;
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(287, 26);
            mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuThongKeHoa
            // 
            mnuThongKeHoa.BackColor = Color.PapayaWhip;
            mnuThongKeHoa.Name = "mnuThongKeHoa";
            mnuThongKeHoa.Size = new Size(287, 26);
            mnuThongKeHoa.Text = "Thống kê hoa...";
            mnuThongKeHoa.Click += mnuThongKeHoa_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.BackColor = Color.LavenderBlush;
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeHoa, mnuThongKeDoanhThu, mnuThongKeHoaBanChay });
            mnuBaoCaoThongKe.Image = (Image)resources.GetObject("mnuBaoCaoThongKe.Image");
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(198, 26);
            mnuBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeHoaBanChay
            // 
            mnuThongKeHoaBanChay.BackColor = Color.PapayaWhip;
            mnuThongKeHoaBanChay.Name = "mnuThongKeHoaBanChay";
            mnuThongKeHoaBanChay.Size = new Size(287, 26);
            mnuThongKeHoaBanChay.Text = "Thống kê hoa bán chạy...";
            mnuThongKeHoaBanChay.Click += mnuThongKeHoaBanChay_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.BackColor = Color.OldLace;
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(251, 26);
            mnuHoaDon.Text = "Hóa đơn bán hàng...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(248, 6);
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.BackColor = Color.PapayaWhip;
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(251, 26);
            mnuNhanVien.Text = "Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.BackColor = Color.OldLace;
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(251, 26);
            mnuKhachHang.Text = "Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(248, 6);
            // 
            // mnuHoa
            // 
            mnuHoa.BackColor = Color.PapayaWhip;
            mnuHoa.Name = "mnuHoa";
            mnuHoa.Size = new Size(251, 26);
            mnuHoa.Text = "Hoa...";
            mnuHoa.Click += mnuHoa_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.BackColor = Color.OldLace;
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(251, 26);
            mnuNhaCungCap.Text = "Nhà cung cấp...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuLoaiHoa
            // 
            mnuLoaiHoa.BackColor = Color.PapayaWhip;
            mnuLoaiHoa.Name = "mnuLoaiHoa";
            mnuLoaiHoa.Size = new Size(251, 26);
            mnuLoaiHoa.Text = "Loại hoa...";
            mnuLoaiHoa.Click += mnuLoaiHoa_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.BackColor = Color.LavenderBlush;
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiHoa, mnuNhaCungCap, mnuHoa, mnuNhapHang, mnuGiaoHang, toolStripSeparator1, mnuKhachHang, mnuNhanVien, toolStripSeparator3, mnuHoaDon });
            mnuQuanLy.Image = (Image)resources.GetObject("mnuQuanLy.Image");
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(106, 26);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhapHang
            // 
            mnuNhapHang.BackColor = Color.OldLace;
            mnuNhapHang.Name = "mnuNhapHang";
            mnuNhapHang.Size = new Size(251, 26);
            mnuNhapHang.Text = "Nhập hàng...";
            mnuNhapHang.Click += mnuNhapHang_Click;
            // 
            // mnuGiaoHang
            // 
            mnuGiaoHang.BackColor = Color.PapayaWhip;
            mnuGiaoHang.Name = "mnuGiaoHang";
            mnuGiaoHang.Size = new Size(251, 26);
            mnuGiaoHang.Text = "Giao hàng...";
            mnuGiaoHang.Click += mnuGiaoHang_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = Color.OldLace;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(213, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(210, 6);
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.BackColor = Color.PapayaWhip;
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(213, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = Color.OldLace;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(213, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.BackColor = Color.PapayaWhip;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(213, 26);
            mnuDangNhap.Text = "Đăng nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.BackColor = Color.LavenderBlush;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator2, mnuThoat });
            mnuHeThong.ForeColor = Color.Black;
            mnuHeThong.Image = (Image)resources.GetObject("mnuHeThong.Image");
            mnuHeThong.ImageAlign = ContentAlignment.MiddleLeft;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(114, 26);
            mnuHeThong.Text = "Hệ thống";
            mnuHeThong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.LavenderBlush;
            menuStrip.Font = new Font("Times New Roman", 12F);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 2, 0, 2);
            menuStrip.Size = new Size(1822, 30);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.MistyRose;
            panelSidebar.Controls.Add(pnlSubBaoCaoThongKe);
            panelSidebar.Controls.Add(btnBaoCaoThongKe);
            panelSidebar.Controls.Add(pnlSubQuanLy);
            panelSidebar.Controls.Add(btnQuanLy);
            panelSidebar.Controls.Add(pnlSubHeThong);
            panelSidebar.Controls.Add(btnHeThong);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 30);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 815);
            panelSidebar.TabIndex = 6;
            // 
            // pnlSubBaoCaoThongKe
            // 
            pnlSubBaoCaoThongKe.BackColor = Color.PapayaWhip;
            pnlSubBaoCaoThongKe.Controls.Add(btnThongKeHoaBanChay);
            pnlSubBaoCaoThongKe.Controls.Add(btnThongKeDoanhThu);
            pnlSubBaoCaoThongKe.Controls.Add(btnThongKeHoa);
            pnlSubBaoCaoThongKe.Dock = DockStyle.Top;
            pnlSubBaoCaoThongKe.Location = new Point(0, 606);
            pnlSubBaoCaoThongKe.Name = "pnlSubBaoCaoThongKe";
            pnlSubBaoCaoThongKe.Size = new Size(250, 114);
            pnlSubBaoCaoThongKe.TabIndex = 5;
            pnlSubBaoCaoThongKe.Visible = false;
            // 
            // btnThongKeHoaBanChay
            // 
            btnThongKeHoaBanChay.BackColor = Color.Bisque;
            btnThongKeHoaBanChay.Dock = DockStyle.Top;
            btnThongKeHoaBanChay.FlatAppearance.BorderColor = Color.White;
            btnThongKeHoaBanChay.FlatAppearance.BorderSize = 2;
            btnThongKeHoaBanChay.FlatStyle = FlatStyle.Flat;
            btnThongKeHoaBanChay.ForeColor = SystemColors.ActiveCaptionText;
            btnThongKeHoaBanChay.Location = new Point(0, 68);
            btnThongKeHoaBanChay.Name = "btnThongKeHoaBanChay";
            btnThongKeHoaBanChay.Padding = new Padding(40, 0, 0, 0);
            btnThongKeHoaBanChay.Size = new Size(250, 35);
            btnThongKeHoaBanChay.TabIndex = 4;
            btnThongKeHoaBanChay.Text = "Thống kê hoa bán chạy";
            btnThongKeHoaBanChay.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeHoaBanChay.UseVisualStyleBackColor = false;
            btnThongKeHoaBanChay.Click += btnThongKeHoaBanChay_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.Dock = DockStyle.Top;
            btnThongKeDoanhThu.FlatAppearance.BorderColor = Color.White;
            btnThongKeDoanhThu.FlatAppearance.BorderSize = 2;
            btnThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btnThongKeDoanhThu.Location = new Point(0, 34);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Padding = new Padding(40, 0, 0, 0);
            btnThongKeDoanhThu.Size = new Size(250, 34);
            btnThongKeDoanhThu.TabIndex = 3;
            btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            btnThongKeDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnThongKeHoa
            // 
            btnThongKeHoa.BackColor = Color.Bisque;
            btnThongKeHoa.Dock = DockStyle.Top;
            btnThongKeHoa.FlatAppearance.BorderColor = Color.White;
            btnThongKeHoa.FlatAppearance.BorderSize = 2;
            btnThongKeHoa.FlatStyle = FlatStyle.Flat;
            btnThongKeHoa.Location = new Point(0, 0);
            btnThongKeHoa.Name = "btnThongKeHoa";
            btnThongKeHoa.Padding = new Padding(40, 0, 0, 0);
            btnThongKeHoa.Size = new Size(250, 34);
            btnThongKeHoa.TabIndex = 2;
            btnThongKeHoa.Text = "Thống kê hoa";
            btnThongKeHoa.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeHoa.UseVisualStyleBackColor = false;
            btnThongKeHoa.Click += btnThongKeHoa_Click;
            // 
            // btnBaoCaoThongKe
            // 
            btnBaoCaoThongKe.BackColor = Color.FromArgb(255, 192, 192);
            btnBaoCaoThongKe.Dock = DockStyle.Top;
            btnBaoCaoThongKe.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnBaoCaoThongKe.FlatAppearance.BorderSize = 5;
            btnBaoCaoThongKe.FlatStyle = FlatStyle.Flat;
            btnBaoCaoThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBaoCaoThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.ImageIndex = 10;
            btnBaoCaoThongKe.ImageList = imageList;
            btnBaoCaoThongKe.Location = new Point(0, 536);
            btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            btnBaoCaoThongKe.Padding = new Padding(10, 0, 0, 0);
            btnBaoCaoThongKe.Size = new Size(250, 70);
            btnBaoCaoThongKe.TabIndex = 4;
            btnBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            btnBaoCaoThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaoCaoThongKe.UseVisualStyleBackColor = false;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "home.png");
            imageList.Images.SetKeyName(1, "support_807303.png");
            imageList.Images.SetKeyName(2, "home_1946436.png");
            imageList.Images.SetKeyName(3, "add.png");
            imageList.Images.SetKeyName(4, "delete.png");
            imageList.Images.SetKeyName(5, "edit.png");
            imageList.Images.SetKeyName(6, "exit.png");
            imageList.Images.SetKeyName(7, "refresh.png");
            imageList.Images.SetKeyName(8, "save.png");
            imageList.Images.SetKeyName(9, "edit (1).png");
            imageList.Images.SetKeyName(10, "chart-histogram.png");
            // 
            // pnlSubQuanLy
            // 
            pnlSubQuanLy.BackColor = Color.PapayaWhip;
            pnlSubQuanLy.Controls.Add(btnHoaDon);
            pnlSubQuanLy.Controls.Add(btnNhanVien);
            pnlSubQuanLy.Controls.Add(btnKhachHang);
            pnlSubQuanLy.Controls.Add(btnGiaoHang);
            pnlSubQuanLy.Controls.Add(btnNhapHang);
            pnlSubQuanLy.Controls.Add(btnHoa);
            pnlSubQuanLy.Controls.Add(btnNhaCungCap);
            pnlSubQuanLy.Controls.Add(btnLoaiHoa);
            pnlSubQuanLy.Dock = DockStyle.Top;
            pnlSubQuanLy.Location = new Point(0, 253);
            pnlSubQuanLy.Name = "pnlSubQuanLy";
            pnlSubQuanLy.Size = new Size(250, 283);
            pnlSubQuanLy.TabIndex = 3;
            pnlSubQuanLy.Visible = false;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderColor = Color.White;
            btnHoaDon.FlatAppearance.BorderSize = 2;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(0, 241);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(40, 0, 0, 0);
            btnHoaDon.Size = new Size(250, 34);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Hóa đơn bán hàng";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Bisque;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderColor = Color.White;
            btnNhanVien.FlatAppearance.BorderSize = 2;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.ForeColor = SystemColors.ActiveCaptionText;
            btnNhanVien.Location = new Point(0, 207);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(40, 0, 0, 0);
            btnNhanVien.Size = new Size(250, 34);
            btnNhanVien.TabIndex = 8;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderColor = Color.White;
            btnKhachHang.FlatAppearance.BorderSize = 2;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 173);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(40, 0, 0, 0);
            btnKhachHang.Size = new Size(250, 34);
            btnKhachHang.TabIndex = 7;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnGiaoHang
            // 
            btnGiaoHang.BackColor = Color.Bisque;
            btnGiaoHang.Dock = DockStyle.Top;
            btnGiaoHang.FlatAppearance.BorderColor = Color.White;
            btnGiaoHang.FlatAppearance.BorderSize = 2;
            btnGiaoHang.FlatStyle = FlatStyle.Flat;
            btnGiaoHang.ForeColor = SystemColors.ActiveCaptionText;
            btnGiaoHang.Location = new Point(0, 139);
            btnGiaoHang.Name = "btnGiaoHang";
            btnGiaoHang.Padding = new Padding(40, 0, 0, 0);
            btnGiaoHang.Size = new Size(250, 34);
            btnGiaoHang.TabIndex = 6;
            btnGiaoHang.Text = "Giao hàng";
            btnGiaoHang.TextAlign = ContentAlignment.MiddleLeft;
            btnGiaoHang.UseVisualStyleBackColor = false;
            btnGiaoHang.Click += btnGiaoHang_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Dock = DockStyle.Top;
            btnNhapHang.FlatAppearance.BorderColor = Color.White;
            btnNhapHang.FlatAppearance.BorderSize = 2;
            btnNhapHang.FlatStyle = FlatStyle.Flat;
            btnNhapHang.Location = new Point(0, 102);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Padding = new Padding(40, 0, 0, 0);
            btnNhapHang.Size = new Size(250, 37);
            btnNhapHang.TabIndex = 5;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapHang.UseVisualStyleBackColor = true;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // btnHoa
            // 
            btnHoa.BackColor = Color.Bisque;
            btnHoa.Dock = DockStyle.Top;
            btnHoa.FlatAppearance.BorderColor = Color.White;
            btnHoa.FlatAppearance.BorderSize = 2;
            btnHoa.FlatStyle = FlatStyle.Flat;
            btnHoa.ForeColor = SystemColors.ActiveCaptionText;
            btnHoa.Location = new Point(0, 68);
            btnHoa.Name = "btnHoa";
            btnHoa.Padding = new Padding(40, 0, 0, 0);
            btnHoa.Size = new Size(250, 34);
            btnHoa.TabIndex = 4;
            btnHoa.Text = "Hoa";
            btnHoa.TextAlign = ContentAlignment.MiddleLeft;
            btnHoa.UseVisualStyleBackColor = false;
            btnHoa.Click += btnHoa_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Dock = DockStyle.Top;
            btnNhaCungCap.FlatAppearance.BorderColor = Color.White;
            btnNhaCungCap.FlatAppearance.BorderSize = 2;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Location = new Point(0, 34);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(40, 0, 0, 0);
            btnNhaCungCap.Size = new Size(250, 34);
            btnNhaCungCap.TabIndex = 3;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnLoaiHoa
            // 
            btnLoaiHoa.BackColor = Color.Bisque;
            btnLoaiHoa.Dock = DockStyle.Top;
            btnLoaiHoa.FlatAppearance.BorderColor = Color.White;
            btnLoaiHoa.FlatAppearance.BorderSize = 2;
            btnLoaiHoa.FlatStyle = FlatStyle.Flat;
            btnLoaiHoa.Location = new Point(0, 0);
            btnLoaiHoa.Name = "btnLoaiHoa";
            btnLoaiHoa.Padding = new Padding(40, 0, 0, 0);
            btnLoaiHoa.Size = new Size(250, 34);
            btnLoaiHoa.TabIndex = 2;
            btnLoaiHoa.Text = "Loại hoa";
            btnLoaiHoa.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiHoa.UseVisualStyleBackColor = false;
            btnLoaiHoa.Click += btnLoaiHoa_Click;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.FromArgb(255, 192, 192);
            btnQuanLy.Dock = DockStyle.Top;
            btnQuanLy.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnQuanLy.FlatAppearance.BorderSize = 5;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQuanLy.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.ImageIndex = 9;
            btnQuanLy.ImageList = imageList;
            btnQuanLy.Location = new Point(0, 185);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Padding = new Padding(10, 0, 0, 0);
            btnQuanLy.Size = new Size(250, 68);
            btnQuanLy.TabIndex = 2;
            btnQuanLy.Text = "Quản lý";
            btnQuanLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // pnlSubHeThong
            // 
            pnlSubHeThong.BackColor = Color.PapayaWhip;
            pnlSubHeThong.Controls.Add(btnDoiMatKhau);
            pnlSubHeThong.Controls.Add(btnDangXuat);
            pnlSubHeThong.Controls.Add(btnDangNhap);
            pnlSubHeThong.Dock = DockStyle.Top;
            pnlSubHeThong.Location = new Point(0, 71);
            pnlSubHeThong.Name = "pnlSubHeThong";
            pnlSubHeThong.Size = new Size(250, 114);
            pnlSubHeThong.TabIndex = 1;
            pnlSubHeThong.Visible = false;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.Bisque;
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderColor = Color.White;
            btnDoiMatKhau.FlatAppearance.BorderSize = 2;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.ForeColor = SystemColors.ActiveCaptionText;
            btnDoiMatKhau.Location = new Point(0, 68);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(40, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(250, 35);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderColor = Color.White;
            btnDangXuat.FlatAppearance.BorderSize = 2;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Location = new Point(0, 34);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(40, 0, 0, 0);
            btnDangXuat.Size = new Size(250, 34);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Bisque;
            btnDangNhap.Dock = DockStyle.Top;
            btnDangNhap.FlatAppearance.BorderColor = Color.White;
            btnDangNhap.FlatAppearance.BorderSize = 2;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Location = new Point(0, 0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Padding = new Padding(40, 0, 0, 0);
            btnDangNhap.Size = new Size(250, 34);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.FromArgb(255, 192, 192);
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnHeThong.FlatAppearance.BorderSize = 5;
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHeThong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeThong.ImageIndex = 2;
            btnHeThong.ImageList = imageList;
            btnHeThong.Location = new Point(0, 0);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Padding = new Padding(10, 0, 0, 0);
            btnHeThong.Size = new Size(250, 71);
            btnHeThong.TabIndex = 0;
            btnHeThong.Text = "Hệ thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHeThong.UseVisualStyleBackColor = false;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.trangchu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1822, 873);
            Controls.Add(panelSidebar);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý shop giao hoa tươi";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelSidebar.ResumeLayout(false);
            pnlSubBaoCaoThongKe.ResumeLayout(false);
            pnlSubQuanLy.ResumeLayout(false);
            pnlSubHeThong.ResumeLayout(false);
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
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKeHoa;
        private ToolStripMenuItem mnuBaoCaoThongKe;
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
        private ToolStripMenuItem thốngToolStripMenuItem1;
        private ToolStripMenuItem mnuThongKeHoaBanChay;
        private ToolStripMenuItem thốngToolStripMenuItem3;
        private Panel panelSidebar;
        private Button btnHeThong;
        private Panel pnlSubHeThong;
        private Button btnDangNhap;
        private Button btnDoiMatKhau;
        private Button btnDangXuat;
        private Panel pnlSubQuanLy;
        private Button btnHoa;
        private Button btnNhaCungCap;
        private Button btnLoaiHoa;
        private Button btnQuanLy;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnGiaoHang;
        private Button btnNhapHang;
        private Panel pnlSubBaoCaoThongKe;
        private Button btnThongKeHoaBanChay;
        private Button btnThongKeDoanhThu;
        private Button btnThongKeHoa;
        private Button btnBaoCaoThongKe;
        private Button btnTroGiup;
        private ImageList imageList;
    }
}