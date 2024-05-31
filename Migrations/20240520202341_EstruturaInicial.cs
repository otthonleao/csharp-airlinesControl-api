using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlinesControl.Migrations
{
    /// <inheritdoc />
    public partial class EstruturaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_AIRCAFT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabricante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AIRCAFT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PILOTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PILOTS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_MAINTENANCE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    AircraftId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MAINTENANCE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_MAINTENANCE_TB_AIRCAFT_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "TB_AIRCAFT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_FLIGHTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DataHoraPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AircraftId = table.Column<int>(type: "int", nullable: false),
                    PilotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FLIGHTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_FLIGHTS_TB_AIRCAFT_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "TB_AIRCAFT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FLIGHTS_TB_PILOTS_PilotId",
                        column: x => x.PilotId,
                        principalTable: "TB_PILOTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CANCELLATION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataHoraNotificacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CANCELLATION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CANCELLATION_TB_FLIGHTS_VooId",
                        column: x => x.VooId,
                        principalTable: "TB_FLIGHTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CANCELLATION_VooId",
                table: "TB_CANCELLATION",
                column: "VooId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_FLIGHTS_AircraftId",
                table: "TB_FLIGHTS",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FLIGHTS_PilotId",
                table: "TB_FLIGHTS",
                column: "PilotId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_MAINTENANCE_AircraftId",
                table: "TB_MAINTENANCE",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PILOTS_Matricula",
                table: "TB_PILOTS",
                column: "Matricula",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CANCELLATION");

            migrationBuilder.DropTable(
                name: "TB_MAINTENANCE");

            migrationBuilder.DropTable(
                name: "TB_FLIGHTS");

            migrationBuilder.DropTable(
                name: "TB_AIRCAFT");

            migrationBuilder.DropTable(
                name: "TB_PILOTS");
        }
    }
}
