using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvidencijaRacunarskeOpreme.Tehnoloska.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "racunarskaOprema",
                columns: table => new
                {
                    IdKomponente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodjacKomponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelKomponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenaKomponente = table.Column<int>(type: "int", nullable: false),
                    DatumProizvodnje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZemljaPorekla = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_racunarskaOprema", x => x.IdKomponente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "racunarskaOprema");
        }
    }
}
