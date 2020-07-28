using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class fckin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresse_AdresseId",
                table: "CCandidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresse",
                table: "Adresse");

            migrationBuilder.RenameTable(
                name: "Adresse",
                newName: "Adresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "AdresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresses_AdresseId",
                table: "CCandidates",
                column: "AdresseId",
                principalTable: "Adresses",
                principalColumn: "AdresseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresses_AdresseId",
                table: "CCandidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "Adresse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresse",
                table: "Adresse",
                column: "AdresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresse_AdresseId",
                table: "CCandidates",
                column: "AdresseId",
                principalTable: "Adresse",
                principalColumn: "AdresseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
