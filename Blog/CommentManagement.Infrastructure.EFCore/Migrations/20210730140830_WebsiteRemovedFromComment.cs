using Microsoft.EntityFrameworkCore.Migrations;

namespace CommentManagement.Infrastructure.EFCore.Migrations
{
    public partial class WebsiteRemovedFromComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Website",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
