using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathProject.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsPrime = table.Column<bool>(type: "bit", nullable: false),
                    IsPerfect = table.Column<bool>(type: "bit", nullable: false),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitSum = table.Column<int>(type: "int", nullable: false),
                    FunFact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Numbers");
        }
    }
}
