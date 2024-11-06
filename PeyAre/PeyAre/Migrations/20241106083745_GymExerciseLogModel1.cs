using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeyAre.Migrations
{
    /// <inheritdoc />
    public partial class GymExerciseLogModel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryRPMs");

            migrationBuilder.CreateTable(
                name: "GymExerciseLogModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymExerciseLogModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymExerciseLogModels");

            migrationBuilder.CreateTable(
                name: "HistoryRPMs",
                columns: table => new
                {
                    HistoryRPMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableLifts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedLift = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lift = table.Column<int>(type: "int", nullable: false),
                    reps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRPMs", x => x.HistoryRPMId);
                });
        }
    }
}
