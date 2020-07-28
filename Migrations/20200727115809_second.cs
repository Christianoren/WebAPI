using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresse_adresseId1",
                table: "CCandidates");

            migrationBuilder.DropIndex(
                name: "IX_CCandidates_adresseId1",
                table: "CCandidates");

            migrationBuilder.DropColumn(
                name: "adresseId1",
                table: "CCandidates");

            migrationBuilder.AlterColumn<int>(
                name: "adresseId",
                table: "CCandidates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CCandidates_adresseId",
                table: "CCandidates",
                column: "adresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresse_adresseId",
                table: "CCandidates",
                column: "adresseId",
                principalTable: "Adresse",
                principalColumn: "adresseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CCandidates_Adresse_adresseId",
                table: "CCandidates");

            migrationBuilder.DropIndex(
                name: "IX_CCandidates_adresseId",
                table: "CCandidates");

            migrationBuilder.AlterColumn<string>(
                name: "adresseId",
                table: "CCandidates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "adresseId1",
                table: "CCandidates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CCandidates_adresseId1",
                table: "CCandidates",
                column: "adresseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CCandidates_Adresse_adresseId1",
                table: "CCandidates",
                column: "adresseId1",
                principalTable: "Adresse",
                principalColumn: "adresseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
