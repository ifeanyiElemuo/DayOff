using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayOff.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18578dda-fd1e-4d21-9380-78dc83af61fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41915a7b-fe45-40dd-befa-e94deb3d326b", "AQAAAAIAAYagAAAAEBi2CRNFwG3GLhSVGwOCzBF56J8KbwaOPm2Tu97AFhzmSPr5TQUUismAgcXuzdSs7g==", "bbc8a699-8e8b-480c-b213-4550a97c7520" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75818bbc-ef2c-1b34-0983-65ab79ed17cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f83ef39-2f25-4dc8-879e-74993c012cfb", "AQAAAAIAAYagAAAAEMQyS/fWX5WgdIxe2gLEfLq1b5yhX6q3dsDN8aokwDbHITTyUV7AbkctpsUyHqQMaQ==", "69631511-81a7-40bd-b6ea-ad63f5f1e290" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18578dda-fd1e-4d21-9380-78dc83af61fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9adb2799-3ac7-4d4d-b635-ebd432924ce9", "AQAAAAIAAYagAAAAEGLlrUYi/ijisqx4c34fpATC+wJ0oIYTbo+CU25ZVZu8CY9U+UO0fhTzaKaxQksbdg==", "6450d899-2e87-4d7b-912e-efb7dd913f1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75818bbc-ef2c-1b34-0983-65ab79ed17cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2324f45-aa63-4065-a020-eb13995d467a", "AQAAAAIAAYagAAAAEIw/LBeOuLV2NVKmaOgg4KsSnEBLI/ohdxGhIVJH16Ti0c/ErJlRbh6r14D0WE/J4Q==", "abf41ab7-b82c-4b27-9db4-5be8cfb97b28" });
        }
    }
}
