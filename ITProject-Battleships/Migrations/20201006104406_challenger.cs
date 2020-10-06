using Microsoft.EntityFrameworkCore.Migrations;

namespace ITProject_Battleships.Migrations
{
    public partial class challenger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleActions_Battles_BattleId",
                table: "BattleActions");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleActions_Players_PlayerId",
                table: "BattleActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Armies_ArmyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "PlayerId1",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "PlayerId2",
                table: "Challenges");

            migrationBuilder.AddColumn<bool>(
                name: "IsChallenger",
                table: "PlayerChallenge",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ArmyId",
                table: "Battles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "BattleActions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "BattleActions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleActions_Battles_BattleId",
                table: "BattleActions",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleActions_Players_PlayerId",
                table: "BattleActions",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Armies_ArmyId",
                table: "Battles",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "ArmyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleActions_Battles_BattleId",
                table: "BattleActions");

            migrationBuilder.DropForeignKey(
                name: "FK_BattleActions_Players_PlayerId",
                table: "BattleActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Armies_ArmyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "IsChallenger",
                table: "PlayerChallenge");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId1",
                table: "Challenges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId2",
                table: "Challenges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ArmyId",
                table: "Battles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "BattleActions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "BattleActions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleActions_Battles_BattleId",
                table: "BattleActions",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleActions_Players_PlayerId",
                table: "BattleActions",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Armies_ArmyId",
                table: "Battles",
                column: "ArmyId",
                principalTable: "Armies",
                principalColumn: "ArmyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
