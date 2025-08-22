using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCast.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PredictionDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Values = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictionDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PredictionResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Results = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PredictionMode = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PredictionDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredictionResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PredictionResults_PredictionDatas_PredictionDataId",
                        column: x => x.PredictionDataId,
                        principalTable: "PredictionDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PredictionResults_PredictionDataId",
                table: "PredictionResults",
                column: "PredictionDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PredictionResults");

            migrationBuilder.DropTable(
                name: "PredictionDatas");
        }
    }
}
