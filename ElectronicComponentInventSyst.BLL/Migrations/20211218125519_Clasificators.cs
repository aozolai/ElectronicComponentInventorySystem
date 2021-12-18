using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicComponentInventSyst.BLL.Migrations
{
    public partial class Clasificators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footprints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoragaLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoragaLocations", x => x.Id);
                });

            migrationBuilder.InsertData("Categories", "Name", new object[] {
                "Active Components","Passive Components", "Electromechanical Parts", "Mechanical Parts", "Cables", "Speakers and Buzzers", "V Modules", "W PC Accessories", "X PCB Material", "Y Other Stuff", "Z Cooking", "Z Projects"
            });
            migrationBuilder.InsertData("Footprints", "Name", new object[] {
                "THT", "SMD"
            });
            migrationBuilder.InsertData("StoragaLocations", "Name", new object[] {
                "Box A", "Box B"
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Footprints");

            migrationBuilder.DropTable(
                name: "StoragaLocations");
        }
    }
}
