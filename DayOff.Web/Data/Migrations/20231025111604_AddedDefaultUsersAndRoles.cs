using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DayOff.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14872ccf-ac9e-5c81-1720-78cc83aa61ad", null, "Administrator", "ADMINISTRATOR" },
                    { "41827cba-fe5c-2c39-0271-65ee34bb61da", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NINumber", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18578dda-fd1e-4d21-9380-78dc83af61fb", 0, "9adb2799-3ac7-4d4d-b635-ebd432924ce9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGLlrUYi/ijisqx4c34fpATC+wJ0oIYTbo+CU25ZVZu8CY9U+UO0fhTzaKaxQksbdg==", null, false, "6450d899-2e87-4d7b-912e-efb7dd913f1e", false, "admin@localhost.com" },
                    { "75818bbc-ef2c-1b34-0983-65ab79ed17cd", 0, "a2324f45-aa63-4065-a020-eb13995d467a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIw/LBeOuLV2NVKmaOgg4KsSnEBLI/ohdxGhIVJH16Ti0c/ErJlRbh6r14D0WE/J4Q==", null, false, "abf41ab7-b82c-4b27-9db4-5be8cfb97b28", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14872ccf-ac9e-5c81-1720-78cc83aa61ad", "18578dda-fd1e-4d21-9380-78dc83af61fb" },
                    { "41827cba-fe5c-2c39-0271-65ee34bb61da", "75818bbc-ef2c-1b34-0983-65ab79ed17cd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14872ccf-ac9e-5c81-1720-78cc83aa61ad", "18578dda-fd1e-4d21-9380-78dc83af61fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41827cba-fe5c-2c39-0271-65ee34bb61da", "75818bbc-ef2c-1b34-0983-65ab79ed17cd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14872ccf-ac9e-5c81-1720-78cc83aa61ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41827cba-fe5c-2c39-0271-65ee34bb61da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18578dda-fd1e-4d21-9380-78dc83af61fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75818bbc-ef2c-1b34-0983-65ab79ed17cd");
        }
    }
}
