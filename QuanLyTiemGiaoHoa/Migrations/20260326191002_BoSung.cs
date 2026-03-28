using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTiemGiaoHoa.Migrations
{
    /// <inheritdoc />
    public partial class BoSung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PhiGiaoHang",
                table: "HoaDon",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhiGiaoHang",
                table: "HoaDon");
        }
    }
}
