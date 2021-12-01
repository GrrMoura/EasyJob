using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyJob_Infra.Migrations
{
    public partial class tste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "aidi",
                table: "US_States",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "US_StateId",
                table: "US_Cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aidi",
                table: "US_Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "aidiState",
                table: "US_Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_US_Cities_US_StateId",
                table: "US_Cities",
                column: "US_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_US_Cities_US_States_US_StateId",
                table: "US_Cities",
                column: "US_StateId",
                principalTable: "US_States",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_US_Cities_US_States_US_StateId",
                table: "US_Cities");

            migrationBuilder.DropIndex(
                name: "IX_US_Cities_US_StateId",
                table: "US_Cities");

            migrationBuilder.DropColumn(
                name: "aidi",
                table: "US_States");

            migrationBuilder.DropColumn(
                name: "US_StateId",
                table: "US_Cities");

            migrationBuilder.DropColumn(
                name: "aidi",
                table: "US_Cities");

            migrationBuilder.DropColumn(
                name: "aidiState",
                table: "US_Cities");
        }
    }
}
