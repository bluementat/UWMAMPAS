using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UWMAMPAS.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    PerformerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.PerformerId);
                    table.ForeignKey(
                        name: "FK_Performers_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "PerformerId", "MovieId", "Name" },
                values: new object[] { new Guid("0016c147-67ff-46f5-b2d7-f8afbbb61c16"), null, "Javier Bardem" });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "PerformerId", "MovieId", "Name" },
                values: new object[] { new Guid("4bff9bef-c675-4ef4-8db6-ddc967738b31"), null, "Benedict Cumberbatch" });

            migrationBuilder.CreateIndex(
                name: "IX_Performers_MovieId",
                table: "Performers",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
