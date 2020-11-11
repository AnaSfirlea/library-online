using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class PopulateAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DebutYear", "FirstName", "LastName", "Ranking" },
                values: new object[] { 7, 2006, "Martha", "Stewart", 2 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DebutYear", "FirstName", "LastName", "Ranking" },
                values: new object[] { 8, 2006, "John", "Doe", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
