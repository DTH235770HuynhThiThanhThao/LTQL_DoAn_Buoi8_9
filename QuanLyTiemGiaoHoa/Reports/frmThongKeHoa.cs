using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyTiemGiaoHoa.Data;
//using System.ComponentModel.Design;


namespace QuanLyTiemGiaoHoa.Reports
{
    public partial class frmThongKeHoa : Form
    {
        QLTGHDbContext context = new QLTGHDbContext();
        QLTGHDataSet.DanhSachHoaDataTable danhSachHoaDataTable = new QLTGHDataSet.DanhSachHoaDataTable();
        //string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        string reportsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports");
        public frmThongKeHoa()
        {
            InitializeComponent();
        }

        private void frmThongKeHoa_Load(object sender, EventArgs e)
        {
            var danhSachHoa = context.Hoa.Select(r => new DanhSachHoa
            {
                ID = r.ID,
                NhaCungCapID = r.NhaCungCapID,
                TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                LoaiHoaID = r.LoaiHoaID,
                TenLoai = r.LoaiHoa.TenLoai,
                TenHoa = r.TenHoa,
                DonGia = r.DonGia,
                SoLuong = r.SoLuong,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            danhSachHoaDataTable.Clear();
            foreach (var row in danhSachHoa)
            {
                danhSachHoaDataTable.AddDanhSachHoaRow(row.ID,
                 row.NhaCungCapID,
                 row.TenNhaCungCap,
                 row.LoaiHoaID,
                 row.TenLoai,
                 row.TenHoa,
                 row.DonGia,
                 row.SoLuong,
                 row.HinhAnh,
                 row.MoTa);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoa";
            reportDataSource.Value = danhSachHoaDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeHoa.rdlc");

            //reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            // THÊM VÀO ĐÂY: Giúp báo cáo tự co giãn vừa khít chiều ngang màn hình
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            reportViewer.ZoomMode = ZoomMode.Percent;
            //reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
