using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class AuthorsAndBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auhtors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DebutYear = table.Column<int>(nullable: false),
                    Ranking = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auhtors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Publication = table.Column<string>(maxLength: 50, nullable: true),
                    Year = table.Column<int>(maxLength: 50, nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Auhtors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Auhtors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Auhtors",
                columns: new[] { "Id", "DebutYear", "Name", "Ranking" },
                values: new object[,]
                {
                    { 1, 1990, "Nicholas Sparks", 10 },
                    { 2, 1890, "J.R.R Tolkien", 4 },
                    { 3, 2000, "Delia Owens", 7 },
                    { 4, 2007, "Ryan Holiday", 32 },
                    { 5, 1970, "Charles Duhigg", 15 },
                    { 6, 2006, "Andy Weir", 2 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "GenreId", "Publication", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, "Grand Central Publishing", "The Notebook", 2014 },
                    { 2, 1, 1, "RAO", "The Longest Ride", 2018 },
                    { 3, 2, 3, "Allen & Unwin ", "The Hobbit", 2012 },
                    { 4, 3, 4, "Arthur", "Where the Crawdads sing", 2016 },
                    { 5, 3, 4, "Arthur", "Where the Crawdads sing", 2016 },
                    { 6, 4, 5, "Nautilus English Books", "Ego is the enemy", 2013 },
                    { 7, 5, 5, "Wired", "The power of habit", 2015 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Auhtors");
        }
    }
}
