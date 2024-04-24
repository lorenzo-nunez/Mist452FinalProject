﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mist452FinalProject.Data;

#nullable disable

namespace Mist452FinalProject.Migrations
{
    [DbContext(typeof(ProjectDBContext))]
    [Migration("20240424212730_addingidentitytables")]
    partial class addingidentitytables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Mist452FinalProject.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameID"));

                    b.Property<int>("SavesStat")
                        .HasColumnType("int");

                    b.Property<string>("filmURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("foulsStat")
                        .HasColumnType("int");

                    b.Property<string>("gameDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opponent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("posessionStat")
                        .HasColumnType("int");

                    b.Property<string>("score")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("shotsStat")
                        .HasColumnType("int");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = 1,
                            SavesStat = 5,
                            filmURL = "http://example.com/game1film",
                            foulsStat = 8,
                            gameDate = "2023-04-10",
                            opponent = "Team A",
                            posessionStat = 54,
                            score = "2-1",
                            shotsStat = 15
                        },
                        new
                        {
                            GameID = 2,
                            SavesStat = 7,
                            filmURL = "http://example.com/game2film",
                            foulsStat = 11,
                            gameDate = "2023-04-17",
                            opponent = "Team B",
                            posessionStat = 60,
                            score = "1-1",
                            shotsStat = 20
                        },
                        new
                        {
                            GameID = 3,
                            SavesStat = 3,
                            filmURL = "http://example.com/game3film",
                            foulsStat = 14,
                            gameDate = "2023-04-24",
                            opponent = "Team C",
                            posessionStat = 48,
                            score = "0-3",
                            shotsStat = 12
                        });
                });

            modelBuilder.Entity("Mist452FinalProject.Models.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurveyId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteMatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoritePlayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInterestedInVolunteering")
                        .HasColumnType("bit");

                    b.Property<string>("LeastFavoritePlayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParticipantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuggestionsForImprovement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamSatisfaction")
                        .HasColumnType("int");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");

                    b.HasData(
                        new
                        {
                            SurveyId = 1,
                            Age = 30,
                            Email = "alex.smith@example.com",
                            FavoriteMatch = "Match 1",
                            FavoritePlayer = "Player A",
                            IsInterestedInVolunteering = true,
                            LeastFavoritePlayer = "Player B",
                            ParticipantName = "Alex Smith",
                            SuggestionsForImprovement = "More community events",
                            TeamSatisfaction = 5
                        },
                        new
                        {
                            SurveyId = 2,
                            Age = 25,
                            Email = "jamie.doe@example.com",
                            FavoriteMatch = "Match 3",
                            FavoritePlayer = "Player C",
                            IsInterestedInVolunteering = false,
                            LeastFavoritePlayer = "Player D",
                            ParticipantName = "Jamie Doe",
                            SuggestionsForImprovement = "Better merchandise options",
                            TeamSatisfaction = 4
                        },
                        new
                        {
                            SurveyId = 3,
                            Age = 28,
                            Email = "chris.lee@example.com",
                            FavoriteMatch = "Match 5",
                            FavoritePlayer = "Player E",
                            IsInterestedInVolunteering = true,
                            LeastFavoritePlayer = "Player F",
                            ParticipantName = "Chris Lee",
                            SuggestionsForImprovement = "Improved stadium facilities",
                            TeamSatisfaction = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
