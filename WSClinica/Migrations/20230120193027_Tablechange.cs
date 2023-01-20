using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSClinica.Migrations
{
    public partial class Tablechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinica",
                columns: table => new
                {
                    IdClinica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    FechaInicioAcitivades = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.IdClinica);
                });

            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    ClinicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_Habitaciones_Clinica_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinica",
                        principalColumn: "IdClinica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_ClinicaId",
                table: "Habitaciones",
                column: "ClinicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Clinica");
        }
    }
}
