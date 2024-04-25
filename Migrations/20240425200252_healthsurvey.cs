using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mist452FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class healthsurvey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthSurveys",
                columns: table => new
                {
                    HSurveyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    HeightFeet = table.Column<int>(type: "int", nullable: false),
                    HeightInches = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonForCheckUp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSmoker = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthSurveys", x => x.HSurveyId);
                });

            migrationBuilder.InsertData(
                table: "HealthSurveys",
                columns: new[] { "HSurveyId", "Age", "AppointmentDate", "HeightFeet", "HeightInches", "IsSmoker", "ParticipantName", "ReasonForCheckUp", "Weight" },
                values: new object[,]
                {
                    { 1, 34, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10, false, "John Doe", "Annual Physical", 185 },
                    { 2, 29, new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, true, "Jane Smith", "General Consultation", 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthSurveys");
        }
    }
}
