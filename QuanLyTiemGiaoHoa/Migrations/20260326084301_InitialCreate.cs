using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTiemGiaoHoa.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiaoHang_HoaDonID",
                table: "GiaoHang");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "PhieuNhap");

            migrationBuilder.DropColumn(
                name: "ThanhTien",
                table: "ChiTiet_PhieuNhap");

            migrationBuilder.AddColumn<string>(
                name: "DienThoaiNhan",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenNguoiNhan",
                table: "GiaoHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "SoLuongNhap",
                table: "ChiTiet_PhieuNhap",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoHang_HoaDonID",
                table: "GiaoHang",
                column: "HoaDonID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiaoHang_HoaDonID",
                table: "GiaoHang");

            migrationBuilder.DropColumn(
                name: "DienThoaiNhan",
                table: "GiaoHang");

            migrationBuilder.DropColumn(
                name: "TenNguoiNhan",
                table: "GiaoHang");

            migrationBuilder.AddColumn<decimal>(
                name: "TongTien",
                table: "PhieuNhap",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SoLuongNhap",
                table: "ChiTiet_PhieuNhap",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTiet_PhieuNhap",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_GiaoHang_HoaDonID",
                table: "GiaoHang",
                column: "HoaDonID");
        }
    }
}
