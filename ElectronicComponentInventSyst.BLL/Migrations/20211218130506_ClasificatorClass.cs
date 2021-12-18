using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicComponentInventSyst.BLL.Migrations
{
    public partial class ClasificatorClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "ElectronicComponents");

            migrationBuilder.DropColumn(
                name: "Footprint",
                table: "ElectronicComponents");

            migrationBuilder.DropColumn(
                name: "StorageLocation",
                table: "ElectronicComponents");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ElectronicComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FootprintId",
                table: "ElectronicComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StorageLocationId",
                table: "ElectronicComponents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicComponents_CategoryId",
                table: "ElectronicComponents",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicComponents_FootprintId",
                table: "ElectronicComponents",
                column: "FootprintId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicComponents_StorageLocationId",
                table: "ElectronicComponents",
                column: "StorageLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicComponents_Categories_CategoryId",
                table: "ElectronicComponents",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicComponents_Footprints_FootprintId",
                table: "ElectronicComponents",
                column: "FootprintId",
                principalTable: "Footprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicComponents_StoragaLocations_StorageLocationId",
                table: "ElectronicComponents",
                column: "StorageLocationId",
                principalTable: "StoragaLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicComponents_Categories_CategoryId",
                table: "ElectronicComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicComponents_Footprints_FootprintId",
                table: "ElectronicComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicComponents_StoragaLocations_StorageLocationId",
                table: "ElectronicComponents");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicComponents_CategoryId",
                table: "ElectronicComponents");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicComponents_FootprintId",
                table: "ElectronicComponents");

            migrationBuilder.DropIndex(
                name: "IX_ElectronicComponents_StorageLocationId",
                table: "ElectronicComponents");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ElectronicComponents");

            migrationBuilder.DropColumn(
                name: "FootprintId",
                table: "ElectronicComponents");

            migrationBuilder.DropColumn(
                name: "StorageLocationId",
                table: "ElectronicComponents");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "ElectronicComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Footprint",
                table: "ElectronicComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageLocation",
                table: "ElectronicComponents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
