using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace pixy.Migrations
{
    /// <inheritdoc />
    public partial class crewmembersadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CharacterHeadPartId = table.Column<int>(type: "integer", nullable: false),
                    CharacterBodyPartId = table.Column<int>(type: "integer", nullable: false),
                    CharacterLegPartId = table.Column<int>(type: "integer", nullable: false),
                    Rarity = table.Column<string>(type: "text", nullable: false),
                    SpecialAbilityType = table.Column<string>(type: "text", nullable: false),
                    CollectionDesignId = table.Column<int>(type: "integer", nullable: false),
                    EquipmentMask = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CharacterDesignDescription = table.Column<string>(type: "text", nullable: false),
                    Hp = table.Column<int>(type: "integer", nullable: false),
                    FinalHp = table.Column<int>(type: "integer", nullable: false),
                    BaseAttack = table.Column<double>(type: "double precision", nullable: false),
                    FinalAttack = table.Column<double>(type: "double precision", nullable: false),
                    BaseRepair = table.Column<double>(type: "double precision", nullable: false),
                    FinalRepair = table.Column<double>(type: "double precision", nullable: false),
                    SpecialAbilityBaseArgument = table.Column<double>(type: "double precision", nullable: false),
                    SpecialAbilityFinalArgument = table.Column<double>(type: "double precision", nullable: false),
                    BasePilot = table.Column<double>(type: "double precision", nullable: false),
                    FinalPilot = table.Column<double>(type: "double precision", nullable: false),
                    BaseScience = table.Column<double>(type: "double precision", nullable: false),
                    FinalScience = table.Column<double>(type: "double precision", nullable: false),
                    BaseWeapon = table.Column<double>(type: "double precision", nullable: false),
                    FinalWeapon = table.Column<double>(type: "double precision", nullable: false),
                    BaseEngine = table.Column<double>(type: "double precision", nullable: false),
                    FinalEngine = table.Column<double>(type: "double precision", nullable: false),
                    WalkingSpeed = table.Column<int>(type: "integer", nullable: false),
                    RunSpeed = table.Column<int>(type: "integer", nullable: false),
                    FireResistance = table.Column<int>(type: "integer", nullable: false),
                    TrainingCapacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestiges",
                columns: table => new
                {
                    PrestigeID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberOneId = table.Column<int>(type: "integer", nullable: false),
                    MemberTwoId = table.Column<int>(type: "integer", nullable: false),
                    ResultMemberId = table.Column<int>(type: "integer", nullable: false),
                    PrestigeValue = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestiges", x => x.PrestigeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewMembers");

            migrationBuilder.DropTable(
                name: "Prestiges");
        }
    }
}
