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
    public partial class frmThongKeDoanhThu : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        QLTGHDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLTGHDataSet.DanhSachHoaDonDataTable();
        //string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        // Thay thế dòng cũ bằng dòng này
        string reportsFolder = Path.Combine(Application.StartupPath, "..", "..", "..", "Reports");
        string reportName = "rptThongKeDoanhThu.rdlc";
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định cho các DateTimePicker
            /* dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
             dtpDenNgay.Value = DateTime.Now;

             HienThiBaoCao();
            */


            // Đặt ngày chỉ để hiển thị (không ảnh hưởng lọc)
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;

            // Gọi KHÔNG truyền ngày → lấy tất cả
            HienThiBaoCao(null, null);
        }


        private void HienThiBaoCao(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            var query = context.HoaDon.AsQueryable();

            query = query.Where(r => r.GiaoHang.TrangThai == TrangThaiGiaoHang.DaGiao);

            if (tuNgay.HasValue && denNgay.HasValue)
            {
                query = query.Where(r => r.NgayLap.Date >= tuNgay.Value.Date
                                      && r.NgayLap.Date <= denNgay.Value.Date);
            }

            var danhSachHoaDon = query.Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLap,
                r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan),
                r.PhiGiaoHang,

                TrangThaiID = r.GiaoHang != null ? (int)r.GiaoHang.TrangThai : 0,
                TenTrangThaiGiao = r.GiaoHang == null ? "Chưa có" :
                                   r.GiaoHang.TrangThai == TrangThaiGiaoHang.ChoGiao ? "Chờ giao" :
                                   r.GiaoHang.TrangThai == TrangThaiGiaoHang.DangGiao ? "Đang giao" :
                                   r.GiaoHang.TrangThai == TrangThaiGiaoHang.DaGiao ? "Đã giao" : "Hủy"
            }).ToList();

            danhSachHoaDonDataTable.Clear();

            foreach (var item in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    item.ID,
                    item.NhanVienID,
                    item.HoVaTenNhanVien,
                    item.KhachHangID,
                    item.HoVaTenKhachHang,
                    item.NgayLap,
                    item.GhiChuHoaDon,
                    item.TongTienHoaDon,
                    item.PhiGiaoHang,
                    item.TrangThaiID,
                    item.TenTrangThaiGiao
                );
            }

            // DataSource
            ReportDataSource rds = new ReportDataSource("DanhSachHoaDon", (DataTable)danhSachHoaDonDataTable);

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);

            // Quan trọng nhất (fix lỗi của bạn)
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, reportName);

            // Parameter
            //string moTa = $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} - Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}";
            string moTa;

            if (tuNgay.HasValue && denNgay.HasValue)
            {
                moTa = $"Từ ngày: {tuNgay.Value:dd/MM/yyyy} - Đến ngày: {denNgay.Value:dd/MM/yyyy}";
            }
            else
            {
                moTa = "Tất cả doanh thu";
            }


            ReportParameter pa = new ReportParameter("MoTaKetQuaHienThi", moTa);
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { pa });

            // Hiển thị đẹp giống form kia
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            HienThiBaoCao(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            /*
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            HienThiBaoCao();
            */
            HienThiBaoCao(null, null);
        }
    }
}
