using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    adresseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gateadresse = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    husnummer = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    postnummer = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    sted = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.adresseId);
                });

            migrationBuilder.CreateTable(
                name: "CCandidates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    mobilenumber = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    adresseId = table.Column<string>(nullable: true),
                    adresseId1 = table.Column<int>(nullable: true),
                    stilling = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCandidates", x => x.id);
                    table.ForeignKey(
                        name: "FK_CCandidates_Adresse_adresseId1",
                        column: x => x.adresseId1,
                        principalTable: "Adresse",
                        principalColumn: "adresseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CCandidates_adresseId1",
                table: "CCandidates",
                column: "adresseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCandidates");

            migrationBuilder.DropTable(
                name: "Adresse");
        }
    }
}
