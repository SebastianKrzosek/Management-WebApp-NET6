using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestsTab : Migration
    {
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
                    LeaveRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequsetComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: false),
                    RequstingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
