using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayOff.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18578dda-fd1e-4d21-9380-78dc83af61fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b4be3e9-8a6e-4a89-bb68-af21426e1a0e", "AQAAAAIAAYagAAAAENnWzPTrEiWbEOmMctUETW98NJy4bkaXj6JmnkG5VZiKELTiS4DAI0gSd/6fvpVbVA==", "3ae2be3b-2b4d-4f5e-80c1-f9f6a17f1325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75818bbc-ef2c-1b34-0983-65ab79ed17cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01e4f2bb-d6c3-4a64-b377-f2351844d768", "AQAAAAIAAYagAAAAEBQw+tIEJsjWvL+PPMI5A0B8VNx5vAoX03kgf800P0FO4p8AyhdMFmMxI4YVVNqESg==", "a98087bd-ac80-4d9b-b3ca-49498b99585d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18578dda-fd1e-4d21-9380-78dc83af61fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ddaa93f-5be4-43a0-9bba-316ad2402fc8", "AQAAAAIAAYagAAAAEIXcLmQM/cBCuCGhzd1x2pYZkXz1LgKxmx/NH/TDLwrafqUVXo9B8yRjFAZXZZWFnw==", "23997ddd-8e48-4be2-97dc-699e963b6dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75818bbc-ef2c-1b34-0983-65ab79ed17cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be3c3e42-6036-4875-92df-0e1a42a7d4bc", "AQAAAAIAAYagAAAAEFCE4kM4zVPUZoAwcvcIrsZZMG72KQ/RKdhyY5X6kzJ5VajsZKLgH4VxOkF6os/asw==", "907995cf-07dd-4f88-9f5f-6bce5b71d36b" });
        }
    }
}
