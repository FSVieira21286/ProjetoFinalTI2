using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalTI2.Data.Migrations
{
    public partial class preco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Preco",
                table: "Receita",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                columns: new[] { "Preco", "ReceitaData" },
                values: new object[] { "5", new DateTime(2021, 7, 19, 1, 41, 15, 267, DateTimeKind.Local).AddTicks(9952) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Receita",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Receita",
                keyColumn: "ReceitaId",
                keyValue: 1,
                columns: new[] { "Preco", "ReceitaData" },
                values: new object[] { 5m, new DateTime(2021, 7, 18, 16, 20, 51, 625, DateTimeKind.Local).AddTicks(1549) });
        }
    }
}
