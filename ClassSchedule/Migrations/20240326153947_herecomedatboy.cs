using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ch12Ex1ClassSchedule.Migrations
{
    /// <inheritdoc />
    public partial class herecomedatboy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1,
                column: "MilitaryTime",
                value: "1500");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 6,
                column: "DayId",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1,
                column: "MilitaryTime",
                value: "1100");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 6,
                column: "DayId",
                value: 3);
        }
    }
}
