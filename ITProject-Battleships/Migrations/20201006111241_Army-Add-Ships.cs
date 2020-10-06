using Microsoft.EntityFrameworkCore.Migrations;

namespace ITProject_Battleships.Migrations
{
    public partial class ArmyAddShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArmyShips",
                table: "Armies");

            migrationBuilder.AddColumn<int>(
                name: "BattleShips",
                table: "Armies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Boats",
                table: "Armies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carriers",
                table: "Armies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Submarines",
                table: "Armies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vessels",
                table: "Armies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleShips",
                table: "Armies");

            migrationBuilder.DropColumn(
                name: "Boats",
                table: "Armies");

            migrationBuilder.DropColumn(
                name: "Carriers",
                table: "Armies");

            migrationBuilder.DropColumn(
                name: "Submarines",
                table: "Armies");

            migrationBuilder.DropColumn(
                name: "Vessels",
                table: "Armies");

            migrationBuilder.AddColumn<int>(
                name: "ArmyShips",
                table: "Armies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
