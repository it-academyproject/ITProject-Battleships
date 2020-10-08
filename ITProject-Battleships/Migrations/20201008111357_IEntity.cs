using Microsoft.EntityFrameworkCore.Migrations;

namespace ITProject_Battleships.Migrations
{
    public partial class IEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Challenges_ChallengeId",
                table: "Battles");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChallenge_Challenges_ChallengeId",
                table: "PlayerChallenge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "ChallengeId",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Challenges",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Admins",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Challenges_ChallengeId",
                table: "Battles",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChallenge_Challenges_ChallengeId",
                table: "PlayerChallenge",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Challenges_ChallengeId",
                table: "Battles");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChallenge_Challenges_ChallengeId",
                table: "PlayerChallenge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "ChallengeId",
                table: "Challenges",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges",
                column: "ChallengeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Challenges_ChallengeId",
                table: "Battles",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "ChallengeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChallenge_Challenges_ChallengeId",
                table: "PlayerChallenge",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "ChallengeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
