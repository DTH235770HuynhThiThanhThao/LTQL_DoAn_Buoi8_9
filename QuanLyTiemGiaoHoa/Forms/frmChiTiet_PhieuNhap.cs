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
using ClosedXML.Excel;
//using System.Data;

namespace QuanLyTiemGiaoHoa.Forms
{
    public partial class frmChiTiet_PhieuNhap : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        int id; // Mã phiếu nhập
        BindingList<DanhSachChiTiet_PhieuNhap> dsChiTiet = new BindingList<DanhSachChiTiet_PhieuNhap>();
        bool dangTimKiem = false;

        public frmChiTiet_PhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }

        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayNhaCungCapVaoComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
        }

        public void LayHoaVaoComboBox()
        {
            cboHoa.DataSource = context.Hoa.ToList();
            cboHoa.ValueMember = "ID";
            cboHoa.DisplayMember = "TenHoa";
        }

        private void TinhTongTien()
        {
            // Tính tổng từ danh sách chi tiết (ThanhTien = SoLuongNhap * DonGiaNhap)
            decimal tongTien = dsChiTiet.Sum(x => x.ThanhTien);

        }



        private void frmChiTiet_PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LayNhanVienVaoComboBox();
            LayNhaCungCapVaoComboBox();
            LayHoaVaoComboBox();

            if (id > 0) // Chế độ Sửa: Load dữ liệu cũ lên
            {
                var pn = context.PhieuNhap
                    .Include(x => x.ChiTiet_PhieuNhap)
                    .ThenInclude(x => x.Hoa)
                    .FirstOrDefault(x => x.ID == id);

                if (pn != null)
                {
                    cboNhanVien.SelectedValue = pn.NhanVienID;
                    cboNhaCungCap.SelectedValue = pn.NhaCungCapID;
                    dtpNgayNhap.Value = pn.NgayNhap;
                    txtGhiChuPhieuNhap.Text = pn.GhiChu;

                    dsChiTiet.Clear();
                    foreach (var ct in pn.ChiTiet_PhieuNhap)
                    {
                        dsChiTiet.Add(new DanhSachChiTiet_PhieuNhap
                        {
                            ID = ct.ID,
                            PhieuNhapID = ct.PhieuNhapID,
                            HoaID = ct.HoaID,
                            TenHoa = ct.Hoa.TenHoa,
                            SoLuongNhap = ct.SoLuongNhap, // Cột mới sửa
                            DonGiaNhap = ct.DonGiaNhap,   // Cột mới sửa
                            ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap
                        });
                    }
                }
            }
            dataGridView.DataSource = dsChiTiet;
            TinhTongTien();
        }

        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            if (cboHoa.SelectedValue == null) return;

            int hoaID = (int)cboHoa.SelectedValue;
            string tenHoa = cboHoa.Text;

            // Sửa lại tên control cho đúng mục đích Nhập hàng
            int soLuong = (int)numSoLuongNhap.Value;
            decimal donGia = numDonGiaNhap.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!");
                return;
            }

            var sanPhamTonTai = dsChiTiet.FirstOrDefault(x => x.HoaID == hoaID);
            if (sanPhamTonTai != null)
            {
                // Nếu trùng sản phẩm, cộng dồn số lượng và cập nhật đơn giá mới nhất
                sanPhamTonTai.SoLuongNhap += (short)soLuong;
                sanPhamTonTai.DonGiaNhap = donGia;
                sanPhamTonTai.ThanhTien = sanPhamTonTai.SoLuongNhap * sanPhamTonTai.DonGiaNhap;
                dataGridView.Refresh();
            }
            else
            {
                dsChiTiet.Add(new DanhSachChiTiet_PhieuNhap
                {
                    HoaID = hoaID,
                    TenHoa = tenHoa,
                    SoLuongNhap = (short)soLuong,
                    DonGiaNhap = donGia,
                    ThanhTien = soLuong * donGia
                });
            }

            TinhTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var item = (DanhSachChiTiet_PhieuNhap)dataGridView.CurrentRow.DataBoundItem;
                dsChiTiet.Remove(item);
                TinhTongTien();
            }
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            /* if (dsChiTiet.Count == 0)
             {
                 MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm!");
                 return;
             }

             try
             {
                 PhieuNhap pn;
                 if (id == 0)
                 {
                     pn = new PhieuNhap();
                     context.PhieuNhap.Add(pn);
                 }
                 else
                 {
                     pn = context.PhieuNhap.Include(x => x.ChiTiet_PhieuNhap).FirstOrDefault(x => x.ID == id);
                     if (pn != null)
                     {
                         // Xóa chi tiết cũ
                         context.ChiTiet_PhieuNhap.RemoveRange(pn.ChiTiet_PhieuNhap);
                     }
                 }

                 pn.NhanVienID = (int)cboNhanVien.SelectedValue;
                 pn.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;
                 pn.NgayNhap = dtpNgayNhap.Value;
                 pn.GhiChu = txtGhiChuPhieuNhap.Text;

                 // Ép buộc lưu Header trước để lấy ID nếu là thêm mới
                 if (id == 0) context.SaveChanges();

                 foreach (var item in dsChiTiet)
                 {
                     context.ChiTiet_PhieuNhap.Add(new ChiTiet_PhieuNhap
                     {
                         PhieuNhapID = pn.ID, // Đảm bảo ID luôn đúng
                         HoaID = item.HoaID,
                         SoLuongNhap = (short)item.SoLuongNhap,
                         DonGiaNhap = item.DonGiaNhap
                     });
                 }

                 context.SaveChanges();
                 MessageBox.Show("Lưu phiếu nhập thành công!", "Thông báo");
                 this.DialogResult = DialogResult.OK; // Trả về OK để form cha load lại data
                 this.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Lỗi: " + ex.InnerException?.Message ?? ex.Message);
             }
            */

            if (dsChiTiet.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm!");
                return;
            }

            // Sử dụng Transaction để đảm bảo: Hoặc lưu tất cả thành công, hoặc không lưu gì cả (nếu lỗi)
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    PhieuNhap pn;
                    if (id == 0)
                    {
                        pn = new PhieuNhap();
                        context.PhieuNhap.Add(pn);
                    }
                    else
                    {
                        pn = context.PhieuNhap.Include(x => x.ChiTiet_PhieuNhap).FirstOrDefault(x => x.ID == id);
                        if (pn != null)
                        {
                            // Nếu là sửa, ta cần hoàn trả số lượng cũ về kho trước khi xóa chi tiết cũ
                            foreach (var ctOld in pn.ChiTiet_PhieuNhap)
                            {
                                var hoaKho = context.Hoa.Find(ctOld.HoaID);
                                if (hoaKho != null) hoaKho.SoLuong -= ctOld.SoLuongNhap;
                            }
                            context.ChiTiet_PhieuNhap.RemoveRange(pn.ChiTiet_PhieuNhap);
                        }
                    }

                    // Cập nhật thông tin Header
                    pn.NhanVienID = (int)cboNhanVien.SelectedValue;
                    pn.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;
                    pn.NgayNhap = dtpNgayNhap.Value;
                    pn.GhiChu = txtGhiChuPhieuNhap.Text;

                    // Lưu Header trước để có ID
                    context.SaveChanges();

                    // Duyệt danh sách đang hiển thị trên Grid để lưu chi tiết và CẬP NHẬT KHO
                    foreach (var item in dsChiTiet)
                    {
                        // 1. Thêm chi tiết phiếu nhập
                        context.ChiTiet_PhieuNhap.Add(new ChiTiet_PhieuNhap
                        {
                            PhieuNhapID = pn.ID,
                            HoaID = item.HoaID,
                            SoLuongNhap = (short)item.SoLuongNhap,
                            DonGiaNhap = item.DonGiaNhap
                        });

                        // 2. LOGIC QUAN TRỌNG: Cộng thêm số lượng vào bảng Hoa
                        var hoa = context.Hoa.Find(item.HoaID);
                        if (hoa != null)
                        {
                            // Cộng dồn số lượng vừa nhập vào cột SoLuong của bảng Hoa
                            // Dòng đã sửa
                            hoa.SoLuong = (int)(hoa.SoLuong + item.SoLuongNhap);
                        }
                    }

                    context.SaveChanges();
                    transaction.Commit(); // Chốt giao dịch thành công

                    MessageBox.Show("Lưu phiếu nhập và cập nhật kho thành công!", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Nếu có lỗi, hủy bỏ toàn bộ thay đổi để tránh sai lệch số lượng kho
                    MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message));
                }
            }





        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (DanhSachChiTiet_PhieuNhap)dataGridView.Rows[e.RowIndex].DataBoundItem;
            cboHoa.SelectedValue = item.HoaID;
            numSoLuongNhap.Value = (decimal)item.SoLuongNhap;
            numDonGiaNhap.Value = item.DonGiaNhap;
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem phiếu nhập đã được lưu vào CSDL chưa (tránh in phiếu rỗng)
            if (id == 0)
            {
                MessageBox.Show("Bạn chưa lưu phiếu nhập này vào hệ thống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin phiếu nhập từ CSDL dựa vào id
            var phieuNhap = context.PhieuNhap.Find(id);

            // Lấy chi tiết phiếu nhập (bao gồm cả thông tin Hoa để lấy tên hoa)
            var chiTiet = context.ChiTiet_PhieuNhap
                .Where(r => r.PhieuNhapID == id)
                .ToList();

            if (chiTiet == null || chiTiet.Count == 0)
            {
                MessageBox.Show("Phiếu nhập này chưa có mặt hàng nào!", "Thông báo");
                return;
            }

            // 3. Khởi tạo chuỗi nội dung hiển thị
            string s = "===== PHIẾU NHẬP HÀNG =====\n\n";
            s += $"Mã phiếu: {id}\n";
            s += $"Ngày nhập: {phieuNhap.NgayNhap:dd/MM/yyyy HH:mm}\n";
            s += $"Nhân viên: {cboNhanVien.Text}\n";
            s += $"Nhà cung cấp: {cboNhaCungCap.Text}\n";
            s += "----------------------------------------------\n";

            decimal tongTienPhieu = 0;

            // 4. Duyệt qua danh sách chi tiết để cộng dồn tiền và nối chuỗi
            foreach (var ct in chiTiet)
            {
                // Tìm thông tin hoa để lấy tên
                var hoa = context.Hoa.Find(ct.HoaID);
                decimal thanhTien = ct.SoLuongNhap * ct.DonGiaNhap;

                // Định dạng hiển thị: Tên hoa | SL x Đơn giá = Thành tiền
                s += $"{hoa.TenHoa}\n";
                s += $"   {ct.SoLuongNhap} x {ct.DonGiaNhap:N0} = {thanhTien:N0} VNĐ\n";

                tongTienPhieu += thanhTien;
            }

            // 5. Phần tổng kết cuối phiếu
            s += "----------------------------------------------\n";
            s += $"Ghi chú: {txtGhiChuPhieuNhap.Text}\n";
            s += "==============================================\n";
            s += $"TỔNG CỘNG TIỀN NHẬP: {tongTienPhieu:N0} VNĐ\n";
            s += "==============================================\n\n";
            s += "Xác nhận hàng đã nhập kho thành công!";

            // 6. Hiển thị toàn bộ nội dung ra MessageBox
            MessageBox.Show(s, "Thông tin chi tiết Phiếu Nhập");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Workbook|*.xlsx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            var ws = workbook.Worksheet(1);
                            var rows = ws.RangeUsed().RowsUsed().Skip(1); // bỏ header

                            // 🔥 XÓA dữ liệu cũ
                            dsChiTiet.Clear();

                            foreach (var r in rows)
                            {
                                if (r.Cell(1).IsEmpty()) continue;

                                int hoaID = 0;
                                short soLuong = 0;
                                decimal donGia = 0;

                                int.TryParse(r.Cell(1).Value.ToString(), out hoaID);
                                short.TryParse(r.Cell(2).Value.ToString(), out soLuong);
                                decimal.TryParse(r.Cell(3).Value.ToString(), out donGia);

                                if (hoaID == 0 || soLuong <= 0) continue;

                                var hoa = context.Hoa.Find(hoaID);

                                if (hoa == null)
                                {
                                    MessageBox.Show($"Hoa ID {hoaID} không tồn tại!");
                                    continue;
                                }

                                dsChiTiet.Add(new DanhSachChiTiet_PhieuNhap
                                {
                                    HoaID = hoaID,
                                    TenHoa = hoa != null ? hoa.TenHoa : "Không tồn tại",
                                    SoLuongNhap = soLuong,
                                    DonGiaNhap = donGia,
                                    ThanhTien = soLuong * donGia
                                });
                            }

                            // 🔥 LOAD LẠI GRID (QUAN TRỌNG)
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = dsChiTiet;

                            TinhTongTien(); // 🔥 BẮT BUỘC

                            MessageBox.Show("Nhập Excel thành công!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nhập Excel: " + ex.Message);
                    }
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "ChiTietPhieuNhap.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Mã Hoa");
                            dt.Columns.Add("Tên Hoa");
                            dt.Columns.Add("Số Lượng");
                            dt.Columns.Add("Đơn Giá");
                            dt.Columns.Add("Thành Tiền");

                            foreach (var item in dsChiTiet)
                            {
                                dt.Rows.Add(
                                    item.HoaID,
                                    item.TenHoa,
                                    item.SoLuongNhap,
                                    item.DonGiaNhap,
                                    item.ThanhTien
                                );
                            }

                            var ws = workbook.Worksheets.Add(dt, "ChiTiet");

                            ws.Column(4).Style.NumberFormat.Format = "#,##0";
                            ws.Column(5).Style.NumberFormat.Format = "#,##0";

                            ws.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Xuất Excel thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
