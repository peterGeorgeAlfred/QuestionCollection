using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionCollections.Data.Migrations
{
    public partial class qusestionBody : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Body",
                table: "Questions");
        }
    }
}
