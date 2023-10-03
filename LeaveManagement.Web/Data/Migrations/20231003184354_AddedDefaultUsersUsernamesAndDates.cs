using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesAndDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "bd5bdbb5-266d-4b80-811f-570ab45fc45c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "43ad15c2-462f-4608-aa94-4836381b87da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9cc7cbab-4e6c-4c5a-8eba-5ca4c39f96a7", new DateTime(2023, 10, 3, 20, 43, 53, 531, DateTimeKind.Local).AddTicks(2140), new DateTime(1998, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECQT2dvMxWW6N1nsBRcVxIdi2bbQKIRg6LcmipbDpwjrkAizAirVrGv6wrCEGuk75w==", "2711140a-bd97-48e2-8969-56f2eff9910a", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "831dce0f-534b-4099-9251-fde8b2472b84", new DateTime(2023, 10, 3, 20, 43, 53, 539, DateTimeKind.Local).AddTicks(3154), new DateTime(1998, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEG9cgZoTThZvoTFj+/sT/2BzRRMdoXBX+ab2Zb/jl4ONsauBTCy/ucDErMApU5oUjg==", "dc3bf3c2-327c-4846-80c2-ef256200e687", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "e696c9b4-1af0-4188-8960-00f9f847c300");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "b00f66ef-d3c4-4e7b-b5ae-962e9b9c7d2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "834e804a-48e8-4e43-a6c2-1503d9b90fbc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEXTwRQ/nwqfsgWpWwMrYrdfyWAYjGnc5Hdetpc+kMkMBW2wQutz2I6i1Fy+XihKXA==", "89f22eb7-7720-4cfd-aa3d-f33c91e02d2f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8fbb23cc-7604-4adf-8f8e-b272d2e82f9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEmvQil9qc8uFjeUwbWVGWAxjRwKmDU9uqsLmiKu46bxFPvIpQD9KD1jUFBMOdyBWg==", "5f6bca5e-0f94-4758-9be2-670d89fa6686", null });
        }
    }
}
