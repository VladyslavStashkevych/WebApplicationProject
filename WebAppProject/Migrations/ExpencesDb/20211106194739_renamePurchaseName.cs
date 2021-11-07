using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppProject.Migrations.ExpencesDb
{
    public partial class renamePurchaseName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Purchase",
                table: "Expenses",
                newName: "PurchaseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchaseName",
                table: "Expenses",
                newName: "Purchase");
        }
    }
}
