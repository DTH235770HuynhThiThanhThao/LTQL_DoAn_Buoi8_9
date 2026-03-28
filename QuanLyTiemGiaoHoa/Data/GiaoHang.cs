using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGiaoHoa.Data
{
    public class GiaoHang
    {
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public int NhanVienID { get; set; } // nhân viên giao

        public string TenNguoiNhan { get; set; }
        public string DienThoaiNhan { get; set; }

        public string DiaChiGiao { get; set; }
        public DateTime NgayGiao { get; set; }


        // Sử dụng Enum từ file TrangThaiGiaoHang.cs bạn vừa tạo
        public TrangThaiGiaoHang TrangThai { get; set; } = TrangThaiGiaoHang.ChoGiao;

        public string? GhiChu { get; set; }

        // Navigation properties để Entity Framework hiểu mối quan hệ
        public HoaDon HoaDon { get; set; }
        public NhanVien NhanVien { get; set; }
    }


    public class DanhSachGiaoHang
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }

        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Hiển thị tên shipper thay vì ID

        public string TenNguoiNhan { get; set; }
        public string DienThoaiNhan { get; set; }
        public string DiaChiGiao { get; set; }
        public DateTime NgayGiao { get; set; }

        public TrangThaiGiaoHang TrangThai { get; set; }

        public decimal? TongTienHoaDon { get; set; } // Tiền cần thu hộ (lấy từ HoaDon)
        public string? GhiChu { get; set; }
    }
}
