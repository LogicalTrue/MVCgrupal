using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCClasico.Migrations
{
    public partial class portalbasededatosinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alias = table.Column<string>(nullable: true),
                    nombreCompleto = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    edad = table.Column<int>(nullable: false),
                    FechaInscripto = table.Column<DateTime>(nullable: false),
                    DeporteFavorito = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
