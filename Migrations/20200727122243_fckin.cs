using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class fckin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresse_adresseId",
                table: "CCandidates");

            migrationBuilder.RenameColumn(
                name: "adresseId",
                table: "CCandidates",
                newName: "AdresseId");

            migrationBuilder.RenameIndex(
                name: "IX_CCandidates_adresseId",
                table: "CCandidates",
                newName: "IX_CCandidates_AdresseId");

            migrationBuilder.RenameColumn(
                name: "adresseId",
                table: "Adresse",
                newName: "AdresseId");

            migrationBuilder.AlterColumn<int>(
                name: "AdresseId",
                table: "CCandidates",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresse_AdresseId",
                table: "CCandidates",
                column: "AdresseId",
                principalTable: "Adresse",
                principalColumn: "AdresseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresse_AdresseId",
                table: "CCandidates");

            migrationBuilder.RenameColumn(
                name: "AdresseId",
                table: "CCandidates",
                newName: "adresseId");

            migrationBuilder.RenameIndex(
                name: "IX_CCandidates_AdresseId",
                table: "CCandidates",
                newName: "IX_CCandidates_adresseId");

            migrationBuilder.RenameColumn(
                name: "AdresseId",
                table: "Adresse",
                newName: "adresseId");

            migrationBuilder.AlterColumn<int>(
                name: "adresseId",
                table: "CCandidates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresse_adresseId",
                table: "CCandidates",
                column: "adresseId",
                principalTable: "Adresse",
                principalColumn: "adresseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
