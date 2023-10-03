using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e7225dd-cee7-420b-9277-2c1863915e36", "e696c9b4-1af0-4188-8960-00f9f847c300", "Administrator", "ADMINISTRATOR" },
                    { "f49e3b73-4892-47ac-b69a-5d315c3cd11e", "b00f66ef-d3c4-4e7b-b5ae-962e9b9c7d2d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c46e3c4-14f7-48cf-85d1-7d2090371576", 0, "834e804a-48e8-4e43-a6c2-1503d9b90fbc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "System", "Admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEXTwRQ/nwqfsgWpWwMrYrdfyWAYjGnc5Hdetpc+kMkMBW2wQutz2I6i1Fy+XihKXA==", null, false, "89f22eb7-7720-4cfd-aa3d-f33c91e02d2f", null, false, null },
                    { "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc", 0, "8fbb23cc-7604-4adf-8f8e-b272d2e82f9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEmvQil9qc8uFjeUwbWVGWAxjRwKmDU9uqsLmiKu46bxFPvIpQD9KD1jUFBMOdyBWg==", null, false, "5f6bca5e-0f94-4758-9be2-670d89fa6686", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3e7225dd-cee7-420b-9277-2c1863915e36", "2c46e3c4-14f7-48cf-85d1-7d2090371576" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f49e3b73-4892-47ac-b69a-5d315c3cd11e", "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e7225dd-cee7-420b-9277-2c1863915e36", "2c46e3c4-14f7-48cf-85d1-7d2090371576" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f49e3b73-4892-47ac-b69a-5d315c3cd11e", "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc");
        }
    }
}
