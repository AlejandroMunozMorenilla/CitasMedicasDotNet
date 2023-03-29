using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HOSPITAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValoracionEspecialista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumColegiado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoCita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attribute11 = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_Diagnosticos_DiagnosticoId",
                        column: x => x.DiagnosticoId,
                        principalTable: "Diagnosticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Usuarios_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Citas_Usuarios_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicoPaciente",
                columns: table => new
                {
                    MedicosId = table.Column<int>(type: "int", nullable: false),
                    PacientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoPaciente", x => new { x.MedicosId, x.PacientesId });
                    table.ForeignKey(
                        name: "FK_MedicoPaciente_Usuarios_MedicosId",
                        column: x => x.MedicosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicoPaciente_Usuarios_PacientesId",
                        column: x => x.PacientesId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DiagnosticoId",
                table: "Citas",
                column: "DiagnosticoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoId",
                table: "Citas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoPaciente_PacientesId",
                table: "MedicoPaciente",
                column: "PacientesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "MedicoPaciente");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
