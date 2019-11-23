using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Authenticateservice.Migrations
{
    public partial class Authmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Mentorid = table.Column<string>(nullable: false),
                    Mentorname = table.Column<string>(nullable: false),
                    MobileNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    Skills = table.Column<string>(nullable: false),
                    timeslot = table.Column<string>(nullable: false),
                    availability = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Mentorid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MobileNo = table.Column<string>(maxLength: 10, nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
