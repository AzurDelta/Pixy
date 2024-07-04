using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace pixy.Migrations
{
    /// <inheritdoc />
    public partial class separatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EliteToUniques",
                columns: table => new
                {
                    PrestigeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EliteOneId = table.Column<int>(type: "integer", nullable: false),
                    EliteTwoId = table.Column<int>(type: "integer", nullable: false),
                    ResultUniqueId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EliteToUniques", x => x.PrestigeId);
                });

            migrationBuilder.CreateTable(
                name: "EpicToHeroes",
                columns: table => new
                {
                    PrestigeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EpicOneId = table.Column<int>(type: "integer", nullable: false),
                    EpicTwoId = table.Column<int>(type: "integer", nullable: false),
                    ResultHeroId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpicToHeroes", x => x.PrestigeId);
                });

            migrationBuilder.CreateTable(
                name: "HeroToLegs",
                columns: table => new
                {
                    PrestigeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HeroOneID = table.Column<int>(type: "integer", nullable: false),
                    HeroTwoID = table.Column<int>(type: "integer", nullable: false),
                    ResultLegID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroToLegs", x => x.PrestigeId);
                });

            migrationBuilder.CreateTable(
                name: "UniqueToEpics",
                columns: table => new
                {
                    PrestigeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueOneId = table.Column<int>(type: "integer", nullable: false),
                    UniqueTwoId = table.Column<int>(type: "integer", nullable: false),
                    ResultEpicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniqueToEpics", x => x.PrestigeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EliteToUniques");

            migrationBuilder.DropTable(
                name: "EpicToHeroes");

            migrationBuilder.DropTable(
                name: "HeroToLegs");

            migrationBuilder.DropTable(
                name: "UniqueToEpics");
        }
    }
}
