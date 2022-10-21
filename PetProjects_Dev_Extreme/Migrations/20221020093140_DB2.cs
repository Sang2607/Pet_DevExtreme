using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetProjects_Dev_Extreme.Migrations
{
    public partial class DB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    SchedulerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassStudent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maths = table.Column<int>(type: "int", nullable: false),
                    Physical = table.Column<int>(type: "int", nullable: false),
                    Chemistry = table.Column<int>(type: "int", nullable: false),
                    Medium = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.SchedulerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
