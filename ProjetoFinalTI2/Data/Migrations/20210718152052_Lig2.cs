using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalTI2.Data.Migrations
{
    public partial class Lig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lig",
                table: "Medico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 18, 16, 20, 51, 625, DateTimeKind.Local).AddTicks(1549));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lig",
                table: "Medico");

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 18, 1, 18, 16, 308, DateTimeKind.Local).AddTicks(1570));
        }
    }
}
