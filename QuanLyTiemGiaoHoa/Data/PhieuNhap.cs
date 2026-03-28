using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGiaoHoa.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }
        public int NhaCungCapID { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? GhiChu { get; set; }

        // Navigation
        public NhanVien NhanVien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ICollection<ChiTiet_PhieuNhap> ChiTiet_PhieuNhap { get; set; } = new List<ChiTiet_PhieuNhap>();
    }


    public class DanhSachPhieuNhap
    {

        public int ID { get; set; }

        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Bổ sung
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal? TongTienPhieuNhap { get; set; }// thêm
        public string? GhiChu { get; set; }

        // Navigation
        public NhanVien NhanVien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ICollection<ChiTiet_PhieuNhap> ChiTiet_PhieuNhap { get; set; } = new List<ChiTiet_PhieuNhap>();

    }
}
