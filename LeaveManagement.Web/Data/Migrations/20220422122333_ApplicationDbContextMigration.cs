using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ApplicationDbContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "LeaveTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "LeaveTypes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "LeaveAllocations",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "LeaveAllocations",
                newName: "DateCreated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveTypes",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "LeaveTypes",
                newName: "DateJoined");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveAllocations",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "LeaveAllocations",
                newName: "DateJoined");
        }
    }
}
