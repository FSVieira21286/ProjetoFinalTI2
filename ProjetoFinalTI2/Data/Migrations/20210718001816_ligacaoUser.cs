using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalTI2.Data.Migrations
{
    public partial class ligacaoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Utente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lig",
                table: "Utente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 18, 1, 18, 16, 308, DateTimeKind.Local).AddTicks(1570));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Utente");

            migrationBuilder.DropColumn(
                name: "lig",
                table: "Utente");

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 14, 1, 27, 58, 359, DateTimeKind.Local).AddTicks(8497));
        }
    }
}
