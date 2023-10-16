using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequstingEmployeeId",
                table: "LeaveRequests",
                newName: "RequestingEmployeeId");

            migrationBuilder.RenameColumn(
                name: "RequestComment",
                table: "LeaveRequests",
                newName: "RequestComments");

            migrationBuilder.RenameColumn(
                name: "Canceled",
                table: "LeaveRequests",
                newName: "Cancelled");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "3c1a4f09-4815-4993-9509-f704e5d077a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "c3f406ae-ad42-4044-b1da-6ba7dd5a8e6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72837223-0e22-4af9-97c0-8f302725dd26", new DateTime(2023, 10, 11, 18, 56, 27, 626, DateTimeKind.Local).AddTicks(1478), "AQAAAAEAACcQAAAAELMxiJdWMhFU5k722YyxWqm1XPchEG9HB0qqEMiUXM5YmeKmGj+i/UNOztAd97xRRA==", "5fd405d9-ba5d-4a67-89bf-bd9ac7760069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a701e0b-8df4-40b8-9846-ffd6669eaa83", new DateTime(2023, 10, 11, 18, 56, 27, 633, DateTimeKind.Local).AddTicks(8747), "AQAAAAEAACcQAAAAEDjXVd1nMcJAkqUlM6GnfR92RF89b0arv8+5Y2B1GUfHrx00pfRe21fLrmJHw9TuvQ==", "644f3686-a394-48a2-8981-91cfec6ed19e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                newName: "RequstingEmployeeId");

            migrationBuilder.RenameColumn(
                name: "RequestComments",
                table: "LeaveRequests",
                newName: "RequestComment");

            migrationBuilder.RenameColumn(
                name: "Cancelled",
                table: "LeaveRequests",
                newName: "Canceled");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "493a8199-a1f1-4f24-a484-94c4d1005ef9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "e14ea9e1-a9fa-4baf-b4c8-6dc11e30d0f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c32d99c5-ebca-4cc2-9afc-8c3ad365f261", new DateTime(2023, 10, 10, 21, 0, 42, 855, DateTimeKind.Local).AddTicks(8496), "AQAAAAEAACcQAAAAEGz5LHjf9Fk15ietphH+HDO2M0V2v2yxxlbKYFnEHQg9O6fNoiakP57fq7zxwLW8ng==", "153b28aa-ee9f-471f-9438-c3cee6e9e2ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26109488-9124-4661-a8d5-3f2bc194548a", new DateTime(2023, 10, 10, 21, 0, 42, 863, DateTimeKind.Local).AddTicks(9987), "AQAAAAEAACcQAAAAEC8JJeSqg0+Z8igV/OQG6y9ZG6ROHfkj2SUXjVYlfWm9MVRyvY6BwcWwRsKa50wTsQ==", "3676c4fb-6814-4ee7-9d2a-a75c8b614f8f" });
        }
    }
}
