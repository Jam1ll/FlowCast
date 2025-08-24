using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCast.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class refactorizingPropertiesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Results",
                table: "PredictionResults");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PredictionResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PredictionMode",
                table: "PredictionDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PredictionResults");

            migrationBuilder.DropColumn(
                name: "PredictionMode",
                table: "PredictionDatas");

            migrationBuilder.AddColumn<decimal>(
                name: "Results",
                table: "PredictionResults",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
