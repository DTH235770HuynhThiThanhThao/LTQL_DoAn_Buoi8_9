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
using QuanLyTiemGiaoHoa.Reports;

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
        frmThongKeHoa thongKeHoa = null;
        frmThongKeDoanhThu thongKeDoanhThu = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuLoaiHoa_Click(object sender, EventArgs e)
        {
            /*
            if (loaiHoa == null || loaiHoa.IsDisposed)
            {
                loaiHoa = new frmLoaiHoa();
                loaiHoa.MdiParent = this;
                loaiHoa.Show();
            }
            else
                loaiHoa.Activate();
            */

            MoFormCon<frmLoaiHoa>();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            /*
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
            */
            MoFormCon<frmNhaCungCap>();
        }

        private void mnuHoa_Click(object sender, EventArgs e)
        {
            /*
            if (Hoa == null || Hoa.IsDisposed)
            {
                Hoa = new frmHoa();
                Hoa.MdiParent = this;
                Hoa.Show();
            }
            else
                Hoa.Activate();
            */
            MoFormCon<frmHoa>();
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            /*
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                nhaCungCap.Activate();
            */
            MoFormCon<frmPhieuNhap>();
        }

        private void mnuGiaoHang_Click(object sender, EventArgs e)
        {
            /*
            if (giaoHang == null || giaoHang.IsDisposed)
            {
                giaoHang = new frmGiaoHang();
                giaoHang.MdiParent = this;
                giaoHang.Show();
            }
            else
                nhaCungCap.Activate();
            */
            MoFormCon<frmGiaoHang>();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            /*
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
            */
            MoFormCon<frmKHang>();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            /*
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
            */
            MoFormCon<frmNhanVien>();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            /*
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
            */
            MoFormCon<frmHoaDon>();
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

                            // THÊM DÒNG NÀY: Thông báo chào mừng
                            MessageBox.Show($"Đăng nhập thành công! Chào mừng {hoVaTenNhanVien}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            mnuThongKeHoa.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            mnuThongKeHoaBanChay.Enabled = false;

            // THÊM VÀO: Làm mờ 3 nút chính ở Sidebar
            btnHeThong.Enabled = false;
            btnQuanLy.Enabled = false;
            btnBaoCaoThongKe.Enabled = false;

            // Ẩn luôn các panel con nếu chúng lỡ đang mở
            pnlSubHeThong.Visible = false;
            pnlSubQuanLy.Visible = false;
            pnlSubBaoCaoThongKe.Visible = false;

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

            mnuThongKeHoa.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeHoaBanChay.Enabled = true;

            // Mở khóa 3 nút chính
            btnHeThong.Enabled = true;
            btnQuanLy.Enabled = true;
            btnBaoCaoThongKe.Enabled = true;

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

            mnuThongKeHoa.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            mnuThongKeHoaBanChay.Enabled = false;

            btnHeThong.Enabled = true;
            btnQuanLy.Enabled = true;
            btnNhanVien.Enabled = false;
            btnNhapHang.Enabled= false;
            
            btnBaoCaoThongKe.Enabled = false;


            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*
            ChuaDangNhap();
            DangNhap();
            */

            
            // 1. Ẩn tất cả các panel con ngay khi load
            pnlSubHeThong.Visible = false;
            pnlSubQuanLy.Visible = false;
            pnlSubBaoCaoThongKe.Visible = false;

            this.DoubleBuffered = true;
            ChuaDangNhap();

            // Hiển thị đăng nhập
            this.BeginInvoke(new Action(() => {
                DangNhap();
            }));

            // Load hình nền cho vùng MDI
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackgroundImage = Properties.Resources.trangchu;
                    ctl.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
            




        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        

        private void MoFormCon<T>() where T : Form, new()
        {

            
            // 1. Tìm xem Form này đã mở chưa
            T frm = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (frm == null)
            {
                // 2. Nếu chưa có thì đóng tất cả Form con khác (để tránh lag)
                foreach (Form child in this.MdiChildren) child.Close();

                // 3. Tạo mới
                frm = new T();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Tràn màn hình cho đẹp
                frm.Show();
            }
            else
            {
                // 4. Nếu mở rồi thì mang nó lên trước mặt
                frm.Activate();
            }
            


            /*
            // 1. Tìm xem Form này đã mở chưa
            T frm = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (frm == null)
            {
                // 2. Đóng các form con khác nếu muốn (không bắt buộc)
                foreach (Form child in this.MdiChildren) child.Close();

                // 3. Tạo mới
                frm = new T();
                frm.MdiParent = this;

                // QUAN TRỌNG: Thiết lập để nó nằm giữa
                frm.StartPosition = FormStartPosition.CenterScreen;

                // KHÔNG dùng Maximized ở đây nữa nhé
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
            */

            /*
            T frm = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (frm == null)
            {
                foreach (Form child in this.MdiChildren) child.Close();

                frm = new T();
                frm.MdiParent = this;

                // 1. Ẩn thanh tiêu đề để nhập vào nền
                frm.FormBorderStyle = FormBorderStyle.None;

                // 2. TẠO KHOẢNG CÁCH LỀ (Padding): 
                // Trái: 20, Trên: 20, Phải: 20, Dưới: 20 (Bạn có thể tăng giảm số này)
                frm.Padding = new Padding(20, 20, 20, 20);

                // 3. Ép tràn màn hình
                frm.WindowState = FormWindowState.Maximized;

                frm.Show();
            }
            else
            {
                frm.Activate();
            }
            */
        }

        private void mnuThongKeHoa_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeHoa>();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeDoanhThu>();
        }

        private void mnuThongKeHoaBanChay_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeHoaBanChay>();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubHeThong);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubQuanLy);
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubBaoCaoThongKe);
        }


        private void ShowSubMenu(Panel subMenu)
        {
            // 1. Nếu menu này đang ẩn thì mới xử lý
            if (subMenu.Visible == false)
            {
                // 2. Ẩn hết tất cả các panel con khác trước
                pnlSubHeThong.Visible = false;
                pnlSubQuanLy.Visible = false;
                pnlSubBaoCaoThongKe.Visible = false;

                // 3. Hiện cái mình vừa bấm
                subMenu.Visible = true;
            }
            else
            {
                // 4. Nếu đang mở rồi thì bấm cái nữa sẽ đóng lại
                subMenu.Visible = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiHoa_Click(object sender, EventArgs e)
        {
            MoFormCon<frmLoaiHoa>();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            MoFormCon<frmNhaCungCap>();
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            MoFormCon<frmHoa>();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            MoFormCon<frmPhieuNhap>();
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            MoFormCon<frmGiaoHang>();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon<frmKHang>();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon<frmNhanVien>();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon<frmHoaDon>();
        }

        private void btnThongKeHoa_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeHoa>();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeDoanhThu>();
        }

        private void btnThongKeHoaBanChay_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThongKeHoaBanChay>();
        }
    }
}
