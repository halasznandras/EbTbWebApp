using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EbTbWebApp.Data.Migrations
{
    public partial class elso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gazdi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GazdiNev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GazdiCim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GazdiTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllatId = table.Column<int>(type: "int", nullable: false),
                    AllatNev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzulIdo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FajId = table.Column<int>(type: "int", nullable: false),
                    OltasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gazdi", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gazdi");
        }
    }
}
