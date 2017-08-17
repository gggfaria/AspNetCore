using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjetoBase.Persistence.Entity.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PESSOAS",
                columns: table => new
                {
                    PES_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PES_CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PES_NOME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAS", x => x.PES_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PESSOAS_PES_CPF",
                table: "PESSOAS",
                column: "PES_CPF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PESSOAS");
        }
    }
}
