using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalTI2.Data.Migrations
{
    public partial class atBaseDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    MedicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.MedicId);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Utente",
                columns: table => new
                {
                    UtenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente", x => x.UtenteId);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceitaData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicoIDFK = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    UtenteIDFK = table.Column<int>(type: "int", nullable: false),
                    UtenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.ReceitaId);
                    table.ForeignKey(
                        name: "FK_Receita_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receita_Utente_UtenteId",
                        column: x => x.UtenteId,
                        principalTable: "Utente",
                        principalColumn: "UtenteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicamentoReceita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceitaFk = table.Column<int>(type: "int", nullable: false),
                    MedicamentoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentoReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicamentoReceita_Medicamento_MedicamentoFk",
                        column: x => x.MedicamentoFk,
                        principalTable: "Medicamento",
                        principalColumn: "MedicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentoReceita_Receita_ReceitaFk",
                        column: x => x.ReceitaFk,
                        principalTable: "Receita",
                        principalColumn: "ReceitaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medicamento",
                columns: new[] { "MedicId", "Nome", "Preco" },
                values: new object[] { 1, "Benuron", 5m });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "MedicoId", "Especialidade", "Fotografia", "Nome" },
                values: new object[,]
                {
                    { 1, "Genecologista", "JoaoJoca.jpg", "JoÃ£o Joca" },
                    { 2, "Morto", "PauloGuedes.jpg", "Paulo Guedes" }
                });

            migrationBuilder.InsertData(
                table: "Receita",
                columns: new[] { "ReceitaId", "MedicoIDFK", "MedicoId", "Preco", "ReceitaData", "UtenteIDFK", "UtenteId" },
                values: new object[] { 1, 2, null, 5m, new DateTime(2021, 7, 14, 0, 15, 8, 35, DateTimeKind.Local).AddTicks(6792), 2, null });

            migrationBuilder.InsertData(
                table: "Utente",
                columns: new[] { "UtenteId", "DataNasc", "NIF", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "Filipe Vieira" },
                    { 2, new DateTime(1998, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "987654321", "Gabriel Bonet" }
                });

            migrationBuilder.InsertData(
                table: "MedicamentoReceita",
                columns: new[] { "Id", "MedicamentoFk", "ReceitaFk" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoReceita_MedicamentoFk",
                table: "MedicamentoReceita",
                column: "MedicamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoReceita_ReceitaFk",
                table: "MedicamentoReceita",
                column: "ReceitaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_MedicoId",
                table: "Receita",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_UtenteId",
                table: "Receita",
                column: "UtenteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentoReceita");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Utente");
        }
    }
}
