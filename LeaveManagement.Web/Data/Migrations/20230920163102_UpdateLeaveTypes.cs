using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "LeaveTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "LeaveTypes",
                newName: "DateCreate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveTypes",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "LeaveTypes",
                newName: "CreatedDate");
        }
    }
}
