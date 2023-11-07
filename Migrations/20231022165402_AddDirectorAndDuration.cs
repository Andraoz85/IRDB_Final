using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IRDb.Migrations
{
    /// <inheritdoc />
    public partial class AddDirectorAndDuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Director", "Duration", "Genre" },
                values: new object[] { "Lilly Wachowski, Lana Wachowski", 136, "Action, Sci-Fi" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Director", "Duration", "Genre" },
                values: new object[] { "Jonathan Demme", 118, "Crime, Drama, Thriller" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Director", "Duration" },
                values: new object[] { "Milos Forman", 133 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Duration", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 4, "Quentin Tarantino", 154, "Crime, Drama", 8.9m, "Pulp Fiction", 1994 },
                    { 5, "William Friedkin", 122, "Horror", 8.1m, "Exorcisten", 1973 },
                    { 6, "Frank Darabont", 142, "Drama", 9.3m, "The Shawshank Redemption", 1994 },
                    { 7, "Christopher Nolan", 169, "Action, Drama, Sci-Fi", 8.7m, "Interstellar", 2014 },
                    { 8, "Peter Jackson", 178, "Action, Adventure, Drama", 8.8m, "The Lord of the Rings: The Fellowship of the Ring", 2001 },
                    { 9, "Robert Zemeckis", 142, "Drama, Romance", 8.8m, "Forrest Gump", 1994 },
                    { 10, "Christopher Nolan", 148, "Action, Adventure, Sci-Fi", 8.8m, "Inception", 2010 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genre",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genre",
                value: "Thriller");
        }
    }
}
