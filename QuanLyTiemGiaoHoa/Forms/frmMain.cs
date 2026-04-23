using QuanLyTiemGiaoHoa.Forms;
using QuanLyTiemGiaoHoa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTiemGiaoHoa.Forms
{

    public partial class frmMain : Form
    {
        QLTGHDbContext context = new QLTGHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        frmLoaiHoa loaiHoa = null;
        frmNhaCungCap nhaCungCap = null;
        frmHoa Hoa = null;
        frmPhieuNhap phieuNhap = null;
        frmGiaoHang giaoHang = null;
        frmKHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmHoaDon hoaDon = null;
        frmDangNhap dangNhap = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuLoaiHoa_Click(object sender, EventArgs e)
        {
            if (loaiHoa == null || loaiHoa.IsDisposed)
            {
                loaiHoa = new frmLoaiHoa();
                loaiHoa.MdiParent = this;
                loaiHoa.Show();
            }
            else
                loaiHoa.Activate();

            MoFormCon(new frmLoaiHoa());
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
            MoFormCon(new frmNhaCungCap());
        }

        private void mnuHoa_Click(object sender, EventArgs e)
        {
            if (Hoa == null || Hoa.IsDisposed)
            {
                Hoa = new frmHoa();
                Hoa.MdiParent = this;
                Hoa.Show();
            }
            else
                Hoa.Activate();
            MoFormCon(new frmHoa());
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                nhaCungCap.Activate();
            MoFormCon(new frmPhieuNhap());
        }

        private void mnuGiaoHang_Click(object sender, EventArgs e)
        {
            if (giaoHang == null || giaoHang.IsDisposed)
            {
                giaoHang = new frmGiaoHang();
                giaoHang.MdiParent = this;
                giaoHang.Show();
            }
            else
                nhaCungCap.Activate();
            MoFormCon(new frmGiaoHang());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
            MoFormCon(new frmKHang());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
            MoFormCon(new frmNhanVien());
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
            MoFormCon(new frmHoaDon());
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);

        }


        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    //var nhanVien = context.NhanViens.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    var nhanVien = context.NhanVien.FirstOrDefault(r => r.TenDangNhap == tenDangNhap);
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;

                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập 
            mnuDangNhap.Enabled = true;

            // Mờ tất cả 
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiHoa.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuHoa.Enabled = false;

            mnuNhapHang.Enabled = false;
            mnuGiaoHang.Enabled = false;

            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;

            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng quản lý không được phép 


            // Sáng đăng xuất và các chức năng quản lý được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiHoa.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuHoa.Enabled = true;

            mnuNhapHang.Enabled = true;
            mnuGiaoHang.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập 
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép 
            mnuLoaiHoa.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuHoa.Enabled = false;
            mnuNhanVien.Enabled = false;

            mnuNhapHang.Enabled = false;
            mnuGiaoHang.Enabled = false;



            // Sáng đăng xuất và các chức năng nhân viên được phép 
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void MoFormCon(Form formMoi)
        {
            // 1. Đóng tất cả các Form con đang mở (trừ cái đang chuẩn bị mở)
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Thiết lập và hiển thị Form mới
            formMoi.MdiParent = this;
            formMoi.WindowState = FormWindowState.Maximized; // Cho hiển thị tràn màn hình cho đẹp
            formMoi.Show();
        }
    }
}
