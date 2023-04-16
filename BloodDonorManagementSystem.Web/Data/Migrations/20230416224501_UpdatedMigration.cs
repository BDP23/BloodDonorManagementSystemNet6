using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonorManagementSystem.Web.Data.Migrations
{
    public partial class UpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "BloodTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "BloodProductsAllocations",
                newName: "DateModified");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "BloodTypes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "BloodProductsAllocations",
                newName: "DateUpdated");
        }
    }
}
