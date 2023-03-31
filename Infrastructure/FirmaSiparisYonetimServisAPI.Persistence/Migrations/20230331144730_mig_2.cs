using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaSiparisYonetimServisAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoBarcode",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RMACode",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoBarcode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RMACode",
                table: "Orders");
        }
    }
}
