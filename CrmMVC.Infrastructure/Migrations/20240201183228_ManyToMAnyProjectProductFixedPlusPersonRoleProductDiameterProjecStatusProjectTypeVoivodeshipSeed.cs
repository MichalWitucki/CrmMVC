using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrmMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMAnyProjectProductFixedPlusPersonRoleProductDiameterProjecStatusProjectTypeVoivodeshipSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProjectTypes",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProjectStatuses",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductUnits",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductDiameters",
                newName: "Diameter");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PersonRoles",
                newName: "Role");

            migrationBuilder.InsertData(
                table: "PersonRoles",
                columns: new[] { "Id", "Role" },
                values: new object[,]
                {
                    { 1, "Przedstawiciel" },
                    { 2, "Handlowiec" },
                    { 3, "Projektant" },
                    { 4, "Asystent" },
                    { 5, "Kierownik" },
                    { 6, "Dyrektor" },
                    { 7, "Doradca" },
                    { 8, "Właściciel" },
                    { 9, "Inna" }
                });

            migrationBuilder.InsertData(
                table: "ProductDiameters",
                columns: new[] { "Id", "Diameter" },
                values: new object[,]
                {
                    { 1, "100" },
                    { 2, "150" },
                    { 3, "200" },
                    { 4, "250" },
                    { 5, "300" },
                    { 6, "400" },
                    { 7, "500" },
                    { 8, "600" },
                    { 9, "800" }
                });

            migrationBuilder.InsertData(
                table: "ProductUnits",
                columns: new[] { "Id", "Unit" },
                values: new object[,]
                {
                    { 1, "M." },
                    { 2, "SZT." }
                });

            migrationBuilder.InsertData(
                table: "ProjectStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Nowy" },
                    { 2, "W opracowaniu" },
                    { 3, "Planowany" },
                    { 4, "Zapytanie" },
                    { 5, "Zgłoszony" },
                    { 6, "Zrealizowany" },
                    { 7, "Utracony" },
                    { 8, "Nie dotyczy" },
                    { 9, "Zdublowany" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Projektuj" },
                    { 2, "Buduj" },
                    { 3, "Projektuj i buduj" }
                });

            migrationBuilder.InsertData(
                table: "Voivodeships",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Donośląskie" },
                    { 2, "Kujawsko-Pomorskie" },
                    { 3, "Lubelskie" },
                    { 4, "Lubuskie" },
                    { 5, "Łódzkie" },
                    { 6, "Małopolskie" },
                    { 7, "Mazowieckie" },
                    { 8, "Opolskie" },
                    { 9, "Podkarpackie" },
                    { 10, "Podlaskie" },
                    { 11, "Pomorskie" },
                    { 12, "Śląskie" },
                    { 13, "Świętokrzyskie" },
                    { 14, "Warmińsko-Mazurskie" },
                    { 15, "Wielkopolskie" },
                    { 16, "Zachodniopomorskie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductDiameters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectStatuses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Voivodeships",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "ProjectTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ProjectStatuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "ProductUnits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Diameter",
                table: "ProductDiameters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "PersonRoles",
                newName: "Name");
        }
    }
}
