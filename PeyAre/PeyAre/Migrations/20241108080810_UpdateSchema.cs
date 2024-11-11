using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeyAre.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GymExerciseLogModels",
                table: "GymExerciseLogModels");

            migrationBuilder.RenameTable(
                name: "GymExerciseLogModels",
                newName: "GymExerciseLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymExerciseLogs",
                table: "GymExerciseLogs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GymExerciseLogs",
                table: "GymExerciseLogs");

            migrationBuilder.RenameTable(
                name: "GymExerciseLogs",
                newName: "GymExerciseLogModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymExerciseLogModels",
                table: "GymExerciseLogModels",
                column: "Id");
        }
    }
}
