using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrmMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProjectAndProductRelationChangedToMtM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Projects_ProjectId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProjectId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductsInProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInProjects", x => new { x.ProjectId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsInProjects_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInProjects_ProductId",
                table: "ProductsInProjects",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsInProjects");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProjectId",
                table: "Products",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Projects_ProjectId",
                table: "Products",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
