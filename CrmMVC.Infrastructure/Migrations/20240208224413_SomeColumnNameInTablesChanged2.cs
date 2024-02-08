using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SomeColumnNameInTablesChanged2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_TypeId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Companies",
                newName: "CompanyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_TypeId",
                table: "Companies",
                newName: "IX_Companies_CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeId",
                table: "Companies",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                newName: "IX_Companies_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_TypeId",
                table: "Companies",
                column: "TypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
