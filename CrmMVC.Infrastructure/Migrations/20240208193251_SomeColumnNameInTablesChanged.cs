using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SomeColumnNameInTablesChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Voivodeships",
                newName: "VoivodeshipName");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "ProjectTypes",
                newName: "ProjectTypeName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "PersonRoles",
                newName: "PersonRoleName");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "CompanyTypes",
                newName: "CompanyTypeName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companies",
                newName: "CompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VoivodeshipName",
                table: "Voivodeships",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProjectTypeName",
                table: "ProjectTypes",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PersonRoleName",
                table: "PersonRoles",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeName",
                table: "CompanyTypes",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Companies",
                newName: "Name");
        }
    }
}
