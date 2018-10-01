using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SistemaCDC.Data.Migrations
{
    public partial class seguro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeguroMedico",
                columns: table => new
                {
                    SeguroID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellidos = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    FechaNacimemto = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    NombrePadre = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguroMedico", x => x.SeguroID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeguroMedico");
        }
    }
}
