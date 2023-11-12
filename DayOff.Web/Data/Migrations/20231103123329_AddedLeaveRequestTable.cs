using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayOff.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
