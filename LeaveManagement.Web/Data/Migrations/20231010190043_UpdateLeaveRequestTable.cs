using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequsetComment",
                table: "LeaveRequests",
                newName: "RequestComment");

            migrationBuilder.RenameColumn(
                name: "LeaveRequested",
                table: "LeaveRequests",
                newName: "DateRequested");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestComment",
                table: "LeaveRequests",
                newName: "RequsetComment");

            migrationBuilder.RenameColumn(
                name: "DateRequested",
                table: "LeaveRequests",
                newName: "LeaveRequested");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "e8f0e869-77d7-4100-bf6e-5512fa6c0fda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "7f7904aa-391d-48c2-8235-be93a1f7caf5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da426feb-b9f2-472f-be32-62f7ad1df021", new DateTime(2023, 10, 10, 19, 11, 21, 320, DateTimeKind.Local).AddTicks(6056), "AQAAAAEAACcQAAAAELPkICkDEETHSSCGM8mJTuANoRulHdhFcUTS/5W5Bf4Q3DMnX+z7IfJWu00/jB3IwA==", "cda8e7be-1ae0-4a60-b1d3-20ad2db39990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbf2011d-d944-4108-bf32-f68677cb2f39", new DateTime(2023, 10, 10, 19, 11, 21, 329, DateTimeKind.Local).AddTicks(8159), "AQAAAAEAACcQAAAAEBqUIV95dg69HILwDwumq8oCEwXczkpDSfWNAGfTeaGlRhUkRrCBh4Gb9I9qLJkpvg==", "b558650d-944b-424f-be15-57f55dbcbde9" });
        }
    }
}
