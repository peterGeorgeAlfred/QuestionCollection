using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionCollections.Data.Migrations
{
    public partial class questhighyield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HighYield",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighYield",
                table: "Questions");
        }
    }
}
