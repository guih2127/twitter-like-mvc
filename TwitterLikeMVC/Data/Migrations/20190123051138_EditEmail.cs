using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitterLikeMVC.Data.Migrations
{
    public partial class EditEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "UserEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Posts",
                newName: "UserId");
        }
    }
}
