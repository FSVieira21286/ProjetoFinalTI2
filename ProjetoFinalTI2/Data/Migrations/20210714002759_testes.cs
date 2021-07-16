using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalTI2.Data.Migrations
{
    public partial class testes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 14, 1, 27, 58, 359, DateTimeKind.Local).AddTicks(8497));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                column: "ReceitaData",
                value: new DateTime(2021, 7, 14, 1, 15, 31, 876, DateTimeKind.Local).AddTicks(6746));
        }
    }
}
