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
using System.Text.RegularExpressions;


namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa) 
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LaySanPhamVaoComboBox()
        {
            cboHoa.DataSource = context.Hoa.ToList();
            cboHoa.ValueMember = "ID";
            cboHoa.DisplayMember = "TenHoa";
        }

        public void LayTrangThaiVaoComboBox()
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

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm 
            {
                // Xóa trắng các trường 
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboHoa.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm hoa 
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            LayTrangThaiVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            dtpNgayLap.Enabled = false; // Ngày lập hóa đơn không nên cho sửa

            if (id != 0) // Chế độ Sửa
            {
                var hoaDon = context.HoaDon
                    .Include(h => h.GiaoHang)
                    .FirstOrDefault(r => r.ID == id);

                if (hoaDon != null)
                {
                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;
                    numPhiGiaoHang.Value = hoaDon.PhiGiaoHang;

                    // Gán ngày lập hóa đơn
                    dtpNgayLap.Value = hoaDon.NgayLap;

                    if (hoaDon.GiaoHang != null)
                    {
                        txtTenNguoiNhan.Text = hoaDon.GiaoHang.TenNguoiNhan;
                        txtSDTNhan.Text = hoaDon.GiaoHang.DienThoaiNhan;
                        txtDiaChiGiao.Text = hoaDon.GiaoHang.DiaChiGiao;
                        cboTrangThaiGiao.SelectedValue = hoaDon.GiaoHang.TrangThai;

                        if (hoaDon.GiaoHang.NgayGiao != default(DateTime))
                        {
                            dtpNgayGiao.Value = hoaDon.GiaoHang.NgayGiao;
                        }
                        else
                        {
                            dtpNgayGiao.Value = DateTime.Now; // Nếu chưa có ngày hợp lệ thì lấy ngày hiện tại
                        }
                    }

                    var ct = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .Select(r => new DanhSachHoaDon_ChiTiet
                        {
                            ID = r.ID,
                            HoaDonID = r.HoaDonID,
                            HoaID = r.HoaID,
                            TenHoa = r.Hoa.TenHoa,
                            SoLuongBan = r.SoLuongBan,
                            DonGiaBan = r.DonGiaBan,
                            ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                        }).ToList();

                    hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
                }
            }
            else // Chế độ Thêm mới
            {
                dtpNgayLap.Value = DateTime.Now;
                dtpNgayGiao.Value = DateTime.Now;
                cboTrangThaiGiao.SelectedValue = TrangThaiGiaoHang.ChoGiao;
            }

            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboHoa.Text))
            {
                MessageBox.Show("Vui lòng chọn hoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numSoLuongBan.Value <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải > 0");
                return;
            }

            // 👇 CHỈ chạy khi hợp lệ
            int maHoa = Convert.ToInt32(cboHoa.SelectedValue.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.HoaID == maHoa);

            if (chiTiet != null)
            {
                chiTiet.SoLuongBan += Convert.ToInt16(numSoLuongBan.Value);
                chiTiet.ThanhTien = chiTiet.SoLuongBan * chiTiet.DonGiaBan;
                dataGridView.Refresh();
            }
            else
            {
                DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                {
                    ID = 0,
                    HoaDonID = id,
                    HoaID = maHoa,
                    TenHoa = cboHoa.Text,
                    SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                    DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                    ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
                };
                hoaDonChiTiet.Add(ct);
            }

            cboHoa.SelectedIndex = -1;
            cboHoa.Text = "-- Chọn loại hoa --";
            numSoLuongBan.Value = 1;
            numDonGiaBan.Value = 0;

            BatTatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*
            int maHoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.HoaID == maHoa);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
            */

            try
            {
                if (dataGridView.CurrentRow == null) return;

                int maHoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaID"].Value);
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.HoaID == maHoa);

                if (chiTiet != null)
                {
                    // Nếu là hóa đơn đang tạo mới (chưa lưu vào DB) thì chỉ xóa khỏi danh sách hiển thị
                    hoaDonChiTiet.Remove(chiTiet);
                }

                BatTatChucNang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa mặt hàng này vì nó đã có trong dữ liệu hệ thống!", "Thông báo");
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboKhachHang.SelectedValue == null || hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Lỗi");
                return;
            }

            // 2. CHÈN RÀNG BUỘC SỐ ĐIỆN THOẠI TẠI ĐÂY
            // Lưu ý: Thêm "using System.Text.RegularExpressions;" ở trên cùng file code
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDTNhan.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại người nhận không hợp lệ (phải nhập đúng 10 chữ số)!", "Thông báo");
                txtSDTNhan.Focus(); // Đưa con trỏ chuột vào ô SDT để người dùng sửa ngay
                return; // Dừng hàm, không chạy xuống phần lưu bên dưới
            }

            using (var dbTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    HoaDon hd;
                    if (id != 0)
                    {
                        /*
                        hd = context.HoaDon.Include(h => h.GiaoHang).FirstOrDefault(h => h.ID == id);
                        var oldDetails = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(oldDetails);
                        */

                        hd = context.HoaDon.Include(h => h.GiaoHang).FirstOrDefault(h => h.ID == id);
                        var oldDetails = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();

                        // --- BỔ SUNG: CỘNG LẠI KHO TRƯỚC KHI XÓA CHI TIẾT CŨ ---
                        foreach (var oldItem in oldDetails)
                        {
                            var hoa = context.Hoa.Find(oldItem.HoaID);
                            if (hoa != null)
                            {
                                hoa.SoLuong = (short)(hoa.SoLuong + oldItem.SoLuongBan); // Trả lại hàng vào kho
                            }
                        }
                        // ------------------------------------------------------

                        context.HoaDon_ChiTiet.RemoveRange(oldDetails);
                    }
                    else
                    {
                        hd = new HoaDon() { NgayLap = dtpNgayLap.Value };
                        context.HoaDon.Add(hd);
                    }

                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    hd.PhiGiaoHang = numPhiGiaoHang.Value;

                    context.SaveChanges();
                    id = hd.ID;

                    foreach (var item in hoaDonChiTiet)
                    {
                        /*
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            HoaID = item.HoaID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        });
                        */

                        // 1. Tìm bông hoa trong bảng Hoa để trừ kho
                        var hoaTrongKho = context.Hoa.Find(item.HoaID);

                        if (hoaTrongKho != null)
                        {
                            // 👉 NÊN THÊM ĐOẠN NÀY: Kiểm tra đủ hàng không
                            if (hoaTrongKho.SoLuong < item.SoLuongBan)
                            {
                                // Báo lỗi và dừng toàn bộ quá trình lưu (Rollback sẽ tự kích hoạt nhờ dbTransaction)
                                throw new Exception($"Hoa '{hoaTrongKho.TenHoa}' không đủ hàng (Kho còn: {hoaTrongKho.SoLuong})");
                            }

                            // 2. Trừ số lượng tồn kho (Thảo đã có - giữ nguyên)
                            hoaTrongKho.SoLuong = (short)(hoaTrongKho.SoLuong - item.SoLuongBan);
                        }

                        // 3. Lưu vào bảng Chi tiết hóa đơn (Thảo đã có - giữ nguyên)
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            HoaID = item.HoaID,
                            SoLuongBan = (short)item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        });
                    }

                    var gh = context.GiaoHang.FirstOrDefault(x => x.HoaDonID == id);
                    if (gh == null)
                    {
                        gh = new GiaoHang { HoaDonID = id };
                        context.GiaoHang.Add(gh);
                    }

                    gh.NhanVienID = hd.NhanVienID;
                    gh.TenNguoiNhan = txtTenNguoiNhan.Text.Trim();
                    gh.DienThoaiNhan = txtSDTNhan.Text.Trim();
                    gh.DiaChiGiao = txtDiaChiGiao.Text.Trim();
                    gh.NgayGiao = dtpNgayGiao.Value; // Lấy từ dtpNgayGiao riêng biệt
                    gh.TrangThai = (TrangThaiGiaoHang)cboTrangThaiGiao.SelectedValue;

                    context.SaveChanges();
                    dbTransaction.Commit();

                    MessageBox.Show("Lưu thành công!", "Thông báo");
                    this.Close();
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void cboHoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maHoa = Convert.ToInt32(cboHoa.SelectedValue.ToString());
            var Hoa = context.Hoa.Find(maHoa);
            numDonGiaBan.Value = Hoa.DonGia;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem hóa đơn đã được lưu vào CSDL chưa
            if (id == 0)
            {
                MessageBox.Show("Bạn chưa lưu hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin hóa đơn và chi tiết từ CSDL
            var hoaDon = context.HoaDon.Find(id);
            var chiTiet = context.HoaDon_ChiTiet
                .Where(r => r.HoaDonID == id)
                .ToList();

            if (chiTiet == null || chiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sản phẩm hoa!", "Thông báo");
                return;
            }

            // 3. Khởi tạo chuỗi nội dung hóa đơn
            string s = "===== HÓA ĐƠN BÁN HÀNG =====\n\n";
            s += $"Mã hóa đơn: {id}\n";
            s += $"Ngày lập: {hoaDon.NgayLap:dd/MM/yyyy HH:mm}\n";
            s += $"Nhân viên: {cboNhanVien.Text}\n";
            s += $"Khách hàng: {cboKhachHang.Text}\n";
            s += "----------------------------------------------\n";

            decimal tongTienHoa = 0;

            // 4. Duyệt qua danh sách sản phẩm để tính tiền
            foreach (var ct in chiTiet)
            {
                var sp = context.Hoa.Find(ct.HoaID);
                decimal thanhTien = ct.SoLuongBan * ct.DonGiaBan;

                // Hiển thị: Tên hoa | SL x Đơn giá = Thành tiền
                s += $"{sp.TenHoa}\n";
                s += $"   {ct.SoLuongBan} x {ct.DonGiaBan:N0} = {thanhTien:N0} VNĐ\n";

                tongTienHoa += thanhTien;
            }

            // 5. Tính toán phí giao hàng và tổng thanh toán
            decimal phiGiao = numPhiGiaoHang.Value;
            decimal tongThanhToan = tongTienHoa + phiGiao;

            // 6. Phần tổng kết cuối hóa đơn
            s += "----------------------------------------------\n";
            s += $"Tiền hoa:     {tongTienHoa:N0} VNĐ\n";
            s += $"Phí giao hàng: {phiGiao:N0} VNĐ\n";
            s += $"Ghi chú:      {txtGhiChuHoaDon.Text}\n";
            s += "==============================================\n";
            s += $"TỔNG CỘNG:    {tongThanhToan:N0} VNĐ\n";
            s += "==============================================\n\n";
            s += "Cảm ơn quý khách, hẹn gặp lại!";

            // 7. Hiển thị hóa đơn ra màn hình
            MessageBox.Show(s, "Thông tin hóa đơn chi tiết");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất Chi Tiết Hóa Đơn";
            saveFileDialog.Filter = "Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "ChiTietHoaDon.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("HoaDonID", typeof(int));
                    table.Columns.Add("HoaID", typeof(int));
                    table.Columns.Add("SoLuong", typeof(int));
                    table.Columns.Add("DonGia", typeof(decimal));

                    var ds = context.HoaDon_ChiTiet.ToList();

                    foreach (var item in ds)
                    {
                        table.Rows.Add(
                            item.HoaDonID,
                            item.HoaID,
                            item.SoLuongBan,
                            item.DonGiaBan
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(table, "ChiTietHoaDon");
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập Chi Tiết Hóa Đơn từ Excel";
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

                        foreach (DataRow r in table.Rows)
                        {
                            /*
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();

                            ct.HoaDonID = int.Parse(r["HoaDonID"].ToString());
                            ct.HoaID = int.Parse(r["HoaID"].ToString());
                            ct.SoLuongBan = short.Parse(r["SoLuong"].ToString());
                            ct.DonGiaBan = decimal.Parse(r["DonGia"].ToString());

                            context.HoaDon_ChiTiet.Add(ct);
                            */

                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();

                            ct.HoaDonID = int.Parse(r["HoaDonID"].ToString());
                            ct.HoaID = int.Parse(r["HoaID"].ToString());
                            ct.SoLuongBan = short.Parse(r["SoLuong"].ToString());
                            ct.DonGiaBan = decimal.Parse(r["DonGia"].ToString());

                            // --- BỔ SUNG: TRỪ KHO KHI NHẬP TỪ EXCEL ---
                            var hoaTrongKho = context.Hoa.Find(ct.HoaID);
                            if (hoaTrongKho != null)
                            {
                                // Kiểm tra tồn kho trước khi trừ
                                if (hoaTrongKho.SoLuong < ct.SoLuongBan)
                                {
                                    MessageBox.Show($"Hoa ID {ct.HoaID} không đủ tồn kho để nhập!");
                                    continue; // Hoặc dùng return nếu muốn dừng hẳn
                                }
                                hoaTrongKho.SoLuong = (short)(hoaTrongKho.SoLuong - ct.SoLuongBan);
                            }
                            // -----------------------------------------

                            context.HoaDon_ChiTiet.Add(ct);
                        }

                        context.SaveChanges();

                        MessageBox.Show("Đã nhập " + table.Rows.Count + " dòng.",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        frmHoaDon_ChiTiet_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LaySanPhamVaoComboBox();
            if (e.RowIndex < 0) return; // tránh click header

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            // Lấy dữ liệu từ dòng
            int hoaID = Convert.ToInt32(row.Cells["HoaID"].Value);
            int soLuong = Convert.ToInt32(row.Cells["SoLuongBan"].Value);
            int donGia = Convert.ToInt32(row.Cells["DonGiaBan"].Value);

            // Đổ lên control
            cboHoa.SelectedValue = hoaID;
            numSoLuongBan.Value = soLuong;
            numDonGiaBan.Value = donGia;
        }
    }
}
