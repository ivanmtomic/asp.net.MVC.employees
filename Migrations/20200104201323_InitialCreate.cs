using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcEmployees.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NettoSallary = table.Column<decimal>(nullable: false),
                    BruttoSallary = table.Column<decimal>(nullable: false),
                    tax1 = table.Column<decimal>(nullable: false),
                    tax2 = table.Column<decimal>(nullable: false),
                    tax3 = table.Column<decimal>(nullable: false),
                    tax4 = table.Column<decimal>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
