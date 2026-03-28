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
            dataGridView.CellClick += dataGridView_CellClick;

            LoadData();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                LoadData();
            }
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
            int idXoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var hd = context.HoaDon.Find(idXoa);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                    context.SaveChanges();
                    LoadData(); // Gọi lại LoadData thay vì frmHoaDon_Load
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
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Hóa Đơn từ Excel";
            openFileDialog.Filter = "Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = "1:" + row.LastCellUsed().Address.ColumnNumber;

                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                }

                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;

                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                HoaDon hd = new HoaDon();

                                hd.NhanVienID = int.Parse(r["NhanVienID"].ToString());
                                hd.KhachHangID = int.Parse(r["KhachHangID"].ToString());
                                hd.NgayLap = DateTime.Parse(r["NgayLap"].ToString());
                                hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();

                                context.HoaDon.Add(hd);
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập " + table.Rows.Count + " hóa đơn.",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            frmHoaDon_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("File Excel rỗng!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách Hóa Đơn";
            saveFileDialog.Filter = "Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("NhanVienID", typeof(int));
                    table.Columns.Add("KhachHangID", typeof(int));
                    table.Columns.Add("NgayLap", typeof(DateTime));
                    table.Columns.Add("GhiChuHoaDon", typeof(string));


                    var ds = context.HoaDon.ToList();

                    foreach (var p in ds)
                    {
                        table.Rows.Add(
                            p.ID,
                            p.NhanVienID,
                            p.KhachHangID,
                            p.NgayLap,
                            p.GhiChuHoaDon
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HoaDon");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Đã xuất Excel thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                var cell = dataGridView.Rows[e.RowIndex].Cells["ID"].Value;
                if (cell == null) return;

                int id = Convert.ToInt32(cell);

                using (frmHoaDon_ChiTiet f = new frmHoaDon_ChiTiet(id))
                {
                    f.ShowDialog();
                }

                LoadData();
            }
        }
    }
}
