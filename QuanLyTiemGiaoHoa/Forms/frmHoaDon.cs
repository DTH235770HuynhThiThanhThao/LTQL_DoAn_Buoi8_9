using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyTiemGiaoHoa.Data;


namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmHoaDon : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        int id;
        bool isOpening = false; //chặn trùng form
        public frmHoaDon()
        {
            InitializeComponent();
        }

        // Thêm từ khóa static vào trước hàm này
        private static string HienThiTrangThai(TrangThaiGiaoHang? trangThai)
        {
            if (trangThai == null) return "Chưa giao";
            switch (trangThai)
            {
                case TrangThaiGiaoHang.ChoGiao: return "Chờ giao";
                case TrangThaiGiaoHang.DangGiao: return "Đang giao";
                case TrangThaiGiaoHang.DaGiao: return "Đã giao";
                case TrangThaiGiaoHang.Huy: return "Đã hủy";
                default: return "Không xác định";
            }
        }

        private void LoadData()
        {
            /*
            // Bước 1: Lấy dữ liệu thô từ SQL (Chưa gọi hàm HienThiTrangThai)
            var query = context.HoaDon
                .Include(x => x.GiaoHang)
                .Include(x => x.NhanVien)
                .Include(x => x.KhachHang)
                .Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.PhiGiaoHang,
                    r.GhiChuHoaDon,
                    // Tính tổng tiền ở cấp độ Database
                    TongTien = (r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0) + r.PhiGiaoHang,
                    // Lấy enum trạng thái thô
                    TrangThaiEnum = r.GiaoHang != null ? (TrangThaiGiaoHang?)r.GiaoHang.TrangThai : null
                })
                .ToList(); // Chuyển dữ liệu về bộ nhớ (Client-side)

            // Bước 2: Chuyển sang Class hiển thị và gọi hàm HienThiTrangThai
            var hd = query.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.HoVaTenNhanVien,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.HoVaTenKhachHang,
                NgayLap = r.NgayLap,
                PhiGiaoHang = r.PhiGiaoHang,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.TongTien,
                // Bây giờ gọi hàm này sẽ không bị lỗi nữa
                TrangThaiGiao = HienThiTrangThai(r.TrangThaiEnum),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
            */

            var query = context.HoaDon
        .Include(x => x.GiaoHang)
        .Include(x => x.NhanVien)
        .Include(x => x.KhachHang)
        .Include(x => x.HoaDon_ChiTiet) // Phải Include chi tiết để tính Sum
        .Select(r => new
        {
            r.ID,
            r.NhanVienID,
            HoVaTenNhanVien = r.NhanVien.HoVaTen,
            r.KhachHangID,
            HoVaTenKhachHang = r.KhachHang.HoVaTen,
            r.NgayLap,
            PhiGiaoHang = r.PhiGiaoHang,
            r.GhiChuHoaDon,
            // Sử dụng tính toán an toàn hơn
            TongTien = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0,
            TrangThaiEnum = r.GiaoHang != null ? (TrangThaiGiaoHang?)r.GiaoHang.TrangThai : null
        })
        .ToList();

            var hd = query.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.HoVaTenNhanVien,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.HoVaTenKhachHang,
                NgayLap = r.NgayLap,
                PhiGiaoHang = r.PhiGiaoHang,
                GhiChuHoaDon = r.GhiChuHoaDon,
                // Tổng tiền cuối cùng = Tiền hàng + Phí giao
                TongTienHoaDon = r.TongTien + r.PhiGiaoHang,
                TrangThaiGiao = HienThiTrangThai(r.TrangThaiEnum),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            // Định dạng số tiền có dấu phân cách (10,000)
            if (dataGridView.Columns["TongTienHoaDon"] != null)
                dataGridView.Columns["TongTienHoaDon"].DefaultCellStyle.Format = "N0";

            // BỔ SUNG: Định dạng cho cột Phí giao hàng
            if (dataGridView.Columns["PhiGiaoHang"] != null)
                dataGridView.Columns["PhiGiaoHang"].DefaultCellStyle.Format = "N0";

            // Đăng ký sự kiện đổi màu ô (Quan trọng)
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            //dataGridView.CellClick += dataGridView_CellClick;

            LoadData();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            /*
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                LoadData();
            }
            */

            // 1. Tạo form chi tiết mới
            frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet();

            // 2. Gán cha cho nó là Form chính (MdiParent) 
            // Vì frmHoaDon cũng là con của frmMain, nên ta lấy cha của form hiện tại gán cho form mới
            chiTiet.MdiParent = this.MdiParent;

            // 3. Hiển thị full màn hình cho đẹp
            chiTiet.WindowState = FormWindowState.Maximized;

            // 4. Hiện form chi tiết lên
            chiTiet.Show();

            // 5. Đóng hoặc ẩn form danh sách (frmHoaDon) hiện tại
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                // 1. Lấy ID hóa đơn từ dòng đang chọn
                int maHD = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                // 2. Truyền maHD vào constructor của form Chi tiết
                frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(maHD);

                // 3. Hiển thị form dưới dạng hội thoại (ShowDialog)
                frm.ShowDialog();

                // 4. Sau khi đóng form chi tiết, load lại danh sách để cập nhật dữ liệu mới
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            // 1. Lấy ID từ dòng đang chọn
            int idXoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này và tất cả các thông tin liên quan không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // 2. Tìm hóa đơn cùng các bảng liên quan
                    var hoaDon = context.HoaDon
                        .Include(h => h.HoaDon_ChiTiet)
                        .Include(h => h.GiaoHang)
                        .FirstOrDefault(h => h.ID == idXoa);

                    if (hoaDon != null)
                    {
                        // 3. Xóa các bảng "con" trước để tránh lỗi ràng buộc (Foreign Key)
                        if (hoaDon.HoaDon_ChiTiet != null && hoaDon.HoaDon_ChiTiet.Any())
                        {
                            context.HoaDon_ChiTiet.RemoveRange(hoaDon.HoaDon_ChiTiet);
                        }

                        if (hoaDon.GiaoHang != null)
                        {
                            context.GiaoHang.Remove(hoaDon.GiaoHang);
                        }

                        // 4. Xóa bảng "cha" (Hóa đơn)
                        context.HoaDon.Remove(hoaDon);

                        // 5. Lưu thay đổi xuống Database
                        context.SaveChanges();

                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa hóa đơn này. Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(id))
            {
                f.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            /*
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            // Nếu không nhập gì mà nhấn Tìm kiếm -> Hiển thị lại toàn bộ
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
                return;
            }

            // Bước 1: Lấy dữ liệu từ DB (Chưa gọi hàm định dạng chữ)
            var query = context.HoaDon
                .Where(x => x.NhanVien.HoVaTen.ToLower().Contains(tuKhoa) ||
                            x.KhachHang.HoVaTen.ToLower().Contains(tuKhoa) ||
                            x.ID.ToString().Contains(tuKhoa))
                .Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.PhiGiaoHang,
                    r.GhiChuHoaDon,
                    TongTien = (r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0) + r.PhiGiaoHang,
                    TrangThaiEnum = r.GiaoHang != null ? (TrangThaiGiaoHang?)r.GiaoHang.TrangThai : null
                })
                .ToList();

            // Bước 2: Chuyển sang List hiển thị (An toàn với EF Core)
            var ketQua = query.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.HoVaTenNhanVien,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.HoVaTenKhachHang,
                NgayLap = r.NgayLap,
                PhiGiaoHang = r.PhiGiaoHang,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.TongTien,
                TrangThaiGiao = HienThiTrangThai(r.TrangThaiEnum),
                XemChiTiet = "Xem"
            }).ToList();

            dataGridView.DataSource = ketQua;
            */

            // 1. Lấy từ khóa và xóa khoảng trắng 2 đầu
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            // 2. Kiểm tra: Nếu ô tìm kiếm trống, hiển thị lại toàn bộ và dừng hàm luôn
            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Thảo gọi lại hàm LoadData() mà bạn đã viết ở trên 
                // để nó nạp lại danh sách gốc vào Grid
                LoadData();
                return;
            }

            // 3. Nếu có từ khóa, thực hiện truy vấn như cũ
            var query = context.HoaDon
                .Where(x => x.NhanVien.HoVaTen.ToLower().Contains(tuKhoa) ||
                            x.KhachHang.HoVaTen.ToLower().Contains(tuKhoa) ||
                            x.ID.ToString().Contains(tuKhoa))
                .Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLap,
                    r.PhiGiaoHang,
                    r.GhiChuHoaDon,
                    TongTien = (r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0) + r.PhiGiaoHang,
                    TrangThaiEnum = r.GiaoHang != null ? (TrangThaiGiaoHang?)r.GiaoHang.TrangThai : null
                })
                .ToList();

            var ketQua = query.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.HoVaTenNhanVien,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.HoVaTenKhachHang,
                NgayLap = r.NgayLap,
                PhiGiaoHang = r.PhiGiaoHang,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.TongTien,
                TrangThaiGiao = HienThiTrangThai(r.TrangThaiEnum),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = ketQua;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua dòng tiêu đề

                        foreach (var row in rows)
                        {
                            // 1. Tạo Hóa Đơn
                            HoaDon hd = new HoaDon
                            {
                                NhanVienID = int.Parse(row.Cell(1).Value.ToString()),
                                KhachHangID = int.Parse(row.Cell(2).Value.ToString()),
                                NgayLap = DateTime.Parse(row.Cell(3).Value.ToString()),
                                GhiChuHoaDon = row.Cell(4).Value.ToString(),
                                PhiGiaoHang = decimal.Parse(row.Cell(5).Value.ToString())
                            };
                            context.HoaDon.Add(hd);
                            context.SaveChanges(); // Lưu để lấy ID

                            // 2. Tạo Chi Tiết (Số lượng)
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                            {
                                HoaDonID = hd.ID,
                                HoaID = int.Parse(row.Cell(6).Value.ToString()),
                                SoLuongBan = short.Parse(row.Cell(7).Value.ToString()),
                                DonGiaBan = decimal.Parse(row.Cell(8).Value.ToString())
                            };
                            context.HoaDon_ChiTiet.Add(ct);

                            // 3. Tạo Giao Hàng
                            GiaoHang gh = new GiaoHang
                            {
                                HoaDonID = hd.ID,
                                NhanVienID = hd.NhanVienID,
                                TenNguoiNhan = row.Cell(9).Value.ToString(),
                                DienThoaiNhan = row.Cell(10).Value.ToString(),
                                DiaChiGiao = row.Cell(11).Value.ToString(),
                                NgayGiao = hd.NgayLap,
                                TrangThai = TrangThaiGiaoHang.ChoGiao
                            };
                            context.GiaoHang.Add(gh);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Nhập dữ liệu thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi nhập: " + ex.Message); }
            }
            */

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel|*.xlsx" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                        {
                            var worksheet = workbook.Worksheet(1);
                            var rows = worksheet.RowsUsed().Skip(1);

                            foreach (var row in rows)
                            {
                                // 1. Tạo Hóa Đơn
                                HoaDon hd = new HoaDon
                                {
                                    NhanVienID = row.Cell(1).GetValue<int>(),
                                    KhachHangID = row.Cell(2).GetValue<int>(),
                                    NgayLap = row.Cell(3).GetDateTime(),
                                    GhiChuHoaDon = row.Cell(4).GetValue<string>(),
                                    PhiGiaoHang = row.Cell(5).GetValue<decimal>()
                                };
                                context.HoaDon.Add(hd);
                                context.SaveChanges();

                                // 2. Tạo Chi Tiết
                                HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                                {
                                    HoaDonID = hd.ID,
                                    HoaID = row.Cell(6).GetValue<int>(),
                                    SoLuongBan = row.Cell(7).GetValue<short>(),
                                    DonGiaBan = row.Cell(8).GetValue<decimal>()
                                };
                                context.HoaDon_ChiTiet.Add(ct);

                                // 3. Tạo Giao Hàng
                                GiaoHang gh = new GiaoHang
                                {
                                    HoaDonID = hd.ID,
                                    NhanVienID = hd.NhanVienID, // Mặc định NV lập là NV giao, có thể sửa sau
                                    TenNguoiNhan = row.Cell(9).GetValue<string>(),
                                    DienThoaiNhan = row.Cell(10).GetValue<string>(),
                                    DiaChiGiao = row.Cell(11).GetValue<string>(),
                                    NgayGiao = hd.NgayLap,
                                    TrangThai = TrangThaiGiaoHang.ChoGiao
                                };
                                context.GiaoHang.Add(gh);
                            }
                            context.SaveChanges();
                            transaction.Commit(); // Chỉ xác nhận khi tất cả OK
                            MessageBox.Show("Nhập dữ liệu thành công!");
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi nhập: " + ex.Message);
                    }
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            /*
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xlsx";
            saveFileDialog.FileName = "DuLieuHoaDon_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    // Cột Hóa Đơn
                    table.Columns.Add("NhanVienID", typeof(int));
                    table.Columns.Add("KhachHangID", typeof(int));
                    table.Columns.Add("NgayLap", typeof(DateTime));
                    table.Columns.Add("GhiChuHoaDon", typeof(string));
                    table.Columns.Add("PhiGiaoHang", typeof(decimal));
                    // Cột Chi Tiết (Món hàng)
                    table.Columns.Add("HoaID", typeof(int));
                    table.Columns.Add("SoLuongBan", typeof(int));
                    table.Columns.Add("DonGiaBan", typeof(decimal));
                    // Cột Giao Hàng
                    table.Columns.Add("TenNguoiNhan", typeof(string));
                    table.Columns.Add("SDTNhan", typeof(string));
                    table.Columns.Add("DiaChiGiao", typeof(string));

                    var ds = context.HoaDon.Include(h => h.HoaDon_ChiTiet).Include(h => h.GiaoHang).ToList();

                    foreach (var hd in ds)
                    {
                        foreach (var ct in hd.HoaDon_ChiTiet)
                        {
                            table.Rows.Add(
                                hd.NhanVienID, hd.KhachHangID, hd.NgayLap, hd.GhiChuHoaDon, hd.PhiGiaoHang,
                                ct.HoaID, ct.SoLuongBan, ct.DonGiaBan,
                                hd.GiaoHang?.TenNguoiNhan ?? "",
                                hd.GiaoHang?.DienThoaiNhan ?? "",
                                hd.GiaoHang?.DiaChiGiao ?? ""
                            );
                        }
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(table, "Data");
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất: " + ex.Message); }
            }
            */
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Excel|*.xlsx",
                FileName = "BaoCaoHoaDon_" + DateTime.Now.ToString("yyyyMMdd")
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var ds = context.HoaDon
                        .Include(h => h.NhanVien)
                        .Include(h => h.KhachHang)
                        .Include(h => h.HoaDon_ChiTiet)
                        .ThenInclude(ct => ct.Hoa) // Lấy thêm tên hoa nếu cần
                        .Include(h => h.GiaoHang)
                        .ToList();

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("HoaDon");
                        // Tự viết tiêu đề cho đẹp
                        ws.Cell(1, 1).Value = "Mã HD";
                        ws.Cell(1, 2).Value = "Nhân viên";
                        ws.Cell(1, 3).Value = "Khách hàng";
                        ws.Cell(1, 4).Value = "Ngày lập";
                        ws.Cell(1, 5).Value = "Tổng tiền hàng";
                        ws.Cell(1, 6).Value = "Phí giao";

                        int row = 2;
                        foreach (var hd in ds)
                        {
                            ws.Cell(row, 1).Value = hd.ID;
                            ws.Cell(row, 2).Value = hd.NhanVien?.HoVaTen;
                            ws.Cell(row, 3).Value = hd.KhachHang?.HoVaTen;
                            ws.Cell(row, 4).Value = hd.NgayLap;
                            ws.Cell(row, 5).Value = hd.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan);
                            ws.Cell(row, 6).Value = hd.PhiGiaoHang;
                            row++;
                        }
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất: " + ex.Message); }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem có đúng cột "Trạng thái giao" không (thay tên cột tương ứng của bạn)
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThaiGiao" && e.Value != null)
            {
                string trangThai = e.Value.ToString();

                switch (trangThai)
                {
                    case "Chờ giao":
                        e.CellStyle.ForeColor = Color.Orange; // Màu cam cho chờ giao
                        break;
                    case "Đang giao":
                        e.CellStyle.ForeColor = Color.DodgerBlue; // Xanh dương đậm cho đang giao
                        break;
                    case "Đã giao":
                        e.CellStyle.ForeColor = Color.ForestGreen; // Xanh lá cây cho đã giao
                        break;
                    case "Đã hủy":
                        e.CellStyle.ForeColor = Color.Red; // Màu đỏ cho đơn hủy
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.Gray; // Mặc định màu xám
                        break;
                }

                // Nếu bạn muốn chữ in nghiêng cho nhẹ nhàng
                e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Italic);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isOpening) return; // chặn mở trùng

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                var cellValue = dataGridView.Rows[e.RowIndex].Cells["ID"].Value;
                if (cellValue == null) return;

                int maID = Convert.ToInt32(cellValue);

                isOpening = true;

                using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(maID))
                {
                    f.ShowDialog();
                }

                isOpening = false;

                LoadData();
            }
        }
    }
}
