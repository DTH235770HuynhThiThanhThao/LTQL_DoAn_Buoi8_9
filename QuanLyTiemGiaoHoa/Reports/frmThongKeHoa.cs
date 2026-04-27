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
            // 1. Đổ dữ liệu vào ComboBox Nhà cung cấp
            var ncc = context.NhaCungCap.ToList();
            ncc.Insert(0, new NhaCungCap { ID = 0, TenNhaCungCap = "-- Tất cả --" });
            cboNhaCungCap.DataSource = ncc;
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";

            // 2. Đổ dữ liệu vào ComboBox Loại hoa
            var loai = context.LoaiHoa.ToList();
            loai.Insert(0, new LoaiHoa { ID = 0, TenLoai = "-- Tất cả --" });
            cboLoaiHoa.DataSource = loai;
            cboLoaiHoa.DisplayMember = "TenLoai";
            cboLoaiHoa.ValueMember = "ID";

            // 3. Hiển thị báo cáo mặc định (tất cả)
            LoadReport();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int nccID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
            int loaiID = Convert.ToInt32(cboLoaiHoa.SelectedValue);
           

            LoadReport(nccID, loaiID);
        }


        private void LoadReport(int? nccID = 0, int? loaiID = 0)
        {
            // Truy vấn dữ liệu có lọc
            var query = context.Hoa.AsQueryable();

            if (nccID > 0) query = query.Where(h => h.NhaCungCapID == nccID);
            if (loaiID > 0) query = query.Where(h => h.LoaiHoaID == loaiID);

            var danhSachHoa = query.Select(r => new {
                r.ID,
                r.NhaCungCapID,
                r.NhaCungCap.TenNhaCungCap,
                r.LoaiHoaID,
                r.LoaiHoa.TenLoai,
                r.TenHoa,
                r.DonGia,
                r.SoLuong,
                r.HinhAnh,
                r.MoTa
            }).ToList();

            danhSachHoaDataTable.Clear();
            foreach (var row in danhSachHoa)
            {
                // Chú ý ép kiểu decimal sang int để tránh lỗi CS1503
                danhSachHoaDataTable.AddDanhSachHoaRow(
                    row.ID, row.NhaCungCapID, row.TenNhaCungCap,
                    row.LoaiHoaID, row.TenLoai, row.TenHoa,
                    Convert.ToInt32(row.DonGia),
                    Convert.ToInt32(row.SoLuong),
                    row.HinhAnh, row.MoTa
                );
            }

            ReportDataSource rds = new ReportDataSource("DanhSachHoa", (DataTable)danhSachHoaDataTable);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeHoa.rdlc");

            /*
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả hoa)");
            reportViewer.LocalReport.SetParameters(reportParameter);
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + nhaCungCap + " - " + loaiHoa + ")");
            reportViewer.LocalReport.SetParameters(reportParameter);
            */

            // 1. Lấy tên hiển thị từ ComboBox
            string tenNCC = cboNhaCungCap.Text;
            string tenLoai = cboLoaiHoa.Text;
            string chuoiMoTa = "";

            // 2. Logic tạo chuỗi mô tả linh hoạt
            if (nccID == 0 && loaiID == 0)
            {
                chuoiMoTa = "(Tất cả hoa)";
            }
            else
            {
                chuoiMoTa = $"(Nhà cung cấp: {tenNCC} - Loại hoa: {tenLoai})";
            }

            // 3. Gán giá trị vào Parameter (Đảm bảo tên "MoTaKetQuaHienThi" khớp với file .rdlc)
            ReportParameter pa = new ReportParameter("MoTaKetQuaHienThi", chuoiMoTa);
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { pa });


            // Dùng họ tên đầy đủ để tránh lỗi Ambiguous
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;
            reportViewer.RefreshReport();
        }
    }
}
