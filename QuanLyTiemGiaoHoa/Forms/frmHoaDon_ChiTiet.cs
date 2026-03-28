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



            // Cách an toàn nhất để đổ dữ liệu: Kiểm tra cột có tồn tại không rồi mới gán
            void BindCol(string colName, string propertyName)
            {
                if (dataGridView.Columns.Contains(colName))
                {
                    dataGridView.Columns[colName].DataPropertyName = propertyName;
                }
            }

            // Map đầy đủ các cột
            BindCol("ID", "ID");
            BindCol("HoaID", "HoaID");
            BindCol("TenHoa", "TenHoa");
            BindCol("SoLuongBan", "SoLuongBan");
            BindCol("DonGiaBan", "DonGiaBan");
            BindCol("ThanhTien", "ThanhTien");

            // Định dạng tiền tệ cho đẹp
            if (dataGridView.Columns.Contains("DonGiaBan"))
                dataGridView.Columns["DonGiaBan"].DefaultCellStyle.Format = "N0";
            if (dataGridView.Columns.Contains("ThanhTien"))
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            numPhiGiaoHang.ThousandsSeparator = true;

            if (id != 0) // Đã tồn tại chi tiết 
            {
                var hoaDon = context.HoaDon
     .Include(h => h.GiaoHang) // Thêm dòng này
     .FirstOrDefault(r => r.ID == id);
                cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;
                numPhiGiaoHang.Value = hoaDon.PhiGiaoHang;
                // Lấy trạng thái từ bảng GiaoHang nếu có
                if (hoaDon.GiaoHang != null)
                    cboTrangThaiGiao.SelectedValue = hoaDon.GiaoHang.TrangThai;

                var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
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

            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();


        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboHoa.Text))
                MessageBox.Show("Vui lòng chọn hoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm hoa phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maHoa = Convert.ToInt32(cboHoa.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.HoaID == maHoa);

                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin  
                if (chiTiet != null)
                {

                    // Cộng dồn thay vì ghi đè
                    chiTiet.SoLuongBan += Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.ThanhTien = chiTiet.SoLuongBan * chiTiet.DonGiaBan;
                    dataGridView.Refresh();


                }
                else // Nếu chưa có sản phẩm thì thêm vào 
                {
                    // Nếu chưa có sản phẩm nào 
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

                // SAU KHI THÊM XONG, TIẾN HÀNH XÓA TRẮNG ĐỂ NHẬP TIẾP:
                cboHoa.SelectedIndex = -1;      // Xóa chọn hoa
                cboHoa.Text = "-- Chọn loại hoa --";   // Hiển thị dòng hướng dẫn
                numSoLuongBan.Value = 1;        // Reset số lượng về 1
                numDonGiaBan.Value = 0;         // Reset đơn giá về 0

                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maHoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["HoaID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.HoaID == maHoa);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào cơ bản
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất một mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sử dụng Transaction để đảm bảo an toàn dữ liệu (Lưu HĐ, CTHĐ và GiaoHang cùng lúc)
            using (var dbTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    HoaDon hd;
                    if (id != 0) // CHẾ ĐỘ SỬA
                    {
                        hd = context.HoaDon.Include(h => h.GiaoHang).FirstOrDefault(h => h.ID == id);
                        if (hd == null) return;

                        // Cập nhật thông tin Hóa đơn
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        hd.PhiGiaoHang = numPhiGiaoHang.Value; // Bổ sung phí giao

                        // Xóa chi tiết cũ để nạp lại chi tiết mới
                        var oldDetails = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(oldDetails);
                    }
                    else // CHẾ ĐỘ THÊM MỚI
                    {
                        hd = new HoaDon();
                        hd.NgayLap = DateTime.Now;
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        hd.PhiGiaoHang = numPhiGiaoHang.Value; // Bổ sung phí giao

                        context.HoaDon.Add(hd);
                    }

                    // Lưu bước 1 để có ID (nếu thêm mới)
                    context.SaveChanges();
                    id = hd.ID;

                    // 2. Thêm Chi tiết hóa đơn
                    foreach (var item in hoaDonChiTiet)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            HoaID = item.HoaID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        };
                        context.HoaDon_ChiTiet.Add(ct);
                    }

                    // 3. Xử lý Trạng thái Giao hàng (Bảng GiaoHang)
                    var gh = context.GiaoHang.FirstOrDefault(x => x.HoaDonID == id);
                    TrangThaiGiaoHang trangThaiChon = (TrangThaiGiaoHang)cboTrangThaiGiao.SelectedValue;

                    if (gh == null) // Nếu chưa có đơn giao hàng thì tạo mới
                    {
                        gh = new GiaoHang
                        {
                            HoaDonID = id,
                            NhanVienID = hd.NhanVienID, // Mặc định NV lập đơn là người giao
                            TenNguoiNhan = cboKhachHang.Text,
                            DiaChiGiao = "Cập nhật sau...",
                            DienThoaiNhan = "0000000000",
                            NgayGiao = DateTime.Now.AddDays(1),
                            TrangThai = trangThaiChon
                        };
                        context.GiaoHang.Add(gh);
                    }
                    else // Nếu có rồi thì cập nhật trạng thái
                    {
                        gh.TrangThai = trangThaiChon;
                        context.GiaoHang.Update(gh);
                    }

                    // Lưu toàn bộ vào Database
                    context.SaveChanges();

                    // Xác nhận hoàn tất giao dịch
                    dbTransaction.Commit();

                    MessageBox.Show("Đã lưu hóa đơn và cập nhật trạng thái giao hàng thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, hủy bỏ mọi thay đổi đã thực hiện trong khối try
                    dbTransaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
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
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet();

                            ct.HoaDonID = int.Parse(r["HoaDonID"].ToString());
                            ct.HoaID = int.Parse(r["HoaID"].ToString());
                            ct.SoLuongBan = short.Parse(r["SoLuong"].ToString());
                            ct.DonGiaBan = decimal.Parse(r["DonGia"].ToString());

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
