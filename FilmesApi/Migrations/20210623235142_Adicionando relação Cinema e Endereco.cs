using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesApi.Migrations
{
    public partial class AdicionandorelaçãoCinemaeEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoFK",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_EnderecoFK",
                table: "Cinemas",
                column: "EnderecoFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoFK",
                table: "Cinemas",
                column: "EnderecoFK",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoFK",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_EnderecoFK",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "EnderecoFK",
                table: "Cinemas");
        }
    }
}
