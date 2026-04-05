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
//using static Azure.Core.HttpHeader;

namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmGiaoHang : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        bool dangTimKiem = false;
        public frmGiaoHang()
        {
            InitializeComponent();
        }

        private void frmGiaoHang_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns["TongTienHoaDon"] != null)
            {
                dataGridView.Columns["TongTienHoaDon"].DefaultCellStyle.Format = "N0";
            }
            // Định dạng cột số tiền nếu tồn tại
            if (dataGridView.Columns["TongTienHoaDon"] != null)
                dataGridView.Columns["TongTienHoaDon"].DefaultCellStyle.Format = "N0";

            LoadNhanVienGiao();
            LoadTrangThaiCbo();
            LoadData();
        }


        private void LoadNhanVienGiao()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
        }

        private void LoadTrangThaiCbo()
        {
            var listTrangThai = new[] {
                new { Text = "Chờ giao", Value = TrangThaiGiaoHang.ChoGiao },
                new { Text = "Đang giao", Value = TrangThaiGiaoHang.DangGiao },
                new { Text = "Đã giao", Value = TrangThaiGiaoHang.DaGiao },
                new { Text = "Hủy", Value = TrangThaiGiaoHang.Huy }
            }.ToList();

            cboTrangThaiGiao.DataSource = listTrangThai;
            cboTrangThaiGiao.DisplayMember = "Text";
            cboTrangThaiGiao.ValueMember = "Value";
        }

        private string GetTrangThaiText(TrangThaiGiaoHang tt)
        {
            switch (tt)
            {
                case TrangThaiGiaoHang.ChoGiao: return "Chờ giao";
                case TrangThaiGiaoHang.DangGiao: return "Đang giao";
                case TrangThaiGiaoHang.DaGiao: return "Đã giao";
                case TrangThaiGiaoHang.Huy: return "Hủy";
                default: return "Không xác định";
            }
        }

        private void LoadData()
        {
            // 1. Lấy dữ liệu từ DB trước (QUAN TRỌNG để tránh lỗi EF)
            var data = context.GiaoHang
                .Include(g => g.HoaDon)
                    .ThenInclude(h => h.KhachHang)
                .Include(g => g.HoaDon)
                    .ThenInclude(h => h.HoaDon_ChiTiet)
                .Include(g => g.NhanVien)
                .ToList(); // 🔥 BẮT BUỘC

            // 2. Xử lý dữ liệu trên RAM (LINQ to Objects)
            var query = data.Select(g => new DanhSachGiaoHang
            {
                ID = g.ID,
                HoaDonID = g.HoaDonID,
                NhanVienID = g.NhanVienID,

                // Tên nhân viên
                HoVaTenNhanVien = g.NhanVien != null
                    ? g.NhanVien.HoVaTen
                    : "Chưa gán",

                // Tên khách hàng
                HoVaTenKhachHang = g.HoaDon?.KhachHang != null
                    ? g.HoaDon.KhachHang.HoVaTen
                    : "Khách vãng lai",

                TenNguoiNhan = g.TenNguoiNhan,
                DienThoaiNhan = g.DienThoaiNhan,
                DiaChiGiao = g.DiaChiGiao,
                NgayGiao = g.NgayGiao,
                GhiChu = g.GhiChu,

                // 🔥 Tính tổng tiền AN TOÀN (không lỗi null)
                TongTienHoaDon =
                    (g.HoaDon?.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan) ?? 0)
                    + (g.HoaDon?.PhiGiaoHang ?? 0),

                // 🔥 Convert enum -> text (GIỜ KHÔNG LỖI)
                TrangThaiGiao = GetTrangThaiText(g.TrangThai),
                TrangThaiEnum = g.TrangThai
            })
           // .OrderByDescending(x => x.NgayGiao)
           .OrderBy(x => x.ID)
            .ToList();

            // 3. Bind lên DataGridView
            dataGridView.DataSource = query;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachGiaoHang;
            if (item == null) return;

            // Đổ dữ liệu
            txtKhachHang.Text = item.HoVaTenKhachHang;
            txtTenNguoiNhan.Text = item.TenNguoiNhan;
            txtSDTNhan.Text = item.DienThoaiNhan;
            txtDiaChiGiao.Text = item.DiaChiGiao;
            txtGhiChuGiaoHang.Text = item.GhiChu;
            dtpNgayGiao.Value = item.NgayGiao;

            numTongTien.Value = item.TongTienHoaDon ?? 0;

            // ComboBox nhân viên
            cboNhanVien.SelectedValue = item.NhanVienID;

            // ComboBox trạng thái (CÁCH ĐÚNG)
            cboTrangThaiGiao.SelectedValue = item.TrangThaiEnum;


        }
        /*
        private void CapNhatTrangThai(TrangThaiGiaoHang moi)
        {
            if (dataGridView.CurrentRow == null) return;

            int idGiaoHang = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            var gh = context.GiaoHang.Find(idGiaoHang);

            if (gh != null)
            {
                gh.TrangThai = moi;
                if (cboNhanVien.SelectedValue != null)
                    gh.NhanVienID = (int)cboNhanVien.SelectedValue;

                gh.GhiChu = txtGhiChuGiaoHang.Text;

                context.SaveChanges();
                MessageBox.Show($"Đã cập nhật trạng thái: {GetTrangThaiText(moi)}", "Thông báo");
                LoadData();
            }
        }
        */
        private void CapNhatTrangThai(TrangThaiGiaoHang moi)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng từ danh sách!", "Thông báo");
                return;
            }

            // Lấy đối tượng dữ liệu trực tiếp từ dòng đang chọn
            var item = dataGridView.CurrentRow.DataBoundItem as DanhSachGiaoHang;

            if (item != null)
            {
                // Tìm đối tượng trong CSDL dựa trên ID của item
                var gh = context.GiaoHang.Find(item.ID);

                if (gh != null)
                {
                    // Cập nhật trạng thái
                    gh.TrangThai = moi;

                    // Cập nhật nhân viên giao hàng từ ComboBox
                    if (cboNhanVien.SelectedValue != null)
                    {
                        gh.NhanVienID = (int)cboNhanVien.SelectedValue;
                    }

                    // Cập nhật ghi chú nếu có thay đổi
                    gh.GhiChu = txtGhiChuGiaoHang.Text;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show($"Đã cập nhật trạng thái: {GetTrangThaiText(moi)}", "Thành công");
                        LoadData(); // Tải lại bảng
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btnBatDauGiao_Click(object sender, EventArgs e)
        {
            CapNhatTrangThai(TrangThaiGiaoHang.DangGiao);
        }

        private void btnGiaoThanhCong_Click(object sender, EventArgs e)
        {
            CapNhatTrangThai(TrangThaiGiaoHang.DaGiao);
        }

        private void btnHuyGiao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn giao này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CapNhatTrangThai(TrangThaiGiaoHang.Huy);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Nếu đang ở trạng thái tìm kiếm → bấm lần 2 sẽ RESET
            if (dangTimKiem)
            {
                txtTimKiem.Clear();   // xóa ô nhập
                LoadData();           // load lại dữ liệu gốc
                dangTimKiem = false;  // reset trạng thái
                return;
            }

            // Lần bấm đầu → thực hiện tìm kiếm
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            var currentData = dataGridView.DataSource as List<DanhSachGiaoHang>;
            if (currentData == null) return;

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                var filtered = currentData.Where(x =>
                    (x.HoVaTenKhachHang != null && x.HoVaTenKhachHang.ToLower().Contains(tuKhoa)) ||
                    (x.TenNguoiNhan != null && x.TenNguoiNhan.ToLower().Contains(tuKhoa)) ||
                    (x.DienThoaiNhan != null && x.DienThoaiNhan.Contains(tuKhoa))
                ).ToList();

                dataGridView.DataSource = filtered;

                if (filtered.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo");

                dangTimKiem = true; // đánh dấu là đang ở trạng thái tìm kiếm
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô nhập liệu
            txtTimKiem.Clear();
            txtGhiChuGiaoHang.Clear();
            txtTenNguoiNhan.Clear();
            txtSDTNhan.Clear();
            txtDiaChiGiao.Clear();

            // Reset ngày về hiện tại
            dtpNgayGiao.Value = DateTime.Now;

            // Load lại dữ liệu từ CSDL
            LoadData();

            MessageBox.Show("Đã làm mới danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInPhieuGiao_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            string s = "------- PHIẾU GIAO HÀNG -------\n";
            s += $"Người nhận: {txtTenNguoiNhan.Text}\n";
            s += $"SĐT: {txtSDTNhan.Text}\n";
            s += $"Địa chỉ: {txtDiaChiGiao.Text}\n";
            s += $"Tổng tiền thu: {numTongTien.Value:N0} VNĐ\n";
            s += $"Ghi chú: {txtGhiChuGiaoHang.Text}\n";
            s += "------------------------------";

            MessageBox.Show(s, "In phiếu giao hàng (Demo)");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog { Filter = "Excel|*.xlsx", FileName = "GiaoHang_" + DateTime.Now.ToString("ddMMyyyy") };
            if (save.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("GiaoHang");
                    // Header chuẩn - 9 cột
                    string[] headers = { "ID", "HoaDonID", "NhanVienID", "TenNguoiNhan", "DienThoaiNhan", "DiaChiGiao", "NgayGiao", "TrangThai", "GhiChu" };
                    for (int i = 0; i < headers.Length; i++) ws.Cell(1, i + 1).Value = headers[i];

                    // Lấy dữ liệu (AsNoTracking để tăng tốc độ vì chỉ xuất file)
                    var list = context.GiaoHang.AsNoTracking().ToList();
                    int row = 2;
                    foreach (var gh in list)
                    {
                        ws.Cell(row, 1).Value = gh.ID;           // Cột 1: ID quan trọng để cập nhật
                        ws.Cell(row, 2).Value = gh.HoaDonID;    // Cột 2
                        ws.Cell(row, 3).Value = gh.NhanVienID;  // Cột 3
                        ws.Cell(row, 4).Value = gh.TenNguoiNhan;
                        ws.Cell(row, 5).Value = gh.DienThoaiNhan;
                        ws.Cell(row, 6).Value = gh.DiaChiGiao;
                        ws.Cell(row, 7).Value = gh.NgayGiao.ToString("yyyy-MM-dd HH:mm");
                        ws.Cell(row, 8).Value = gh.TrangThai.ToString(); // Xuất dạng text của Enum
                        ws.Cell(row, 9).Value = gh.GhiChu;
                        row++;
                    }
                    ws.Columns().AdjustToContents();
                    wb.SaveAs(save.FileName);
                }
                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xuất: " + ex.Message); }
        }



        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để lưu!", "Thông báo");
                return;
            }

            var item = dataGridView.CurrentRow.DataBoundItem as DanhSachGiaoHang;
            if (item == null) return;

            try
            {
                // 1. Tìm bản ghi ở bảng GiaoHang
                var gh = context.GiaoHang.Include(x => x.HoaDon).FirstOrDefault(x => x.ID == item.ID);

                if (gh != null)
                {
                    // --- CẬP NHẬT BẢNG GIAO HÀNG ---
                    gh.GhiChu = txtGhiChuGiaoHang.Text.Trim();
                    gh.NgayGiao = dtpNgayGiao.Value;

                    if (cboNhanVien.SelectedValue != null)
                        gh.NhanVienID = (int)cboNhanVien.SelectedValue;

                    if (cboTrangThaiGiao.SelectedValue != null)
                        gh.TrangThai = (TrangThaiGiaoHang)cboTrangThaiGiao.SelectedValue;

                    // --- CẬP NHẬT BẢNG HÓA ĐƠN (Vì tên, địa chỉ, sđt gốc nằm ở đây) ---
                    if (gh.HoaDon != null)
                    {
                        // Lưu ý: Nếu bạn muốn sửa thông tin người nhận trên đơn giao 
                        // mà không làm thay đổi hồ sơ khách hàng gốc, ta sửa trực tiếp vào bảng GiaoHang
                        // Nhưng theo ý bạn là thông tin này nằm bên Hóa Đơn, nên ta cập nhật:

                        gh.TenNguoiNhan = txtTenNguoiNhan.Text.Trim();
                        gh.DienThoaiNhan = txtSDTNhan.Text.Trim();
                        gh.DiaChiGiao = txtDiaChiGiao.Text.Trim();

                        // Nếu bạn muốn sửa cả PhiGiaoHang trong Hóa Đơn dựa trên số tiền nhập:
                        // gh.HoaDon.PhiGiaoHang = ... (tùy logic của bạn)
                    }

                    // 2. Lưu tất cả thay đổi xuống DB
                    context.SaveChanges();

                    MessageBox.Show("Đã cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Tải lại lưới
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThaiGiao" && e.Value != null)
            {
                string tt = e.Value.ToString();
                switch (tt)
                {
                    case "Chờ giao": e.CellStyle.ForeColor = Color.Orange; break;
                    case "Đang giao": e.CellStyle.ForeColor = Color.Blue; break;
                    case "Đã giao": e.CellStyle.ForeColor = Color.Green; break;
                    case "Hủy": e.CellStyle.ForeColor = Color.Red; break;
                }
                e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            }
        }
    }
}

