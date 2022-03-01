using Microsoft.EntityFrameworkCore.Migrations;

namespace CascadingDropdown.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DropCities_Countries_CountryId",
                table: "DropCities");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "DropCities",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_DropCities_CountryId",
                table: "DropCities",
                newName: "IX_DropCities_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_DropCities_States_StateId",
                table: "DropCities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DropCities_States_StateId",
                table: "DropCities");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "DropCities",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_DropCities_StateId",
                table: "DropCities",
                newName: "IX_DropCities_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DropCities_Countries_CountryId",
                table: "DropCities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
