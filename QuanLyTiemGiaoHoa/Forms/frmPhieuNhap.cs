using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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

namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmPhieuNhap : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        bool isOpening = false;
        bool dangTimKiem = false;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // Bước 1: Lấy dữ liệu thô từ Database
            var query = context.PhieuNhap
                .Include(x => x.NhanVien)
                .Include(x => x.NhaCungCap)
                .Select(r => new
                {
                    r.ID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    r.NgayNhap,
                    // Tính tổng tiền phiếu nhập từ bảng chi tiết
                    TongTien = r.ChiTiet_PhieuNhap.Sum(ct => (decimal?)ct.SoLuongNhap * ct.DonGiaNhap) ?? 0
                })
                .ToList();

            // Bước 2: Gán vào Class hiển thị để đổ lên DataGridView
            var ds = query.Select(r => new
            {
                r.ID,
                r.HoVaTenNhanVien,
                r.TenNhaCungCap,
                r.NgayNhap,
                TongTienPhieuNhap = r.TongTien,
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = ds;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            // Định dạng tiền tệ cho cột Tổng tiền
            if (dataGridView.Columns["TongTienPhieuNhap"] != null)
                dataGridView.Columns["TongTienPhieuNhap"].DefaultCellStyle.Format = "N0";

            LoadData();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            // Mở form chi tiết ở chế độ thêm mới
            using (frmChiTiet_PhieuNhap f = new frmChiTiet_PhieuNhap())
            {
                f.ShowDialog();
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maPN = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                using (frmChiTiet_PhieuNhap f = new frmChiTiet_PhieuNhap(maPN))
                {
                    f.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int idXoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Xác nhận xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var phieuNhap = context.PhieuNhap
                        .Include(p => p.ChiTiet_PhieuNhap)
                        .FirstOrDefault(p => p.ID == idXoa);

                    if (phieuNhap != null)
                    {
                        // Xóa chi tiết trước
                        context.ChiTiet_PhieuNhap.RemoveRange(phieuNhap.ChiTiet_PhieuNhap);
                        // Xóa phiếu nhập
                        context.PhieuNhap.Remove(phieuNhap);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // 👉 Kiểm tra nếu đang ở trạng thái tìm kiếm, nhấn lần nữa sẽ RESET
            if (dangTimKiem)
            {
                txtTimKiem.Clear();       // Xóa ô nhập liệu
                LoadData();               // Tải lại toàn bộ dữ liệu
                dangTimKiem = false;      // Đưa trạng thái về bình thường
                btnTimKiem.Text = "Tìm kiếm"; // Đổi lại chữ trên nút (nếu muốn)
                return;
            }

            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            // Nếu để trống mà nhấn tìm kiếm thì chỉ Load lại dữ liệu
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
                return;
            }

            // Thực hiện truy vấn tìm kiếm
            var query = context.PhieuNhap
                .Where(x => x.NhanVien.HoVaTen.ToLower().Contains(tuKhoa) ||
                            x.NhaCungCap.TenNhaCungCap.ToLower().Contains(tuKhoa) ||
                            x.ID.ToString().Contains(tuKhoa))
                .Select(r => new
                {
                    r.ID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    r.NgayNhap,
                    TongTien = r.ChiTiet_PhieuNhap.Sum(ct => (decimal?)ct.SoLuongNhap * ct.DonGiaNhap) ?? 0
                })
                .ToList();

            if (query.Count > 0)
            {
                dataGridView.DataSource = query.Select(r => new
                {
                    r.ID,
                    r.HoVaTenNhanVien,
                    r.TenNhaCungCap,
                    r.NgayNhap,
                    TongTienPhieuNhap = r.TongTien,
                    XemChiTiet = "Xem"
                }).ToList();

                dangTimKiem = true;        // Đánh dấu đã tìm thấy và đang hiển thị kết quả lọc
                btnTimKiem.Text = "Hủy tìm"; // Đổi chữ trên nút để người dùng biết nhấn để xóa
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu nhập nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                dangTimKiem = false;
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maPN = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                using (frmChiTiet_PhieuNhap f = new frmChiTiet_PhieuNhap(maPN))
                {
                    f.ShowDialog();
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Sử dụng Transaction để đảm bảo an toàn dữ liệu
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook(ofd.FileName))
                            {
                                var wsPhieu = wb.Worksheet("PhieuNhap");
                                var wsCT = wb.Worksheet("ChiTiet");
                                Dictionary<int, int> mapID = new Dictionary<int, int>();

                                // 1. Đọc Phiếu Nhập
                                var rowsPhieu = wsPhieu.RowsUsed().Skip(1);
                                foreach (var r in rowsPhieu)
                                {
                                    int idCu = r.Cell(1).GetValue<int>();
                                    string tenNV = r.Cell(2).GetValue<string>();
                                    string tenNCC = r.Cell(3).GetValue<string>();

                                    var nv = context.NhanVien.FirstOrDefault(x => x.HoVaTen == tenNV);
                                    var ncc = context.NhaCungCap.FirstOrDefault(x => x.TenNhaCungCap == tenNCC);

                                    var pn = new PhieuNhap
                                    {
                                        NhanVienID = nv?.ID ?? context.NhanVien.First().ID, // Mặc định NV đầu tiên nếu ko tìm thấy
                                        NhaCungCapID = ncc?.ID ?? context.NhaCungCap.First().ID,
                                        NgayNhap = r.Cell(4).GetDateTime(),
                                        GhiChu = r.Cell(5).GetValue<string>()
                                    };

                                    context.PhieuNhap.Add(pn);
                                    context.SaveChanges(); // Lưu để lấy ID mới tự tăng

                                    mapID[idCu] = pn.ID;
                                }

                                // 2. Đọc Chi Tiết
                                var rowsCT = wsCT.RowsUsed().Skip(1);
                                foreach (var r in rowsCT)
                                {
                                    int idCuInSheet = r.Cell(1).GetValue<int>();
                                    if (!mapID.ContainsKey(idCuInSheet)) continue;

                                    string tenHoa = r.Cell(2).GetValue<string>();
                                    var hoa = context.Hoa.FirstOrDefault(x => x.TenHoa == tenHoa);
                                    if (hoa == null) continue;

                                    context.ChiTiet_PhieuNhap.Add(new ChiTiet_PhieuNhap
                                    {
                                        PhieuNhapID = mapID[idCuInSheet],
                                        HoaID = hoa.ID,
                                        SoLuongNhap = r.Cell(3).GetValue<short>(),
                                        DonGiaNhap = r.Cell(4).GetValue<decimal>()
                                    });
                                }
                                context.SaveChanges();
                            }

                            transaction.Commit(); // Xác nhận lưu vĩnh viễn vào DB
                            LoadData();
                            MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Có lỗi thì hủy hết những gì đã làm ở trên
                            MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            var dsPhieu = context.PhieuNhap
                                .Include(p => p.NhanVien)
                                .Include(p => p.NhaCungCap)
                                .ToList();

            if (!dsPhieu.Any())
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "DanhSachPhieuNhap_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            // ===== SHEET 1: PHIẾU NHẬP =====
                            var wsPhieu = wb.Worksheets.Add("PhieuNhap");
                            wsPhieu.Cell(1, 1).Value = "Mã Phiếu";
                            wsPhieu.Cell(1, 2).Value = "Nhân Viên";
                            wsPhieu.Cell(1, 3).Value = "Nhà Cung Cấp";
                            wsPhieu.Cell(1, 4).Value = "Ngày Nhập";
                            wsPhieu.Cell(1, 5).Value = "Ghi Chú";

                            for (int i = 0; i < dsPhieu.Count; i++)
                            {
                                wsPhieu.Cell(i + 2, 1).Value = dsPhieu[i].ID;
                                wsPhieu.Cell(i + 2, 2).Value = dsPhieu[i].NhanVien?.HoVaTen;
                                wsPhieu.Cell(i + 2, 3).Value = dsPhieu[i].NhaCungCap?.TenNhaCungCap;
                                wsPhieu.Cell(i + 2, 4).Value = dsPhieu[i].NgayNhap;
                                wsPhieu.Cell(i + 2, 5).Value = dsPhieu[i].GhiChu;
                            }
                            wsPhieu.Columns().AdjustToContents(); // Tự căn độ rộng

                            // ===== SHEET 2: CHI TIẾT =====
                            var wsCT = wb.Worksheets.Add("ChiTiet");
                            wsCT.Cell(1, 1).Value = "Mã Phiếu";
                            wsCT.Cell(1, 2).Value = "Tên Hoa";
                            wsCT.Cell(1, 3).Value = "Số Lượng";
                            wsCT.Cell(1, 4).Value = "Đơn Giá";

                            var dsCT = context.ChiTiet_PhieuNhap.Include(x => x.Hoa).ToList();
                            for (int i = 0; i < dsCT.Count; i++)
                            {
                                wsCT.Cell(i + 2, 1).Value = dsCT[i].PhieuNhapID;
                                wsCT.Cell(i + 2, 2).Value = dsCT[i].Hoa?.TenHoa;
                                wsCT.Cell(i + 2, 3).Value = dsCT[i].SoLuongNhap;
                                wsCT.Cell(i + 2, 4).Value = dsCT[i].DonGiaNhap;
                            }
                            wsCT.Columns().AdjustToContents();

                            wb.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở file ngay sau khi lưu (tùy chọn)
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int maPN = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                using (frmChiTiet_PhieuNhap f = new frmChiTiet_PhieuNhap(maPN))
                {
                    f.ShowDialog();
                    LoadData();
                }
            }
        }

        private void btnInPhieuNhap_Click_1(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên DataGridView chưa
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xem/in!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy ID của Phiếu Nhập từ dòng đang chọn
            // Lưu ý: Đảm bảo cột trong DataGridView của bạn có tên (Name) là "ID"
            int idPhieu = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            // 3. Khởi tạo và mở Form Chi Tiết Phiếu Nhập
            // Thay đổi frmHoaDon_ChiTiet thành frmChiTiet_PhieuNhap
            using (frmChiTiet_PhieuNhap f = new frmChiTiet_PhieuNhap(idPhieu))
            {
                f.ShowDialog();
            }

            // 4. (Tùy chọn) Load lại dữ liệu nếu có thay đổi sau khi đóng form chi tiết
            LoadData();
        }
    }
}
