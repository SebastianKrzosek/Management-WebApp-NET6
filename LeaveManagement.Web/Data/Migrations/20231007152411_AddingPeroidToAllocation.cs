using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeroidToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Peroid",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "d5f0f8ab-74f5-42a2-a45c-b580d85cd46d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "0000a5f9-7203-4c28-bff6-2f914bbc1ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e08dd1d3-44a7-4f66-ac03-6e21ead2a0e6", new DateTime(2023, 10, 7, 17, 24, 11, 317, DateTimeKind.Local).AddTicks(2066), "AQAAAAEAACcQAAAAELzU7da1xaMi584MKutBZY2jwWLEKkRaln0T0y13l2vCEVfLYqoRfKmePT+bfGHgFw==", "44776252-c581-4859-8c33-655a00abf863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75c82791-5ed5-43c7-88f9-c59671b27f6a", new DateTime(2023, 10, 7, 17, 24, 11, 325, DateTimeKind.Local).AddTicks(263), "AQAAAAEAACcQAAAAENx7aLLOQat11QK11a7FCF0YwOtqNgcx+gzp+ZY4WzrDIQyy5HixKKCTLswCrm1Bcw==", "66e2ac4d-2393-4dd5-a016-757fc831a3f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peroid",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cc7cbab-4e6c-4c5a-8eba-5ca4c39f96a7", new DateTime(2023, 10, 3, 20, 43, 53, 531, DateTimeKind.Local).AddTicks(2140), "AQAAAAEAACcQAAAAECQT2dvMxWW6N1nsBRcVxIdi2bbQKIRg6LcmipbDpwjrkAizAirVrGv6wrCEGuk75w==", "2711140a-bd97-48e2-8969-56f2eff9910a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831dce0f-534b-4099-9251-fde8b2472b84", new DateTime(2023, 10, 3, 20, 43, 53, 539, DateTimeKind.Local).AddTicks(3154), "AQAAAAEAACcQAAAAEG9cgZoTThZvoTFj+/sT/2BzRRMdoXBX+ab2Zb/jl4ONsauBTCy/ucDErMApU5oUjg==", "dc3bf3c2-327c-4846-80c2-ef256200e687" });
        }
    }
}
