using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudWeather.Report.Migrations
{
    public partial class ChangeColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TempLowF",
                table: "weather_report",
                newName: "AverageLowF");

            migrationBuilder.RenameColumn(
                name: "TempHighF",
                table: "weather_report",
                newName: "AverageHighF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AverageLowF",
                table: "weather_report",
                newName: "TempLowF");

            migrationBuilder.RenameColumn(
                name: "AverageHighF",
                table: "weather_report",
                newName: "TempHighF");
        }
    }
}
