using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITProject_Battleships.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedUserData = table.Column<DateTime>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "BattleFields",
                columns: table => new
                {
                    BattleFieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleFields", x => x.BattleFieldId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedUserData = table.Column<DateTime>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    Nickname = table.Column<string>(nullable: true),
                    BattlesWon = table.Column<int>(nullable: false),
                    BattlesLost = table.Column<int>(nullable: false),
                    BattlesDraw = table.Column<int>(nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Armies",
                columns: table => new
                {
                    ArmyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmyShips = table.Column<int>(nullable: false),
                    BattleFieldId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armies", x => x.ArmyId);
                    table.ForeignKey(
                        name: "FK_Armies_BattleFields_BattleFieldId",
                        column: x => x.BattleFieldId,
                        principalTable: "BattleFields",
                        principalColumn: "BattleFieldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId1 = table.Column<int>(nullable: false),
                    PlayerId2 = table.Column<int>(nullable: false),
                    ChallengeMoment = table.Column<DateTime>(nullable: false),
                    ResolutionMoment = table.Column<DateTime>(nullable: false),
                    Resolution = table.Column<bool>(nullable: false),
                    TurnsNumbers = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengeId);
                    table.ForeignKey(
                        name: "FK_Challenges_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    BattleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleBegin = table.Column<DateTime>(nullable: false),
                    BattleEnd = table.Column<DateTime>(nullable: false),
                    RemainTurns = table.Column<int>(nullable: false),
                    Score1 = table.Column<int>(nullable: false),
                    Score2 = table.Column<int>(nullable: false),
                    ChallengeId = table.Column<int>(nullable: false),
                    ArmyId = table.Column<int>(nullable: false),
                    BattleFieldId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.BattleId);
                    table.ForeignKey(
                        name: "FK_Battles_Armies_ArmyId",
                        column: x => x.ArmyId,
                        principalTable: "Armies",
                        principalColumn: "ArmyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Battles_BattleFields_BattleFieldId",
                        column: x => x.BattleFieldId,
                        principalTable: "BattleFields",
                        principalColumn: "BattleFieldId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Battles_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "ChallengeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerChallenge",
                columns: table => new
                {
                    PlayerChallengeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(nullable: true),
                    ChallengeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerChallenge", x => x.PlayerChallengeId);
                    table.ForeignKey(
                        name: "FK_PlayerChallenge_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "ChallengeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerChallenge_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleActions",
                columns: table => new
                {
                    BattleActionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionX = table.Column<int>(nullable: false),
                    PositionY = table.Column<int>(nullable: false),
                    BattleResult = table.Column<bool>(nullable: false),
                    BattleMoment = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleActions", x => x.BattleActionId);
                    table.ForeignKey(
                        name: "FK_BattleActions_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleActions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BattleShips",
                columns: table => new
                {
                    BattleShipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipType = table.Column<int>(nullable: false),
                    Orientation = table.Column<int>(nullable: false),
                    PositionX = table.Column<int>(nullable: false),
                    PositionY = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true),
                    BattleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleShips", x => x.BattleShipId);
                    table.ForeignKey(
                        name: "FK_BattleShips_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "BattleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleShips_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armies_BattleFieldId",
                table: "Armies",
                column: "BattleFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleActions_BattleId",
                table: "BattleActions",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleActions_PlayerId",
                table: "BattleActions",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_ArmyId",
                table: "Battles",
                column: "ArmyId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_BattleFieldId",
                table: "Battles",
                column: "BattleFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_ChallengeId",
                table: "Battles",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleShips_BattleId",
                table: "BattleShips",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleShips_PlayerId",
                table: "BattleShips",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_PlayerId",
                table: "Challenges",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerChallenge_ChallengeId",
                table: "PlayerChallenge",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerChallenge_PlayerId",
                table: "PlayerChallenge",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "BattleActions");

            migrationBuilder.DropTable(
                name: "BattleShips");

            migrationBuilder.DropTable(
                name: "PlayerChallenge");

            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Armies");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "BattleFields");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
