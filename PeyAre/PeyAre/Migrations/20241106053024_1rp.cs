using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeyAre.Migrations
{
    /// <inheritdoc />
    public partial class _1rp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepMaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightLifted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    OneRepMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepMaxes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepMaxes");
        }
    }
}
