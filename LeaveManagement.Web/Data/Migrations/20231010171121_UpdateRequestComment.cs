using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequsetComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequsetComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7225dd-cee7-420b-9277-2c1863915e36",
                column: "ConcurrencyStamp",
                value: "f3cb801e-4929-4e05-8b83-c26bc49b39bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                column: "ConcurrencyStamp",
                value: "c66c61ed-ef8e-4ccf-9526-12953053725b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a973fd35-404c-4817-8da1-c96fdd9615a8", new DateTime(2023, 10, 10, 10, 2, 57, 676, DateTimeKind.Local).AddTicks(8412), "AQAAAAEAACcQAAAAEG5BEC9k5Ii1HBRVtee11pa+sIq6tYMKl6MFkI2DSHZRvtC6ziBtWLH7sfAKD+fEYw==", "fdcedb2c-aef8-4bf6-a2d6-5e50c11aac8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d2d63a-2b50-4ca4-8c90-3f4e588484b0", new DateTime(2023, 10, 10, 10, 2, 57, 684, DateTimeKind.Local).AddTicks(9131), "AQAAAAEAACcQAAAAEE90XVmuDuy2JSpw3YtgGA7P16WHzO8kx+SOzeG6vL4Zqs1loHUodXRBP144A/O1JQ==", "ff664adf-2c48-44d3-9f24-cefc39404eef" });
        }
    }
}
