using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class BOOK_AuthorsFName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Books",
                newName: "AuthorLastName");

            migrationBuilder.AddColumn<string>(
                name: "AuthorFirstName",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorFirstName",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorLastName",
                table: "Books",
                newName: "AuthorName");
        }
    }
}
