using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModelsRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "VoivodeshipName",
                table: "Voivodeships",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProjectTypeName",
                table: "ProjectTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ProjectStatuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "PersonRoleName",
                table: "PersonRoles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeName",
                table: "CompanyTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CompanyTypeId",
                table: "Companies",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Companies",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                newName: "IX_Companies_TypeId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ContactPeople",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ContactPeople",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_TypeId",
                table: "Companies",
                column: "TypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyTypes_TypeId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Voivodeships",
                newName: "VoivodeshipName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProjectTypes",
                newName: "ProjectTypeName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProjectStatuses",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PersonRoles",
                newName: "PersonRoleName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CompanyTypes",
                newName: "CompanyTypeName");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Companies",
                newName: "CompanyTypeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companies",
                newName: "CompanyName");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_TypeId",
                table: "Companies",
                newName: "IX_Companies_CompanyTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "ContactPeople",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ContactPeople",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyTypes_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
