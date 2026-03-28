using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyTiemGiaoHoa.Data
{
    public class HoaDon
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }

        public int KhachHangID { get; set; }


        public DateTime NgayLap { get; set; }
        public decimal PhiGiaoHang { get; set; } = 0; // Thêm phí giao hàng
        public string? GhiChuHoaDon { get; set; }


        // Navigation
        public ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = new List<HoaDon_ChiTiet>();
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }

        // Bổ sung: Thông tin giao hàng của hóa đơn này
        public GiaoHang GiaoHang { get; set; }
    }

    public class DanhSachHoaDon
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // thêm
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } // thêm

        public DateTime NgayLap { get; set; }
        public decimal PhiGiaoHang { get; set; } // thêm
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; }   // thêm
       
        public decimal? TongTienHoaDon { get; set; }  // thêm

        // Navigation
        public ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = new List<HoaDon_ChiTiet>();
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }


        // Bổ sung nếu muốn hiển thị trạng thái giao trong danh sách hóa đơn
        [NotMapped] // Khai báo cái này để EF không tìm cột này trong DB
        public string? TrangThaiGiao { get; set; }

    }
}
