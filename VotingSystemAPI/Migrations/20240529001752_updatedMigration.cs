using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingSystemAPI.Migrations
{
    public partial class updatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BallotVotes",
                columns: table => new
                {
                    VoterName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BallotType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Candidate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BallotVotes", x => new { x.VoterName, x.BallotType });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BallotVotes");
        }
    }
}
