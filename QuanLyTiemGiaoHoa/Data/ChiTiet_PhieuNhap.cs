using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemGiaoHoa.Data
{
    public class ChiTiet_PhieuNhap
    {
        public int ID { get; set; }

        public int PhieuNhapID { get; set; }
        public int HoaID { get; set; }

        public short SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
     

        // Navigation
        public PhieuNhap PhieuNhap { get; set; }
        public Hoa Hoa { get; set; }
    }



    public class DanhSachChiTiet_PhieuNhap
    {
        public int ID { get; set; }

        public int PhieuNhapID { get; set; }
        public int HoaID { get; set; }
        public string TenHoa { get; set; } // Thêm 
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }

        [NotMapped] // Đảm bảo EF không tìm cột này trong database
        public decimal ThanhTien { get; set; }// thêm

    }


}
