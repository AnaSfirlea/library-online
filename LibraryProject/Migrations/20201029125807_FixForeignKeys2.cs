using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class FixForeignKeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Auhtors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auhtors",
                table: "Auhtors");

            migrationBuilder.RenameTable(
                name: "Auhtors",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Auhtors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auhtors",
                table: "Auhtors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Auhtors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Auhtors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
