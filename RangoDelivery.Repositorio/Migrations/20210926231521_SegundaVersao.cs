﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RangoDelivery.Repositorio.Migrations
{
    public partial class SegundaVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Enderecos_EnderecoId",
                table: "Empresas");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Empresas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Enderecos_EnderecoId",
                table: "Empresas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Enderecos_EnderecoId",
                table: "Empresas");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Empresas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Enderecos_EnderecoId",
                table: "Empresas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
