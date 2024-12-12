using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Arquitecture.Infraestructure.Data.Migrations
{
    public partial class EntityShooping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shoopings",
                columns: table => new
                {
                    ShoopingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ShoopingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoopings", x => x.ShoopingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoopings");
        }
    }
}
