using QuanLyTiemGiaoHoa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        int maNV;
        public frmDoiMatKhau(int ma)
        {
            InitializeComponent();

            this.maNV = ma;

            
            // Thiết lập ẩn mật khẩu mặc định
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauMoi.PasswordChar = '*';
            txtNhapMatKhauMoi.PasswordChar = '*';
            
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Tạo một ngữ cảnh mới để tránh xung đột dữ liệu cũ
            using (var db = new QLTGHDbContext())
            {
                // 1. Tìm nhân viên
                var nv = db.NhanVien.Find(maNV);

                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi");
                    return;
                }

                // 2. Kiểm tra trống
                if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) || string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                // 3. Kiểm tra mật khẩu cũ (So sánh pass nhập vào với pass đã mã hóa trong DB)
                if (!BC.Verify(txtMatKhauCu.Text, nv.MatKhau))
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Kiểm tra mật khẩu mới trùng khớp
                if (txtMatKhauMoi.Text != txtNhapMatKhauMoi.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // 5. Mã hóa mật khẩu mới và lưu
                    nv.MatKhau = BC.HashPassword(txtMatKhauMoi.Text);

                    // Đánh dấu thực thể đã thay đổi và lưu
                    db.Entry(nv).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công! Hãy ghi nhớ mật khẩu mới.", "Thông báo");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi lưu mật khẩu: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char charStyle = chkHienMatKhau.Checked ? '\0' : '*';
            txtMatKhauCu.PasswordChar = charStyle;
            txtMatKhauMoi.PasswordChar = charStyle;
            txtNhapMatKhauMoi.PasswordChar = charStyle;
        }
    }
}
