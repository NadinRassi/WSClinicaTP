using Microsoft.EntityFrameworkCore.Migrations;

namespace WSClinica.Migrations
{
    public partial class TablesChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Clinica_ClinicaId",
                table: "Habitaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones");

            migrationBuilder.RenameTable(
                name: "Habitaciones",
                newName: "Habitacion");

            migrationBuilder.RenameIndex(
                name: "IX_Habitaciones_ClinicaId",
                table: "Habitacion",
                newName: "IX_Habitacion_ClinicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion",
                column: "IdMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_Clinica_ClinicaId",
                table: "Habitacion",
                column: "ClinicaId",
                principalTable: "Clinica",
                principalColumn: "IdClinica",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_Clinica_ClinicaId",
                table: "Habitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion");

            migrationBuilder.RenameTable(
                name: "Habitacion",
                newName: "Habitaciones");

            migrationBuilder.RenameIndex(
                name: "IX_Habitacion_ClinicaId",
                table: "Habitaciones",
                newName: "IX_Habitaciones_ClinicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones",
                column: "IdMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Clinica_ClinicaId",
                table: "Habitaciones",
                column: "ClinicaId",
                principalTable: "Clinica",
                principalColumn: "IdClinica",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
