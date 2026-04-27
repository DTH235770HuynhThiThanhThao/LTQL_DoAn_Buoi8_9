using Microsoft.Reporting.WinForms;
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
using static QuanLyTiemGiaoHoa.Reports.QLTGHDataSet;
using System.IO;

namespace QuanLyTiemGiaoHoa.Reports
{
    public partial class frmThongKeHoaBanChay : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        QLTGHDataSet.DanhSachHoaBanChayDataTable danhSachHoaBanChayDataTable = new QLTGHDataSet.DanhSachHoaBanChayDataTable();
        string reportsFolder = Path.Combine(Application.StartupPath, "..", "..", "..", "Reports");
        string reportName = "rptThongKeHoaBanChay.rdlc";

        public frmThongKeHoaBanChay()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaBanChay_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mặc định là hôm nay
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;

            // Load dữ liệu mặc định (tất cả)
            HienThiBaoCao(null, null);
        }

        private void HienThiBaoCao(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            // 1. Truy vấn dữ liệu từ HoaDon_ChiTiet
            var query = context.HoaDon_ChiTiet.AsQueryable();

            // Lọc theo ngày dựa trên hóa đơn cha
            if (tuNgay.HasValue && denNgay.HasValue)
            {
                // Lấy từ 00:00:00 ngày bắt đầu đến 23:59:59 ngày kết thúc
                DateTime start = tuNgay.Value.Date;
                DateTime end = denNgay.Value.Date.AddDays(1).AddTicks(-1);

                query = query.Where(ct => ct.HoaDon.NgayLap >= start && ct.HoaDon.NgayLap <= end);
            }

            // Chỉ thống kê các hóa đơn đã giao thành công (giống form doanh thu)
            query = query.Where(ct => ct.HoaDon.GiaoHang.TrangThai == TrangThaiGiaoHang.DaGiao);

            // 2. Gom nhóm theo HoaID và TenHoa
            var thongKeData = query.GroupBy(ct => new { ct.HoaID, ct.Hoa.TenHoa })
                .Select(g => new
                {
                    IDHoa = g.Key.HoaID,
                    Ten = g.Key.TenHoa,
                    TongSL = g.Sum(x => (int)x.SoLuongBan),
                    GiaBan = g.Max(x => x.DonGiaBan), // Lấy đơn giá bán cao nhất hoặc hiện tại
                    TongTien = g.Sum(x => x.SoLuongBan * x.DonGiaBan)
                })
                .OrderByDescending(x => x.TongSL) // Sắp xếp bán chạy nhất lên đầu
                .Take(10) // Thêm dòng này để lấy đúng  thằng đầu bảng
                .ToList();

            // 3. Đổ dữ liệu vào DataTable của Dataset
            danhSachHoaBanChayDataTable.Clear();
            int stt = 1;

            foreach (var item in thongKeData)
            {
                danhSachHoaBanChayDataTable.AddDanhSachHoaBanChayRow(
                    stt,              // Cột ID dùng làm Số thứ tự
                    item.IDHoa,       // HoaID
                    item.Ten,         // TenHoa
                    (short)item.TongSL, // Ép kiểu về Int16 cho đúng Dataset
                    item.GiaBan,      // DonGiaBan
                    item.TongTien     // ThanhTien
                );
                stt++;
            }

            // 4. Thiết lập ReportViewer
            reportViewer.LocalReport.DataSources.Clear();
            // "DataSetHoaBanChay" phải trùng với tên Dataset bạn đặt trong file .rdlc
            ReportDataSource rds = new ReportDataSource("DanhSachHoaBanChay", (DataTable)danhSachHoaBanChayDataTable);
            reportViewer.LocalReport.DataSources.Add(rds);

            // Đường dẫn file report
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, reportName);

            // 5. Truyền tham số mô tả (Parameter)
            string moTa = (tuNgay.HasValue && denNgay.HasValue)
                ? $"Từ ngày: {tuNgay.Value:dd/MM/yyyy} - Đến ngày: {denNgay.Value:dd/MM/yyyy}"
                : "Tất cả thời gian";

            ReportParameter pa = new ReportParameter("MoTaKetQuaHienThi", moTa);
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { pa });

            // Định dạng hiển thị
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            HienThiBaoCao(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            HienThiBaoCao(null, null);
        }
    }
}
