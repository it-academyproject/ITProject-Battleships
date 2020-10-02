﻿// <auto-generated />
using System;
using ITProject_Battleships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITProject_Battleships.Migrations
{
    [DbContext(typeof(BattleContext))]
    partial class BattleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITProject_Battleships.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedUserData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Army", b =>
                {
                    b.Property<int>("ArmyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmyShips")
                        .HasColumnType("int");

                    b.Property<int?>("BattleFieldId")
                        .HasColumnType("int");

                    b.HasKey("ArmyId");

                    b.HasIndex("BattleFieldId");

                    b.ToTable("Armies");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Battle", b =>
                {
                    b.Property<int>("BattleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BattleBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BattleEnd")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BattleFieldId")
                        .HasColumnType("int");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<int>("RemainTurns")
                        .HasColumnType("int");

                    b.Property<int>("Score1")
                        .HasColumnType("int");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.HasKey("BattleId");

                    b.HasIndex("ArmyId");

                    b.HasIndex("BattleFieldId");

                    b.HasIndex("ChallengeId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.BattleAction", b =>
                {
                    b.Property<int>("BattleActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BattleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BattleMoment")
                        .HasColumnType("datetime2");

                    b.Property<bool>("BattleResult")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PositionX")
                        .HasColumnType("int");

                    b.Property<int>("PositionY")
                        .HasColumnType("int");

                    b.HasKey("BattleActionId");

                    b.HasIndex("BattleId");

                    b.HasIndex("PlayerId");

                    b.ToTable("BattleActions");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.BattleField", b =>
                {
                    b.Property<int>("BattleFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("BattleFieldId");

                    b.ToTable("BattleFields");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.BattleShip", b =>
                {
                    b.Property<int>("BattleShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BattleId")
                        .HasColumnType("int");

                    b.Property<int>("Orientation")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PositionX")
                        .HasColumnType("int");

                    b.Property<int>("PositionY")
                        .HasColumnType("int");

                    b.Property<int>("ShipType")
                        .HasColumnType("int");

                    b.HasKey("BattleShipId");

                    b.HasIndex("BattleId");

                    b.HasIndex("PlayerId");

                    b.ToTable("BattleShips");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Challenge", b =>
                {
                    b.Property<int>("ChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ChallengeMoment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId1")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId2")
                        .HasColumnType("int");

                    b.Property<bool>("Resolution")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ResolutionMoment")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurnsNumbers")
                        .HasColumnType("int");

                    b.HasKey("ChallengeId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BattlesDraw")
                        .HasColumnType("int");

                    b.Property<int>("BattlesLost")
                        .HasColumnType("int");

                    b.Property<int>("BattlesWon")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedUserData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.PlayerChallenge", b =>
                {
                    b.Property<int>("PlayerChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("PlayerChallengeId");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerChallenge");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Army", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.BattleField", "BattleField")
                        .WithMany()
                        .HasForeignKey("BattleFieldId");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Battle", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.Army", "Army")
                        .WithMany()
                        .HasForeignKey("ArmyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITProject_Battleships.Models.BattleField", "BattleField")
                        .WithMany()
                        .HasForeignKey("BattleFieldId");

                    b.HasOne("ITProject_Battleships.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITProject_Battleships.Models.BattleAction", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITProject_Battleships.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITProject_Battleships.Models.BattleShip", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId");

                    b.HasOne("ITProject_Battleships.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.Challenge", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.Player", null)
                        .WithMany("Challenges")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("ITProject_Battleships.Models.PlayerChallenge", b =>
                {
                    b.HasOne("ITProject_Battleships.Models.Challenge", "Challenge")
                        .WithMany("PlayerChallenges")
                        .HasForeignKey("ChallengeId");

                    b.HasOne("ITProject_Battleships.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}
