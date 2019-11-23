using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Trainingservice.Migrations
{
    public partial class newmigtra : Migration
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
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<string>(nullable: false),
                    SkillName = table.Column<string>(maxLength: 50, nullable: false),
                    TOC = table.Column<string>(nullable: false),
                    fee = table.Column<double>(nullable: false),
                    Duration = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
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

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingID = table.Column<string>(nullable: false),
                    UID = table.Column<string>(nullable: false),
                    Mentorid = table.Column<string>(nullable: false),
                    SkillID = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    timeslot = table.Column<string>(nullable: false),
                    status = table.Column<string>(nullable: false),
                    Progress = table.Column<string>(nullable: false),
                    rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingID);
                    table.ForeignKey(
                        name: "FK_Training_Mentors_Mentorid",
                        column: x => x.Mentorid,
                        principalTable: "Mentors",
                        principalColumn: "Mentorid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Users_UID",
                        column: x => x.UID,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<string>(nullable: false),
                    UId = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Mentorid = table.Column<string>(nullable: true),
                    Mentor_Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Mentors_Mentorid",
                        column: x => x.Mentorid,
                        principalTable: "Mentors",
                        principalColumn: "Mentorid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Mentorid",
                table: "Payments",
                column: "Mentorid");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TrainingId",
                table: "Payments",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UId",
                table: "Payments",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mentorid",
                table: "Training",
                column: "Mentorid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SkillID",
                table: "Training",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UID",
                table: "Training",
                column: "UID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
