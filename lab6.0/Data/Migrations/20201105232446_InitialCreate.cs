using Microsoft.EntityFrameworkCore.Migrations;

namespace lab6._0.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    IsDone = table.Column<int>(nullable: false),
                    Created = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 7, 1, "a", 0 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 8, 1, "b", 0 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 9, 1, "c", 1 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 10, 1, "d", 0 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 11, 0, "e", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
