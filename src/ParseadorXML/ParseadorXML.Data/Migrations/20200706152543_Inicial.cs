using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParseadorXML.Infra.Data.EFRepositories.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comprobantes",
                columns: table => new
                {
                    UUID = table.Column<string>(type: "varchar(36)", nullable: false),
                    Version = table.Column<string>(type: "varchar(100)", maxLength: 2, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(100)", nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprobantes", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "Concepto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Total = table.Column<double>(nullable: false),
                    ComprobanteUUID = table.Column<string>(nullable: true),
                    UUID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concepto_Comprobantes_ComprobanteUUID",
                        column: x => x.ComprobanteUUID,
                        principalTable: "Comprobantes",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emisores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    RFC = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    RazonSocial = table.Column<string>(type: "varchar(1000)", nullable: true),
                    UUID = table.Column<string>(type: "varchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emisores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emisores_Comprobantes_UUID",
                        column: x => x.UUID,
                        principalTable: "Comprobantes",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receptores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    RFC = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    RazonSocial = table.Column<string>(type: "varchar(1000)", nullable: true),
                    UUID = table.Column<string>(type: "varchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receptores_Comprobantes_UUID",
                        column: x => x.UUID,
                        principalTable: "Comprobantes",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concepto_ComprobanteUUID",
                table: "Concepto",
                column: "ComprobanteUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Emisores_UUID",
                table: "Emisores",
                column: "UUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receptores_UUID",
                table: "Receptores",
                column: "UUID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concepto");

            migrationBuilder.DropTable(
                name: "Emisores");

            migrationBuilder.DropTable(
                name: "Receptores");

            migrationBuilder.DropTable(
                name: "Comprobantes");
        }
    }
}
