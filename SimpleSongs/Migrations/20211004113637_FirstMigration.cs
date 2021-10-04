using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleSongs.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 1, "Fankomat", "Blenders", 220.0, "Ciągnik" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 2, "MOON EP", "M.O.O.N.", 271.0, "Hydrogen" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 3, "...Baby One More Time", "Britney Spears", 210.0, "...Baby One More Time" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
