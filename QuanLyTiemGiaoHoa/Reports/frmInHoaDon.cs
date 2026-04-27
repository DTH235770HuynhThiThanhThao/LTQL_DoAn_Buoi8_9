using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyTiemGiaoHoa.Data;


namespace QuanLyTiemGiaoHoa.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        QLTGHDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLTGHDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");


        int id; // Mã hóa đơn 

        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }


        

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon
        .Include(r => r.KhachHang)
        .Include(r => r.HoaDon_ChiTiet)
        .ThenInclude(ct => ct.Hoa) //  QUAN TRỌNG
        .FirstOrDefault(r => r.ID == id);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            //  Load chi tiết đúng cách
            var hoaDonChiTiet = hoaDon.HoaDon_ChiTiet.Select(r => new DanhSachHoaDon_ChiTiet
            {
                ID = r.ID,
                HoaDonID = r.HoaDonID,
                HoaID = r.HoaID,
                TenHoa = r.Hoa?.TenHoa,
                SoLuongBan = r.SoLuongBan,
                DonGiaBan = r.DonGiaBan,
                ThanhTien = r.SoLuongBan * r.DonGiaBan //  KHÔNG Convert
            }).ToList();

            danhSachHoaDon_ChiTietDataTable.Clear();

            foreach (var row in hoaDonChiTiet)
            {
                danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(
                    row.ID,
                    row.HoaDonID,
                    row.HoaID,
                    row.TenHoa,
                    row.SoLuongBan,
                    row.DonGiaBan,
                    row.ThanhTien
                );
            }

            //  DataSource
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "DanhSachHoaDon_ChiTiet",
                Value = danhSachHoaDon_ChiTietDataTable
            };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            //  ĐƯỜNG DẪN RDLC CHUẨN (KHÔNG lỗi path)
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "QuanLyTiemGiaoHoa.Reports.rptInHoaDon.rdlc";

            //  TÍNH TỔNG TIỀN ĐÚNG (có phí ship)
            decimal tongTien = hoaDon.HoaDon_ChiTiet
                .Sum(r => r.SoLuongBan * r.DonGiaBan) + hoaDon.PhiGiaoHang;

            IList<ReportParameter> param = new List<ReportParameter>
    {
        new ReportParameter("NgayLap",
            $"Ngày {hoaDon.NgayLap.Day} Tháng {hoaDon.NgayLap.Month} Năm {hoaDon.NgayLap.Year}"),

        new ReportParameter("NguoiBan_Ten", "TIỆM GIAO HOA TƯƠI"),
        new ReportParameter("NguoiBan_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
        new ReportParameter("NguoiBan_MaSoThue", "1602162070"),

        new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang?.HoVaTen),
        new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang?.DiaChi),
        new ReportParameter("NguoiMua_MaSoThue", ""),

         new ReportParameter("PhiGiaoHang", hoaDon.PhiGiaoHang.ToString("N0"))

        //new ReportParameter("TongTien", tongTien.ToString("N0"))
    };

            reportViewer1.LocalReport.SetParameters(param);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.RefreshReport();


        }
        }
}
