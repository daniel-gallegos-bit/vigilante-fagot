using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scarecrow.Infrestructure.Migrations
{
    public partial class InitialModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChipId = table.Column<int>(nullable: false),
                    Distancia = table.Column<float>(maxLength: 20, nullable: false),
                    Hora = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Fecha = table.Column<DateTime>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dato", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dato");
        }
    }
}
